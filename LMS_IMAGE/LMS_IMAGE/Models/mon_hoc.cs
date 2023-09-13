namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mon_hoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mon_hoc()
        {
            bai_giang = new HashSet<bai_giang>();
            khung_bg = new HashSet<khung_bg>();
            ct_dao_tao = new HashSet<ct_dao_tao>();
        }

        [Key]
        [StringLength(10)]
        public string code { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(10)]
        public string grade { get; set; }

        public int? so_tiet { get; set; }

        public string note { get; set; }

        [StringLength(10)]
        public string state { get; set; }

        public Guid? approver_id { get; set; }

        public Guid? create_user { get; set; }

        public DateTime? create_time { get; set; }

        public Guid? modify_user { get; set; }

        public DateTime? modify_time { get; set; }

        [StringLength(10)]
        public string group { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bai_giang> bai_giang { get; set; }

        public virtual khoi_lop khoi_lop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<khung_bg> khung_bg { get; set; }

        public virtual mh_group mh_group { get; set; }

        public virtual mh_state mh_state { get; set; }

        public virtual user_info user_info { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ct_dao_tao> ct_dao_tao { get; set; }
    }
}
