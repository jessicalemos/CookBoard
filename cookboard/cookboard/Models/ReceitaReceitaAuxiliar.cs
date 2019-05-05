using System;
using System.Collections.Generic;

namespace cookboard.Models
{
    public partial class ReceitaReceitaAuxiliar
    {
        public int ReceitaId { get; set; }
        public string ReceitaAuxiliarNome { get; set; }
        public int Passo { get; set; }

        public virtual Receita Receita { get; set; }
        public virtual ReceitaAuxiliar ReceitaAuxiliarNomeNavigation { get; set; }
    }
}
