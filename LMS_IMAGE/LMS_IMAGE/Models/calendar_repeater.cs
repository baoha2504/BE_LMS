namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class calendar_repeater
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public calendar_repeater()
        {
            lich_dung_phong = new HashSet<lich_dung_phong>();
        }

        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? start_set_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? stop_set_date { get; set; }

        public bool? repeat_2 { get; set; }

        public bool? repeat_3 { get; set; }

        public bool? repeat_4 { get; set; }

        public bool? repeat_5 { get; set; }

        public bool? repeat_6 { get; set; }

        public bool? repeat_7 { get; set; }

        public bool? repeat_cn { get; set; }

        public Guid? create_user { get; set; }

        public DateTime? create_time { get; set; }

        public Guid? modify_user { get; set; }

        public DateTime? modify_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lich_dung_phong> lich_dung_phong { get; set; }
    }
}
