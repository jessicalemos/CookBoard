namespace cookBoard
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Local")]
    public partial class Local
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Local()
        {
            Ingredientes = new HashSet<Ingrediente>();
            Supermercadoes = new HashSet<Supermercado>();
        }

        [Required]
        [StringLength(45)]
        public string Rua { get; set; }

        [Required]
        [StringLength(45)]
        public string CodigoPostal { get; set; }

        [Required]
        [StringLength(45)]
        public string Localidade { get; set; }

        public int Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ingrediente> Ingredientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supermercado> Supermercadoes { get; set; }
    }
}
