namespace wpf_semestralny
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employers()
        {
            Performance_staff = new HashSet<Performance_staff>();
        }

        [Key]
        public int Employer_id { get; set; }

        [Required]
        [StringLength(25)]
        public string Employer_name { get; set; }

        [StringLength(25)]
        public string Employer_last_name { get; set; }

        [Column(TypeName = "date")]
        public DateTime Employment_date { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Performance_staff> Performance_staff { get; set; }
    }
}
