namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class calendar_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public calendar_type()
        {
            lich_dung_phong = new HashSet<lich_dung_phong>();
        }

        [Key]
        [StringLength(10)]
        public string code { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public string note { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lich_dung_phong> lich_dung_phong { get; set; }
    }
}
