namespace cookBoard
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Receita_Ingrediente
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceitaId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IngredienteId { get; set; }

        [Required]
        [StringLength(256)]
        public string Quantidade { get; set; }

        public virtual Ingrediente Ingrediente { get; set; }

        public virtual Receita Receita { get; set; }
    }
}
