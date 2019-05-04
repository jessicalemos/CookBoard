namespace cookboard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Utilizador_Receita
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(45)]
        public string UtilizadorUsername { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceitaId { get; set; }

        public byte Favorito { get; set; }

        public virtual Receita Receita { get; set; }

        public virtual Utilizador Utilizador { get; set; }
    }
}
