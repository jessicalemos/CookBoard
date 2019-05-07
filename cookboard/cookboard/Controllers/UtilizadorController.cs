using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cookboard.Models;
using cookboard._Shared;
using System.Security.Cryptography;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;


namespace cookboard.Controllers
{
    [Route("[controller]/[action]")]
    public class UtilizadorController : Controller
    {
        private readonly cookBoardContext co;
        public UtilizadorController(cookBoardContext context)
        {
            //_context = context;
            co = context;
        }

        // GET: /<controller>/
        public IActionResult getUsers()
        {
            List<Utilizador> u = co.Utilizador.ToList();
            return View(u);
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        public bool validateUser(Utilizador user)
        {
            user.Password = MyHelper.HashPassword(user.Password);
            var returnedUser = co.Utilizador.Where(b => b.Username == user.Username && b.Password == user.Password).FirstOrDefault();

            if (returnedUser == null)
            {
                return false;
            }
            return true;
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
                    return RedirectToAction("getUsers", "UserView");
                }
                else
                {
                    TempData["UserLoginFailed"] = "Login Failed.Please enter correct credentials";
                }
            }
            return View();
        }

        public IActionResult getHistorico()
        {
            string username = User.Identity.Name;
            var receitas = (from m in co.UtilizadorReceita
                            join n in co.Receita on m.ReceitaId equals n.Id
                            where (m.UtilizadorUsername == username)
                            select n).ToList();

            return View(receitas);
        }

        public IActionResult getFavoritos()
        {
            string username = User.Identity.Name;
            var receitas = (from m in co.UtilizadorReceita
                            join n in co.Receita on m.ReceitaId equals n.Id
                            where (m.UtilizadorUsername == username && m.Favorito == 1)
                            select n).ToList();

            return View(receitas);
        }

        public ActionResult consultar(int idReceita)
        {
            var receita = (from m in co.Receita where (m.Id == idReceita) select m).ToList();

            return View(receita);
        }

    }
}