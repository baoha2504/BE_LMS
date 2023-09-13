namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_login
    {
        public Guid id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public Guid? office_id { get; set; }

        [StringLength(50)]
        public string display_name { get; set; }

        [StringLength(100)]
        public string password { get; set; }

        public string reset_token { get; set; }

        public DateTime? reset_time { get; set; }

        public string avatar { get; set; }

        public virtual office office { get; set; }

        public virtual user_info user_info { get; set; }
    }
}
