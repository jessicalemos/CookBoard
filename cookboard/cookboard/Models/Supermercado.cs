using System;
using System.Collections.Generic;

namespace cookboard.Models
{
    public partial class Supermercado
    {
        public Supermercado()
        {
            SupermercadoLocal = new HashSet<SupermercadoLocal>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<SupermercadoLocal> SupermercadoLocal { get; set; }
    }
}
