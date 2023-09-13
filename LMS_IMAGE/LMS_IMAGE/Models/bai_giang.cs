namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bai_giang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bai_giang()
        {
            khung_bg = new HashSet<khung_bg>();
        }

        public int id { get; set; }

        public Guid? office_id { get; set; }

        public Guid? giaovien_id { get; set; }

        public string giaovien_2 { get; set; }

        [StringLength(10)]
        public string mh_id { get; set; }

        public string content { get; set; }

        public int? view_number { get; set; }

        public bool? state { get; set; }

        public Guid? approver_id { get; set; }

        public virtual user_info user_info { get; set; }

        public virtual mon_hoc mon_hoc { get; set; }

        public virtual office office { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<khung_bg> khung_bg { get; set; }
    }
}
