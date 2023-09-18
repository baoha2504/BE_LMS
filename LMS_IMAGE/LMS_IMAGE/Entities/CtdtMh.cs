using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class CtdtMh
    {
        public string Ctdt { get; set; } = null!;
        public string MhId { get; set; } = null!;
        public string? Note { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }

        public virtual CtDaoTao CtdtNavigation { get; set; } = null!;
        public virtual MonHoc Mh { get; set; } = null!;
    }
}
