using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cookboard.Models;

namespace cookboard.Controllers
{
    public class LocalController : Controller

    {
        private readonly cookBoardContext co;
        public LocalController(cookBoardContext context)
        {
            
            co = context;
        }

        
        public ActionResult getLocais()
        {
            var locais = (from m in co.Local select m);

            List<Local> lista = locais.ToList<Local>();

            return View(lista);
        }
        
    }
}
