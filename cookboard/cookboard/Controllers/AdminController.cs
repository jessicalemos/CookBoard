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
    public class AdminController
    {
        public AdminController()
        {
        }
        private readonly cookBoardContext co;
        public AdminController(cookBoardContext context)
        {

            co = context;
        }
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        public bool registerUser(Utilizador user)
        {
            user.Password = MyHelper.HashPassword(user.Password);
            co.user.Add(user);
            co.SaveChanges();
            return true;
        }

        [HttpPost]
        public IActionResult RegisterUser([Bind] Utilizador user)
        {
            if (ModelState.IsValid)
            {
                bool Status = registerUser(user);
                if (Status)
                {
                    ModelState.Clear();
                    TempData["Success"] = "Registration sucedeed. ";
                }
                else
                {
                    TempData["Fail"] = " Registration Failed.";
                }
            }
            return View();
        }
        public ActionResult RemoveUser(string username)
        {
            var user = (from u in co.Utilizador
                        where u.Username == username
                        select u).First();


            co.SaveChanges();

            return RedirectToAction("getUser");
        }
        public IActionResult getUsers()
        {
            List<Utilizador> u = co.Utilizador.ToList();
            return View(u);
        }
    }
}
