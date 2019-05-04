namespace cookBoard
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receita")]
    public partial class Receita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receita()
        {
            EmentaSemanal_Receita = new HashSet<EmentaSemanal_Receita>();
            Receita_Ingrediente = new HashSet<Receita_Ingrediente>();
            Receita_ReceitaAuxiliar = new HashSet<Receita_ReceitaAuxiliar>();
            Utilizador_Receita = new HashSet<Utilizador_Receita>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Nome { get; set; }

        public int Porcao { get; set; }

        public int Avaliacao { get; set; }

        [Required]
        [StringLength(256)]
        public string Imagem { get; set; }

        [Required]
        [StringLength(45)]
        public string Comentarios { get; set; }

        [Required]
        [StringLength(256)]
        public string InfoNutricional { get; set; }

        [Required]
        [StringLength(45)]
        public string Dificuldade { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Descricao { get; set; }

        [Required]
        [StringLength(45)]
        public string TempoConfecao { get; set; }

        [Required]
        [StringLength(45)]
        public string UtilizadorUsername { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmentaSemanal_Receita> EmentaSemanal_Receita { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receita_Ingrediente> Receita_Ingrediente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receita_ReceitaAuxiliar> Receita_ReceitaAuxiliar { get; set; }

        public virtual Utilizador Utilizador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilizador_Receita> Utilizador_Receita { get; set; }
    }
}
