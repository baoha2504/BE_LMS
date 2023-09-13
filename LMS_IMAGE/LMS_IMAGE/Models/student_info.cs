namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class student_info
    {
        [Key]
        public Guid student_id { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(20)]
        public string first_name { get; set; }

        [StringLength(20)]
        public string last_name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        [StringLength(10)]
        public string sex { get; set; }

        [StringLength(20)]
        public string class_year_id { get; set; }

        [StringLength(50)]
        public string address_tinh { get; set; }

        [StringLength(50)]
        public string address_huyen { get; set; }

        [StringLength(50)]
        public string address_xa { get; set; }

        [StringLength(200)]
        public string address_chitiet { get; set; }

        [StringLength(15)]
        public string phone { get; set; }

        [StringLength(255)]
        public string image_office { get; set; }

        [StringLength(50)]
        public string ten_cha { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday_cha { get; set; }

        [StringLength(255)]
        public string job_cha { get; set; }

        [StringLength(15)]
        public string phone_cha { get; set; }

        [StringLength(50)]
        public string ten_me { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday_me { get; set; }

        [StringLength(255)]
        public string job_me { get; set; }

        [StringLength(15)]
        public string phone_me { get; set; }

        [StringLength(100)]
        public string que_quan { get; set; }

        [StringLength(10)]
        public string state_code { get; set; }

        public Guid? create_user { get; set; }

        public DateTime? create_time { get; set; }

        public Guid? modify_user { get; set; }

        public DateTime? modify_time { get; set; }

        public virtual class_year class_year { get; set; }

        public virtual student_state student_state { get; set; }

        public virtual student_login student_login { get; set; }
    }
}
