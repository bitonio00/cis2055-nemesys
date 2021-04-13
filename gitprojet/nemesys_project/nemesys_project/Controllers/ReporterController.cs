using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using nemesys_project.Models;
using nemesys_project.Context;
using Microsoft.EntityFrameworkCore;


namespace nemesys_project.Controllers
{
    public class ReporterController : Controller
    {

        private NemesysDbContext db = new NemesysDbContext(new DbContextOptionsBuilder<NemesysDbContext>()
    .UseSqlServer(@"Data Source=LAPTOP-5E9IAOCC\MSSQLSERVER01;Initial Catalog=nemesysDb;Integrated Security=True;Pooling=False")
    .Options);
        public IActionResult Index()
        {
            return View(db.Reporters.ToList());
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Reporter usr)
        {
          
            if (ModelState.IsValid)
            {
                db.Reporters.Add(usr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Some Error Occured!");
            }
            return View(usr);
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Reporter usr)
        {
           // db.Reporters.
           if (ModelState.IsValid)
            {
                var obj = db.Reporters.Where(u => u.Email.Equals(usr.Email) && usr.Password.Equals(usr.Password)).FirstOrDefault();
                if (obj!=null)
                {
                  
                }
            }
            else
            {
                ModelState.AddModelError("", "Some Error Occured!");
            }
            return View(usr);
        }
    }
}
