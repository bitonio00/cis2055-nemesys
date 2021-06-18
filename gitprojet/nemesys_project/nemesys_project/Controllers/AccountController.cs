using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nemesys_project.Models;
using nemesys_project.ViewModel;
using NETCore.MailKit.Core;
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
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IEmailService emailService;
        private readonly INemesysUserRepository userRepository;

        public AccountController(UserManager<NemesysUser>userManager,
            SignInManager<NemesysUser>signInManager, RoleManager<IdentityRole> roleManager,
            IEmailService emailService, INemesysUserRepository userRepository)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.emailService = emailService;
            this.userRepository = userRepository;
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
                string roleName="";
                var user = new NemesysUser { 
                    UserName = usr.Email,
                    Email = usr.Email,
                    PhoneNumber = usr.PhoneNumber,
                    FirstName = usr.FirstName,
                    LastName = usr.LastName };
                if(usr.IsReporter == true && usr.IsInvestigator==false)
                {
                    roleName = "reporter";
                }
                else if (usr.IsReporter == false && usr.IsInvestigator == true)
                {
                    roleName = "investigator";
                }
                var result= await userManager.CreateAsync(user, usr.Password);
                if(result.Succeeded)
                {
                    var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    var link = Url.Action(nameof(VerifyEmail),"Account",new {userId=user.Id,code,roleName },Request.Scheme,Request.Host.ToString());
                    await emailService.SendAsync(user.Email,"email verify",$"<a href=\"{link}\">Verify Email<a>",true);
                    return RedirectToAction("EmailVerification");

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
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AccountParameter()
        {
            var a =await userManager.GetUserAsync(User);
            return View(a);
        }
        [Authorize]
        [HttpPost]
        public IActionResult AccountParameter(NemesysUser user)
        {
            userRepository.Update(user);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult>ForgotPassword(ForgotPasswordViewModel model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);
            if(user!=null)
            {
                if(user.EmailConfirmed==true)
                    {
                     var code = await userManager.GeneratePasswordResetTokenAsync(user);
                     var link = Url.Action(nameof(ResetPassword), "Account", new { userId = user.Id, code}, Request.Scheme, Request.Host.ToString());
                     await emailService.SendAsync(user.Email, "reset password", $"<a href=\"{link}\">Reset Password<a>", true);
                     }
                   else if(user.EmailConfirmed == false)
                     {
                     return View();
                     }
            }
            else
            {
                return RedirectToAction("Register", "Account");
            }
            
            return View();
        }
        [Authorize]
        public IActionResult Parameters()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
                   return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            
            var user = await userManager.GetUserAsync(User);
            var changePasswordResult = await userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (!changePasswordResult.Succeeded)
            {
                foreach (var error in changePasswordResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View();
            }
            await signInManager.RefreshSignInAsync(user);
            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>ResetPassword(string userId,string code,ResetPasswordViewModel model)
        {
            
            var user = await userManager.FindByIdAsync(userId);
            var resetPassword=await userManager.ResetPasswordAsync(user,code,model.Password);
            if (resetPassword.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        public  IActionResult ResetPassword()
        {
           
            return View();
        }
        public async Task<IActionResult>VerifyEmail(string userId,string code,string roleName)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null) return BadRequest();
            var result = await userManager.ConfirmEmailAsync(user, code);
            if(result.Succeeded)
            {
                var role= await roleManager.FindByNameAsync(roleName);
                IdentityResult result2 = await userManager.AddToRoleAsync(user, role.Name);
                return View();
            }
            return BadRequest();
            
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
        public IActionResult EmailVerification()
        {
            return View();
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
