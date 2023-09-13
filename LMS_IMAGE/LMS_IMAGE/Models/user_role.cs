namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_role
    {
        [Key]
        [Column(Order = 0)]
        public Guid user_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string role { get; set; }

        public Guid? create_user { get; set; }

        public DateTime? create_time { get; set; }

        public Guid? modify_user { get; set; }

        public DateTime? modify_time { get; set; }

        public virtual role role1 { get; set; }

        public virtual user_info user_info { get; set; }
    }
}
