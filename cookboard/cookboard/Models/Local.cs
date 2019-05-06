using System;
using System.Collections.Generic;

namespace cookboard.Models
{
    public partial class Local
    {
        public Local()
        {
            IngredienteLocal = new HashSet<IngredienteLocal>();
            SupermercadoLocal = new HashSet<SupermercadoLocal>();
        }

        public string Rua { get; set; }
        public string CodigoPostal { get; set; }
        public string Localidade { get; set; }
        public int Id { get; set; }

        public virtual ICollection<IngredienteLocal> IngredienteLocal { get; set; }
        public virtual ICollection<SupermercadoLocal> SupermercadoLocal { get; set; }
    }
}
