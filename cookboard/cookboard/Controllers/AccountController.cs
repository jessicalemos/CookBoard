using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using cookboard._Shared;
using cookboard.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace cookboard.Controllers
{
    public class AccountController : Controller
    {
        private readonly cookBoardContext co;
        public AccountController(cookBoardContext context)
        {
            //_context = context;
            co = context;
        }

        public bool ValidateUser(Utilizador user)
        {
            user.Password = MyHelper.HashPassword(user.Password);
            var returnedUser = co.Utilizador.Where(b => b.Username == user.Username && b.Password == user.Password).FirstOrDefault();

            if (returnedUser == null)
            {
                return false;
            }
            return true;
        }

        [HttpGet]
        public IActionResult UtilizadorLogin()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UtilizadorLogin([Bind] Utilizador utilizador)
        {
            ModelState.Remove("Email");
            ModelState.Remove("Nome");
            ModelState.Remove("DataNascimento");
            ModelState.Remove("Tipo");


            if (ModelState.IsValid)
            {
                var LoginStatus = ValidateUser(utilizador);
                if (LoginStatus)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, utilizador.Username)
                    };
                    ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("getUsers", "Utilizador");
                }
                else
                {
                    TempData["UserLoginFailed"] = "Login Failed.Please enter correct credentials";
                }
            }
            return View();
        }
    }
}
