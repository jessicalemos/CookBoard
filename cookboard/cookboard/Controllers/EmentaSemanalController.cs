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

            List<Receita> receita = (from m in co.EmentaSemanalReceita
                          join n in co.Receita on m.ReceitaId equals n.Id
                          where (m.EmentaSemanalId == size)
                          select n).ToList();
            
            List<string> dias = (from m in co.EmentaSemanalReceita
                          where (m.EmentaSemanalId == size)
                          select m.Dia).ToList();

            var num = dias.Count;

            List<EmentaViewModel> final = new List<EmentaViewModel>();

            for (int i=0; i<num; i++)
            {
                Receita r = receita[i];
                string d = dias[i];

                final.Add(new EmentaViewModel(d, r));
            }

            return View(final);
        }

        public ActionResult getIngredientes()
        {
            var size = (from m in co.EmentaSemanal select m).ToList().Count;

            var ing = (from m in co.EmentaSemanalReceita
                          join n in co.Receita on m.ReceitaId equals n.Id
                          join ri in co.ReceitaIngrediente on n.Id equals ri.ReceitaId
                          join i in co.Ingrediente on ri.IngredienteId equals i.Id
                          where (m.EmentaSemanalId == size)
                          select i).ToHashSet();

            return View(ing);
        }
    }
}
