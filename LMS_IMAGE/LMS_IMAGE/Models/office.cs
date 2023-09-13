namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("office")]
    public partial class office
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public office()
        {
            bai_giang = new HashSet<bai_giang>();
            class_year = new HashSet<class_year>();
            phong_hoc = new HashSet<phong_hoc>();
            student_login = new HashSet<student_login>();
            user_login = new HashSet<user_login>();
        }

        public Guid id { get; set; }

        [StringLength(100)]
        public string office_name { get; set; }

        [StringLength(50)]
        public string address_tinh { get; set; }

        [StringLength(50)]
        public string address_huyen { get; set; }

        [StringLength(50)]
        public string address_xa { get; set; }

        [StringLength(200)]
        public string address_chitiet { get; set; }

        public string note { get; set; }

        public Guid? create_user { get; set; }

        public DateTime? create_time { get; set; }

        public Guid? modify_user { get; set; }

        public DateTime? modify_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bai_giang> bai_giang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<class_year> class_year { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phong_hoc> phong_hoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student_login> student_login { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_login> user_login { get; set; }
    }
}
