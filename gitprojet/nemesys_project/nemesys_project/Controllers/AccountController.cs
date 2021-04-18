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
    public class AccountController : Controller
    {
        private readonly UserManager<NemesysUser> userManager;
        private readonly SignInManager<NemesysUser> signInManager;

        public AccountController(UserManager<NemesysUser>userManager,
            SignInManager<NemesysUser>signInManager )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        
        public IActionResult Index()
        {
            return View();
        }
       
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel usr)
        {

            if (ModelState.IsValid)
            {
                var user = new NemesysUser { 
                    UserName = usr.Email,
                    Email = usr.Email,
                    PhoneNumber = usr.PhoneNumber,
                    FirstName = usr.FirstName,
                    LastName = usr.LastName };

               var result= await userManager.CreateAsync(user, usr.Password);
                if(result.Succeeded)
                {
                   await signInManager.SignInAsync(user, isPersistent: false);
                   return RedirectToAction("Index","Home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                
            }
            else
            {
                ModelState.AddModelError("", "Some Error Occured!");
            }
            return View(usr);
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel usr)
        {
            

            if (ModelState.IsValid)
            {

                var result = await signInManager.PasswordSignInAsync(usr.Email,usr.Password,usr.RemeberMe,false );
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("","Invalid Login" );
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
