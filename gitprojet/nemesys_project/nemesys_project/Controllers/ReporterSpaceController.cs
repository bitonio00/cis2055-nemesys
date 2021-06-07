using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nemesys_project.Models;
using nemesys_project.Models.Interfaces;
using nemesys_project.ViewModel;
using NETCore.MailKit.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Controllers
{
    [Authorize(Roles = "reporter")]
    public class ReporterSpaceController : Controller
    {
        private readonly UserManager<NemesysUser> userManager;
        private readonly IReportRepository reportRepository;
        private readonly INemesysUserRepository userRepository;
        private readonly IStatusRepository statusRepository;
        private readonly IInvestigationRepository investigationRepository;
        private readonly IEmailService emailService;
        public ReporterSpaceController(UserManager<NemesysUser> userManager, IReportRepository reportRepository, INemesysUserRepository userRepository,
            IStatusRepository statusRepository, IInvestigationRepository investigationRepository, IEmailService emailService)
        {
            this.userManager = userManager;
            this.reportRepository = reportRepository;
            this.userRepository = userRepository;
            this.statusRepository = statusRepository;
            this.investigationRepository = investigationRepository;
            this.emailService = emailService;
        }

        // GET: ReporterSpaceController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReporterSpaceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReporterSpaceController/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Geocode()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Geocode(ReportViewModel report)
        {
           var a= report.HazardLocation;
            return View();
        }


        public IActionResult ManageReports()
        {

            return View(userRepository.GetAllUserReports(userManager.GetUserId(User)));
            
        }
        [HttpGet]
        public IActionResult DeleteReport(int id)
        {
          
            reportRepository.Delete(id);
            return RedirectToAction("ManageReports", "ReporterSpace");


        }
        public IActionResult AddReport()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddReport([Bind("HazardLocation,Lat,Lng,HazardDate,HazardType,Description, ImageToUpload")] ReportViewModel reportModel)
        {
            if(ModelState.IsValid)
            {
                string fileName = "";
                if (reportModel.ImageToUpload != null)
                {
                    //At this point you should check size, extension etc...
                    //Then persist using a new name for consistency (e.g. new Guid)
                    var extension = "." + reportModel.ImageToUpload.FileName.Split('.')[reportModel.ImageToUpload.FileName.Split('.').Length - 1];
                    fileName = Guid.NewGuid().ToString() + extension;
                    var path = Directory.GetCurrentDirectory() + "\\wwwroot\\images\\reports\\" + fileName;
                    using (var bits = new FileStream(path, FileMode.Create))
                    {
                        reportModel.ImageToUpload.CopyTo(bits);
                    }
                }
                
                float lat= float.Parse(reportModel.Lat.Replace(".",",")); 
                float lng= float.Parse(reportModel.Lng.Replace(".", ","));
                var id = userManager.GetUserId(User);
                var report = new Report
                {
                    CreationDate = DateTime.Now,
                    HazardDate = reportModel.HazardDate,
                    HazardLocation = reportModel.HazardLocation,
                    HazardType = reportModel.HazardType,
                    Description = reportModel.Description,
                    UpVote = 0,
                    StatusRefId = 1,
                    ReporterRefId =id,
                    LatitudeLocation =lat,
                    LongitudeLocation = lng,
                    ImageUrl = "/images/reports/" + fileName,

                };
                reportRepository.Add(report);
                var investigators=await userManager.GetUsersInRoleAsync("investigator");
                foreach(var investigator in investigators)
                {
                    await emailService.SendAsync(investigator.Email, "A new report!!!!", $"<a>A new report have been created come Investigate it<a>", true);
                }
                return RedirectToAction("ManageReports", "ReporterSpace");
            }
            
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ShowInvestigation(int id)
        {
            var report = await reportRepository.Find(id);
            var investigation = await investigationRepository.GetInvestigation(report.InvestigationRefId);
           return View(investigation);
        }
        [HttpGet]
        public async Task<IActionResult> EditReport(int id)
        {
            var report =await  reportRepository.Find(id);


            var model = new EditReportViewModel
            {
                Id = report.ReportId,
                Description = report.Description,
                HazardDate = report.HazardDate,
                HazardLocation = report.HazardLocation,
                HazardType = report.HazardType,
                StatusOfHazard = report.Status.StatusOfReport,
                StatusRefId = report.StatusRefId,
                CreationDate = report.CreationDate,
                LatitudeLocation = report.LatitudeLocation,
                LongitudeLocation = report.LongitudeLocation,
                UpVote = report.UpVote,
                ReporterRefId = report.ReporterRefId,
                InvestigationRefId = report.InvestigationRefId,
                VoteRefId = report.VoteRefId,
                ImageUrl = report.ImageUrl
                
            }; 
                return View(model);
        }

        [HttpPost]
        public IActionResult EditReport(EditReportViewModel modelReport)
        {
            //var report2 = await reportRepository.Find(modelReport.Id);
            //DateTime b = report2.CreationDate;
            if (ModelState.IsValid)
            {
                string fileName = "";
                string imageUrl = "";
                if (modelReport.ImageToUpload != null)
                {
                    //At this point you should check size, extension etc...
                    //Then persist using a new name for consistency (e.g. new Guid)
                    var extension = "." + modelReport.ImageToUpload.FileName.Split('.')[modelReport.ImageToUpload.FileName.Split('.').Length - 1];
                    fileName = Guid.NewGuid().ToString() + extension;
                    var path = Directory.GetCurrentDirectory() + "\\wwwroot\\images\\reports\\" + fileName;
                    using (var bits = new FileStream(path, FileMode.Create))
                    {
                        modelReport.ImageToUpload.CopyTo(bits);
                    }
                    imageUrl = "/images/reports/" + fileName;
                }
                else
                {
                    imageUrl = modelReport.ImageUrl;
                }

                Report report = new Report
                {
                    ReportId = modelReport.Id,
                    ReporterRefId = userManager.GetUserId(User),
                    Description = modelReport.Description,
                    HazardDate = modelReport.HazardDate,
                    HazardLocation = modelReport.HazardLocation,
                    HazardType = modelReport.HazardType,
                    StatusRefId = statusRepository.FindRefId(modelReport.StatusOfHazard),
                    CreationDate = modelReport.CreationDate,
                    LongitudeLocation = modelReport.LongitudeLocation,
                    LatitudeLocation = modelReport.LatitudeLocation,
                    UpVote = modelReport.UpVote,
                    InvestigationRefId=modelReport.InvestigationRefId,
                    VoteRefId=modelReport.VoteRefId,
                    ImageUrl= imageUrl


                };
                reportRepository.Update(report);
                return RedirectToAction("ManageReports", "ReporterSpace");
            }
            return View();


        }
        
            
        // POST: ReporterSpaceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReporterSpaceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReporterSpaceController/Edit/5
        [HttpPost]  
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReporterSpaceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReporterSpaceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
