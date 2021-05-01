using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nemesys_project.Models;
using nemesys_project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Controllers
{
    public class ReporterSpaceController : Controller
    {
        private readonly UserManager<NemesysUser> userManager;
        private readonly IReportRepository reportRepository;
        private readonly INemesysUserRepository userRepository;
        private readonly IStatusRepository statusRepository;
        public ReporterSpaceController(UserManager<NemesysUser> userManager, IReportRepository reportRepository, INemesysUserRepository userRepository, IStatusRepository statusRepository)
        {
            this.userManager = userManager;
            this.reportRepository = reportRepository;
            this.userRepository = userRepository;
            this.statusRepository = statusRepository;
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
        [Authorize(Roles="reporter")]
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
        public IActionResult AddReport(ReportViewModel reportModel)
        {
            if(ModelState.IsValid)
            {
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
                    LatitudeLocation = 0,
                    LongitudeLocation = 0,

                };
                reportRepository.Add(report);
                return RedirectToAction("ManageReports", "ReporterSpace");
            }
            
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditReport(int id)
        {
            var report =await  reportRepository.Find(id);
            var model = new EditReportViewModel
            {
                Id=report.ReportId,
                Description = report.Description,
                HazardDate = report.HazardDate,
                HazardLocation = report.HazardLocation,
                HazardType = report.HazardType,
                StatusOfHazard = report.Status.StatusOfReport,
                StatusRefId= report.StatusRefId,
                CreationDate=report.CreationDate,
                LatitudeLocation=report.LatitudeLocation,
                LongitudeLocation=report.LongitudeLocation,
                UpVote=report.UpVote,
                ReporterRefId=report.ReporterRefId
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
                    UpVote = modelReport.UpVote
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
