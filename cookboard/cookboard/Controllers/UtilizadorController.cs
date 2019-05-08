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