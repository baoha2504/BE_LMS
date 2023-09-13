namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class phong_hoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public phong_hoc()
        {
            lich_dung_phong = new HashSet<lich_dung_phong>();
        }

        [Key]
        public int phong_id { get; set; }

        [StringLength(50)]
        public string ten_phong { get; set; }

        public Guid? office_id { get; set; }

        [StringLength(10)]
        public string loai_phong { get; set; }

        public int? so_ghe { get; set; }

        [StringLength(10)]
        public string state { get; set; }

        [StringLength(100)]
        public string address_chitiet { get; set; }

        public string note { get; set; }

        public Guid? create_user { get; set; }

        public DateTime? create_time { get; set; }

        public Guid? modify_user { get; set; }

        public DateTime? modify_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lich_dung_phong> lich_dung_phong { get; set; }

        public virtual loai_phong loai_phong1 { get; set; }

        public virtual office office { get; set; }

        public virtual trang_thai_phong trang_thai_phong { get; set; }
    }
}
