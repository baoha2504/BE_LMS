namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user_info()
        {
            bai_giang = new HashSet<bai_giang>();
            ct_dao_tao = new HashSet<ct_dao_tao>();
            lich_dung_phong = new HashSet<lich_dung_phong>();
            lich_dung_phong1 = new HashSet<lich_dung_phong>();
            lich_dung_phong2 = new HashSet<lich_dung_phong>();
            mon_hoc = new HashSet<mon_hoc>();
            user_role = new HashSet<user_role>();
        }

        [Key]
        public Guid user_id { get; set; }

        [StringLength(20)]
        public string first_name { get; set; }

        [StringLength(20)]
        public string last_name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        [StringLength(10)]
        public string sex { get; set; }

        [Required]
        [StringLength(12)]
        public string cccd { get; set; }

        [StringLength(100)]
        public string chuc_vu { get; set; }

        [StringLength(100)]
        public string to_chuyen_mon { get; set; }

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

        [StringLength(200)]
        public string que_quan { get; set; }

        public string note { get; set; }

        [StringLength(10)]
        public string state { get; set; }

        public Guid? create_user { get; set; }

        public DateTime? create_time { get; set; }

        public Guid? modify_user { get; set; }

        public DateTime? modify_time { get; set; }

        public virtual account_state account_state { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bai_giang> bai_giang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ct_dao_tao> ct_dao_tao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lich_dung_phong> lich_dung_phong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lich_dung_phong> lich_dung_phong1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lich_dung_phong> lich_dung_phong2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mon_hoc> mon_hoc { get; set; }

        public virtual user_login user_login { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_role> user_role { get; set; }
    }
}
