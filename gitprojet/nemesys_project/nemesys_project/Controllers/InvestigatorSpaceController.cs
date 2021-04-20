using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Controllers
{
    public class InvestigatorSpaceController : Controller
    {
         
        // GET: InvestigatorSpace
        public ActionResult Index()
        {
            return View();
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
        [Authorize(Roles="investigator")]
        public IActionResult ManageInvestigations()
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
