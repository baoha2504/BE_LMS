namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class student_state
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public student_state()
        {
            student_info = new HashSet<student_info>();
        }

        [Key]
        [StringLength(10)]
        public string code { get; set; }

        [StringLength(50)]
        public string state_name { get; set; }

        public string note { get; set; }

        public Guid? create_user { get; set; }

        public DateTime? create_time { get; set; }

        public Guid? modify_user { get; set; }

        public DateTime? modify_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student_info> student_info { get; set; }
    }
}
