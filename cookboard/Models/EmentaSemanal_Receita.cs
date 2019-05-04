namespace Infra.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmentaSemanal_Receita
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmentaSemanalId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceitaId { get; set; }

        [Required]
        [StringLength(45)]
        public string Dia { get; set; }

        public virtual EmentaSemanal EmentaSemanal { get; set; }

        public virtual Receita Receita { get; set; }
    }
}
