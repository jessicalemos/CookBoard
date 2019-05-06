using System;
using System.Collections.Generic;

namespace cookboard.Models
{
    public partial class Ingrediente
    {
        public Ingrediente()
        {
            IngredienteLocal = new HashSet<IngredienteLocal>();
            ReceitaIngrediente = new HashSet<ReceitaIngrediente>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<IngredienteLocal> IngredienteLocal { get; set; }
        public virtual ICollection<ReceitaIngrediente> ReceitaIngrediente { get; set; }
    }
}
