namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class khung_bg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public khung_bg()
        {
            khung_bg1 = new HashSet<khung_bg>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string kbg_type { get; set; }

        [StringLength(10)]
        public string type { get; set; }

        [StringLength(10)]
        public string mh_id { get; set; }

        [StringLength(50)]
        public string short_title { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        public int? parent_id { get; set; }

        public int? so_tiet { get; set; }

        public string note { get; set; }

        public Guid? create_user { get; set; }

        public DateTime? create_time { get; set; }

        public Guid? modify_user { get; set; }

        public DateTime? modify_time { get; set; }

        public int? bg_id { get; set; }

        public virtual bai_giang bai_giang { get; set; }

        public virtual mon_hoc mon_hoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<khung_bg> khung_bg1 { get; set; }

        public virtual khung_bg khung_bg2 { get; set; }

        public virtual khung_bg_type khung_bg_type { get; set; }
    }
}
