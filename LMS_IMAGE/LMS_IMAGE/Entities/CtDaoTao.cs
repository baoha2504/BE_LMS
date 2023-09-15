using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class CtDaoTao
    {
        public CtDaoTao()
        {
            Mhs = new HashSet<MonHoc>();
        }

        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public DateTime? StartTime { get; set; }
        public double? Period { get; set; }
        public string? PeriodUnit { get; set; }
        public string? Note { get; set; }
        public string? State { get; set; }
        public string? Type { get; set; }
        public Guid? ApproverId { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual UserInfo? Approver { get; set; }
        public virtual CtdtState? StateNavigation { get; set; }
        public virtual CtdtType? TypeNavigation { get; set; }

        public virtual ICollection<MonHoc> Mhs { get; set; }
    }
}
