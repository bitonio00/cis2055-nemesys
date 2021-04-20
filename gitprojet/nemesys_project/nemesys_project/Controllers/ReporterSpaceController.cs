using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nemesys_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Controllers
{
    public class ReporterSpaceController : Controller
    {
        private readonly UserManager<NemesysUser> userManager;
        public ReporterSpaceController(UserManager<NemesysUser> userManager)
        {
            this.userManager = userManager;
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
            return View();
        }
        public IActionResult AddReport()
        {
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
