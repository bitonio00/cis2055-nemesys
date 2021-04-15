using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nemesys_project.Models;
using nemesys_project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemesys_project.Controllers
{
    public class AccountController : Controller
    {
        private IReporterRepository _reporterRepository;
        public AccountController(IReporterRepository reporterRepository)
        {
            _reporterRepository = reporterRepository;
        }
        
        public IActionResult Index()
        {
            return View(_reporterRepository.GetAllReporters());
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel usr)
        {

            if (ModelState.IsValid)
            {
                /* if(usr.Type==false)
                 {*/

                /* _reporterRepository.Add(new Reporter {
                     FirstName=usr.FirstName,
                     LastName=usr.LastName,
                     PhoneNumber=usr.PhoneNumber,
                     Email=usr.Email,
                     Password=usr.Password });*/
                _reporterRepository.Add(new Reporter(usr.FirstName, usr.LastName, usr.PhoneNumber, usr.Email, usr.Password));
              //  }

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Some Error Occured!");
            }
            return View(usr);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountController/Create
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

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
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

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
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
