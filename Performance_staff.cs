namespace wpf_semestralny
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Performance_staff
    {
        [Key]
        public int Performance_staff_id { get; set; }

        public int Performance_id { get; set; }

        public int Employer_id { get; set; }

        public int Employer_type_of_work_id { get; set; }

        public virtual Employers Employers { get; set; }

        public virtual Performance Performance { get; set; }
    }
}
