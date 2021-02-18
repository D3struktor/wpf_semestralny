namespace wpf_semestralny
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Performance")]
    public partial class Performance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Performance()
        {
            Performance_staff = new HashSet<Performance_staff>();
            Items = new HashSet<Items>();
        }

        [Key]
        public int Performance_id { get; set; }

        [Required]
        [StringLength(25)]
        public string Performance_name { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal Performace_visit_cost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Performance_staff> Performance_staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Items> Items { get; set; }
    }
}
