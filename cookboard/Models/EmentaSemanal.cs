namespace cookboard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmentaSemanal")]
    public partial class EmentaSemanal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmentaSemanal()
        {
            EmentaSemanal_Receita = new HashSet<EmentaSemanal_Receita>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string UtilizadorUsername { get; set; }

        public DateTime DataLancamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmentaSemanal_Receita> EmentaSemanal_Receita { get; set; }

        public virtual Utilizador Utilizador { get; set; }
    }
}
