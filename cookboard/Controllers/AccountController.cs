using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using cookboard.Shared;
using cookboard.Models;

namespace cookboard.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private UserHandling userHandling;
        public AccountController(UserContext context)
        {
            //_context = context;
            userHandling = new UserHandling(context);
        }

        [HttpGet]
        public IActionResult RegistarUtilizador()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistarUtilizador([Bind] Utilizador user)
        {
            if (ModelState.IsValid)
            {
                bool RegistrationStatus = this.userHandling.registerUser(user);
                if (RegistrationStatus)
                {
                    ModelState.Clear();
                    TempData["Success"] = "Registration Successful!";
                }
                else
                {
                    TempData["Fail"] = "This Username already exists. Registration Failed.";
                }
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind] Utilizador utilizador)
        {
            ModelState.Remove("username");
            ModelState.Remove("password");

            if (ModelState.IsValid)
            {
                var LoginStatus = this.userHandling.validateUser(utilizador);
                if (LoginStatus)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, utilizador.username)
                    };
                    ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["UserLoginFailed"] = "Login Failed.Please enter correct credentials";
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("index", "Home");
        }
    }
}