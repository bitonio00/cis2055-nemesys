using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nemesys_project.Models;
using nemesys_project.Models.Interfaces;
using nemesys_project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Controllers
{
    public class InvestigatorSpaceController : Controller
    {

        private readonly INemesysUserRepository userRepository;
        private readonly UserManager<NemesysUser> userManager;
        private readonly IReportRepository reportRepository;
        private readonly IInvestigationRepository investigationRepository;

        public InvestigatorSpaceController(INemesysUserRepository userRepository, UserManager<NemesysUser> userManager,
            IReportRepository reportRepository, IInvestigationRepository investigationRepository)
        {
            this.userManager = userManager;
            this.userRepository = userRepository;
            this.reportRepository = reportRepository;
            this.investigationRepository = investigationRepository;
        }

        // GET: InvestigatorSpace
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "investigator")]
        public IActionResult ManageInvestigations()
        {
            return View(userRepository.GetAllUserInvestigations(userManager.GetUserId(User)));

        }
        public IActionResult ChooseReport()
        {
            return View(reportRepository.GetAllNotInvestigateReports());
        }
        [HttpGet]
        public IActionResult DeleteInvestigation(int id)
        {
            investigationRepository.Delete(id);
            return RedirectToAction("ManageInvestigations", "InvestigatorSpace");
        }
        [HttpGet]
        public async Task<IActionResult> EditInvestigation(int id)
        {
            var investigation = await investigationRepository.Find(id);
            var model = new EditInvestigationViewModel
            {
                InvestigationId=investigation.InvestigationId,
                DateOfAction = investigation.DateOfAction,
                Description = investigation.Description,
                StatusId = investigation.Report.StatusRefId,
                DateOfCreation=investigation.DateOfCreation,
                InvestigatorRefId=investigation.InvestigatorRefId,
                ReportRefId=investigation.ReportRefId,
                Status=investigation.Status
            };
            
            return View(model);
        }
        [HttpPost]
        public IActionResult EditInvestigation(EditInvestigationViewModel modelInvestigation)
        {
            if (ModelState.IsValid)
            {
                Investigation investigation = new Investigation
                {
                  DateOfAction= modelInvestigation.DateOfAction,
                  DateOfCreation= modelInvestigation.DateOfCreation,
                  Description=modelInvestigation.Description,
                  InvestigationId=modelInvestigation.InvestigationId,
                 InvestigatorRefId=modelInvestigation.InvestigatorRefId,
                 ReportRefId=modelInvestigation.ReportRefId,
                 Status=modelInvestigation.Status
                };
                investigationRepository.Update(investigation);
                reportRepository.UpdateStatus(modelInvestigation.ReportRefId, modelInvestigation.StatusId);
               // reportRepository.UpdateInvestigation(modelInvestigation.ReportRefId, modelInvestigation.InvestigationId);
                return RedirectToAction("ManageInvestigations", "InvestigatorSpace");
            }
            return View();


        }
        [HttpGet]
        public IActionResult CreateInvestigation(int id)
        {
            var model = new InvestigationViewModel
            {
                ReportId = id
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateInvestigation(InvestigationViewModel investigationModel)
        {
            if(ModelState.IsValid)
            {
                var investigation = new Investigation
                {
                    Description = investigationModel.Description,
                    DateOfCreation = DateTime.Now,
                    InvestigatorRefId= userManager.GetUserId(User),
                    ReportRefId=investigationModel.ReportId,
                    DateOfAction=investigationModel.DateOfAction       
                };
                investigationRepository.Add(investigation);
                reportRepository.UpdateStatus(investigationModel.ReportId, investigationModel.StatusId);
                reportRepository.UpdateInvestigation(investigationModel.ReportId, investigation.InvestigationId);
                return RedirectToAction("ManageInvestigations", "InvestigatorSpace");
            }
            return View(investigationModel);
        }
      
        // GET: InvestigatorSpace/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InvestigatorSpace/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InvestigatorSpace/Create
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

        // GET: InvestigatorSpace/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvestigatorSpace/Edit/5
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

        // GET: InvestigatorSpace/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InvestigatorSpace/Delete/5
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
