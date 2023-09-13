namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ct_dao_tao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ct_dao_tao()
        {
            mon_hoc = new HashSet<mon_hoc>();
        }

        [Key]
        [StringLength(10)]
        public string code { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? start_time { get; set; }

        public double? period { get; set; }

        [StringLength(10)]
        public string period_unit { get; set; }

        public string note { get; set; }

        [StringLength(10)]
        public string state { get; set; }

        [StringLength(10)]
        public string type { get; set; }

        public Guid? approver_id { get; set; }

        public Guid? create_user { get; set; }

        public DateTime? create_time { get; set; }

        public Guid? modify_user { get; set; }

        public DateTime? modify_time { get; set; }

        public virtual user_info user_info { get; set; }

        public virtual ctdt_state ctdt_state { get; set; }

        public virtual ctdt_type ctdt_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mon_hoc> mon_hoc { get; set; }
    }
}
