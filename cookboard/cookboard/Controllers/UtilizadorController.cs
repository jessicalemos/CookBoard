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
using Microsoft.EntityFrameworkCore;

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
        // GET: Utilizador/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await co.Utilizador.FindAsync(id);
            if (user== null)
            {
                return NotFound();
            }
            return View(user);
        }

       
        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string username, [Bind("Nome,Email,Password")] Utilizador user)
        {
            if (username != user.Username)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    co.Update(user);
                    await co.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    /*
                    if (!MovieExists(user.Username))
                    {
                        return NotFound();
                    }
                    else
                    {
                    */
                        
                        throw;
                    //}
                }
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}