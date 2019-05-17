using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cookboard.Models;

namespace cookboard.Controllers
{
    public class LocalIngredienteController : Controller
    {
        private readonly cookBoardContext co;
        public LocalIngredienteController(cookBoardContext context)
        {
            //_context = context;
            co = context;
        }

        public ActionResult getLocalizacao()
        {
            var receitas = (from m in co.Receita select m);

            List<Receita> lista = receitas.ToList<Receita>();

            return View();
        }
    }
}