using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cookboard.Models;

namespace cookboard.Controllers
{
    public class EmentaSemanalController : Controller
    {
        private readonly cookBoardContext co;
        public EmentaSemanalController(cookBoardContext context)
        {
            //_context = context;
            co = context;
        }

        public ActionResult getEmentaSemanal()
        {
            var size = (from m in co.EmentaSemanal select m).ToList().Count;

            var ementa = (from m in co.EmentaSemanalReceita
                          join n in co.Receita on m.ReceitaId equals n.Id
                          where (m.EmentaSemanalId == size)
                          select n).ToList();

            List<Receita> lista = ementa.ToList<Receita>();

            return View(lista);
        }
    }
}
