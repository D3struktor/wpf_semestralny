//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConnectDataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

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
