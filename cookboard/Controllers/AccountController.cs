using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using cookboard.Models;
using cookboard.Shared;
using System.Security.Cryptography;

namespace cookboard.Controllers
{
    public class AccountController : Controller
    {
        private Model db = new Model();

        public ActionResult Index(string utilizador)
        {
            //  ViewData["User_Name"] = "Bem vindo" + user;
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (ModelState.IsValid)
            {
                var utilizadors = (from m in db.Utilizadors where (m.Username == username) select m);

                if (utilizadors.ToList().Count > 0)
                {
                    Utilizador utilizador = utilizadors.ToList().ElementAt<Utilizador>(0);
                    using (MD5 md5Hash = MD5.Create())
                    {
                        if (MyHelper.VerifyMd5Hash(md5Hash, password, utilizador.Password))
                        {
                            //    string user = utilizador.Username.ToString();
                            //    HttpCookie cookie = MyHelpers.CreateAuthorizeTicket(utilizador.Id.ToString(), utilizador.Tipo);
                            //    Response.Cookies.Add(cookie);
                            if (utilizador.Tipo.Equals("Professor"))
                            {
                                //     ViewData["User_Name"] = "Bem vindo" + utilizador.Username;
                                return RedirectToAction("Index", "Professor");
                            }
                            else
                            {
                                //   var t = ViewData["User_Name"] = "Bem vindo" + utilizador.Username;
                                return RedirectToAction("Index", "Aluno");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("password", "Password incorreta!");
                            return View();
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                    return View();
                }
            }
            return View();
        }

        public ActionResult LogOut()
        {
            //     FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Registar(Utilizador utilizador)
        {
            if (ModelState.IsValid)
            {
                using (Model db = new Model())
                {
                    db.Utilizadors.Add(utilizador);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = utilizador.Nome + " registada com sucesso.";
            }
            return View();
        }

        public ActionResult sucessAction()
        {
            ViewBag.title = "Sucesso";
            ViewBag.mensagem = "Login realizado com sucesso";
            ViewBag.controller = "Home";
            return View("_sucessView");
        }
    }
}