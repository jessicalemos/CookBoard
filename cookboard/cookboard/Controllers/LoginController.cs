using System;
using cookboard._Shared;
using cookboard.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace cookboard.Controllers
{
    public class LoginController : Controller
    {
        private readonly cookBoardContext co;
        public LoginController(cookBoardContext context)
        {
            //_context = context;
            co = context;
        }
       
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        public bool validateUser(Utilizador user)
        {
            user.Password = MyHelper.HashPassword(user.Password);
            var result = co.Utilizador.FirstOrDefault(b => b.Username == user.Username && b.Password == user.Password);

            if (result != null)
            {
                return true;
            }
            return false;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind] Utilizador user)
        {
            ModelState.Remove("nome");
            ModelState.Remove("email");

            if (ModelState.IsValid)
            {
                var LoginStatus = validateUser(user);
                if (LoginStatus)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Username)
                    };
                    ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("getUsers", "userView");
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