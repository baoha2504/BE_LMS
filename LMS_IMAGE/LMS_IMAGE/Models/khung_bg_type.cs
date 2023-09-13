namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class khung_bg_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public khung_bg_type()
        {
            khung_bg = new HashSet<khung_bg>();
        }

        [Key]
        [StringLength(10)]
        public string code { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public string note { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<khung_bg> khung_bg { get; set; }
    }
}
