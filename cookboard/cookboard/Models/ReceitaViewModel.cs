using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cookboard.Models
{
    public class ReceitaViewModel
    {
        public ReceitaViewModel(Receita receita, List<Ingrediente> ingredientes)
        {
            Receita = receita;
            Ingredientes = ingredientes;
        }

        public Receita Receita { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
    }
}
