namespace cookBoard
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Receita_ReceitaAuxiliar
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceitaId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(45)]
        public string ReceitaAuxiliarNome { get; set; }

        public int Passo { get; set; }

        public virtual Receita Receita { get; set; }

        public virtual ReceitaAuxiliar ReceitaAuxiliar { get; set; }
    }
}
