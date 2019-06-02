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
    public class ProfessorController : Controller
    {
        private readonly cookBoardContext co;
        public ProfessorController(cookBoardContext context)
        {
            //_context = context;
            co = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult editarP()
        {
            return View();
        }

        public IActionResult getUsers()
        {
            List<Utilizador> u = co.Utilizador.ToList();
            return View(u);
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

            for (int i = 0; i < num; i++)
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

        public ActionResult getReceitas()
        {
            var receitas = (from m in co.Receita select m);

            List<Receita> lista = receitas.ToList<Receita>();

            return View(lista);
        }
    }
}