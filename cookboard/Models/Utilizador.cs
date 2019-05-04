namespace cookBoard
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Utilizador")]
    public partial class Utilizador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Utilizador()
        {
            EmentaSemanals = new HashSet<EmentaSemanal>();
            Receitas = new HashSet<Receita>();
            Utilizador_Receita = new HashSet<Utilizador_Receita>();
        }

        [Key]
        [StringLength(45)]
        public string Username { get; set; }

        [Required]
        [StringLength(45)]
        public string Password { get; set; }

        [Required]
        [StringLength(45)]
        public string Email { get; set; }

        [Required]
        [StringLength(45)]
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(45)]
        public string Tipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmentaSemanal> EmentaSemanals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receita> Receitas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilizador_Receita> Utilizador_Receita { get; set; }
    }
}
