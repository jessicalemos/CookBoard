namespace cookBoard
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceitaAuxiliar")]
    public partial class ReceitaAuxiliar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReceitaAuxiliar()
        {
            Receita_ReceitaAuxiliar = new HashSet<Receita_ReceitaAuxiliar>();
        }

        [Key]
        [StringLength(45)]
        public string Nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receita_ReceitaAuxiliar> Receita_ReceitaAuxiliar { get; set; }
    }
}
