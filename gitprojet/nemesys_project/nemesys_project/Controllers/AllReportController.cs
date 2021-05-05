using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nemesys_project.Models;
using nemesys_project.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Controllers
{
    public class AllReportController : Controller
    {
        private readonly INemesysUserRepository userRepository;
        private readonly UserManager<NemesysUser> userManager;
        private readonly IReportRepository reportRepository;
        private readonly IInvestigationRepository investigationRepository;
        private readonly IVoteRepository voteRepository;
        private readonly INemesysUserVoteRepository nemesysUserVoteRepository;


        public AllReportController(INemesysUserRepository userRepository, UserManager<NemesysUser> userManager, 
            IReportRepository reportRepository, IInvestigationRepository investigationRepository, IVoteRepository voteRepository,
            INemesysUserVoteRepository nemesysUserVoteRepository)
        {
            this.userManager = userManager;
            this.userRepository = userRepository;
            this.reportRepository = reportRepository;
            this.investigationRepository = investigationRepository;
            this.voteRepository = voteRepository;
            this.nemesysUserVoteRepository = nemesysUserVoteRepository;
        }
        // GET: AllReportController
        public ActionResult Index()
        {
            return View();
        }
      
        public IActionResult Reports()
        {
         
            return View(reportRepository.GetAllReports());
        }

        [HttpGet]
        public async Task<IActionResult> ShowInvestigation(int id)
        {
            var a = await investigationRepository.GetInvestigation(id);

            return View(a);
        }
        [Authorize(Roles = "reporter")]
        [HttpGet]
        public IActionResult UpVote(int id)
        {

           
            bool create=nemesysUserVoteRepository.Add(userManager.GetUserId(User), id);
            if(create==true)
            {
            voteRepository.UpVote(id);
            }
            return RedirectToAction("Reports", "AllReport");

        }
        [Authorize(Roles = "reporter")]
        [HttpGet]
        public IActionResult DownVote(int id)
        {
            bool create = nemesysUserVoteRepository.Add(userManager.GetUserId(User), id);
            if (create == true)
            {
                voteRepository.DownVote(id);
            }
            return RedirectToAction("Reports", "AllReport");
        }



        // GET: AllReportController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AllReportController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AllReportController/Create
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

        // GET: AllReportController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AllReportController/Edit/5
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

        // GET: AllReportController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AllReportController/Delete/5
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
