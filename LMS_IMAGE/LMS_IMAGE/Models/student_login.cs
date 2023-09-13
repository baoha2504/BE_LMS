namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class student_login
    {
        public Guid id { get; set; }

        [Required]
        [StringLength(10)]
        public string student_code { get; set; }

        public Guid? office_id { get; set; }

        [StringLength(100)]
        public string password { get; set; }

        [StringLength(50)]
        public string display_name { get; set; }

        public string reset_token { get; set; }

        public DateTime? reset_time { get; set; }

        [StringLength(255)]
        public string avatar { get; set; }

        public virtual office office { get; set; }

        public virtual student_info student_info { get; set; }
    }
}
