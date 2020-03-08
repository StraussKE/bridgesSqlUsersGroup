using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using bridgesSqlUsersGroup.Models;
using System.Security.Claims;


namespace EmoteLog.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signManager;

        public AccountController(UserManager<User> usrMgr, SignInManager<User> signMgr)
        {
            _userManager = usrMgr;
            _signManager = signMgr;
        }

        private Task<User> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);


        [AllowAnonymous] // Permit anyone to access registration
        public ViewResult Register() => View();

        [HttpPost] // Register account
        public async Task<IActionResult> Register(NewUserModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = model.UserName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    CreatedAccount = DateTime.Now
                };
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        [AllowAnonymous] // Don't need login cookie to log in
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken] // make sure it's not a stolen cookie
        public async Task<IActionResult> Login(LoginModel details, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByEmailAsync(details.Email);
                if (user != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result =
                    await _signManager.PasswordSignInAsync(user, details.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Profile");
                    }
                }
                ModelState.AddModelError(nameof(LoginModel.Email), "Invalid user or password");
            }
            return View(details);
        }

        [Authorize] // can only log out if you're logged in
        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous] // since access denied page is sent to replace pages that aren't authorized, anyone can see it
        public IActionResult AccessDenied()
        {
            return View();
        }

        [Authorize] // only logged in user can see their profile
        public async Task<IActionResult> Profile()
        {
            var user = await GetCurrentUserAsync();
            if (user != null)
            {
                return RedirectToAction("MemberProfile", "Member", user);
            }
            return RedirectToAction("Logout");
        }
    }
}