using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cookboard.Models;

namespace cookboard.Controllers
{
    public class ReceitasController : Controller
    {
        private readonly cookBoardContext co;
        public ReceitasController(cookBoardContext context)
        {
            //_context = context;
            co = context;
        }

        public ActionResult getReceitas()
        {
            var receitas = (from m in co.Receita select m);

            List<Receita> lista = receitas.ToList<Receita>();

            return View(lista);
        }

        public ActionResult getReceita(int idReceita)
        {

            List<Ingrediente> ing = (from ri in co.ReceitaIngrediente 
                                   join i in co.Ingrediente on ri.IngredienteId equals i.Id
                                   where (ri.ReceitaId == idReceita)
                                   select i).ToList();

            List<string> quant = (from ri in co.ReceitaIngrediente
                                  where (ri.ReceitaId == idReceita)
                                  select ri.Quantidade).ToList();

            List<IngredienteViewModel> final = new List<IngredienteViewModel>();
            int num = ing.Count();

            for (int i = 0; i < num; i++)
            {
                Ingrediente ingrediente = ing[i];
                string quantidade = quant[i];

                final.Add(new IngredienteViewModel(quantidade, ingrediente));
            }

            Receita rec = (from n in co.Receita
                       where (n.Id == idReceita)
                       select n).Single();
          
            return View(new ReceitaViewModel(rec, final));
        }

        public ActionResult getPassos(int idReceita)
        {
            Receita rec = (from n in co.Receita
                           where (n.Id == idReceita)
                           select n).Single();

            List<PassosViewModel> passos = new List<PassosViewModel>();
            string[] words = rec.Descricao.Split('.');
            int i = 0;
            foreach(var word in words)
            {
                passos.Add(new PassosViewModel(i, word));
                i++;
            }

            return View(passos);
        }
    }
}