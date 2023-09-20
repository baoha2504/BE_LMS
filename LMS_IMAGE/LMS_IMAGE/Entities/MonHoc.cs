using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class MonHoc
    {
        public MonHoc()
        {
            BaiGiangs = new HashSet<BaiGiang>();
            CtdtMhs = new HashSet<CtdtMh>();
            KhungBgs = new HashSet<KhungBg>();
        }

        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public string? Grade { get; set; }
        public int? SoTiet { get; set; }
        public string? Note { get; set; }
        public string? State { get; set; }
        public Guid? ApproverId { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string? Group { get; set; }
        public string? FileGiaotrinh { get; set; }
        public string? TenGiaotrinh { get; set; }

        public virtual UserInfo? Approver { get; set; }
        public virtual KhoiLop? GradeNavigation { get; set; }
        public virtual MhGroup? GroupNavigation { get; set; }
        public virtual MhState? StateNavigation { get; set; }
        public virtual ICollection<BaiGiang> BaiGiangs { get; set; }
        public virtual ICollection<CtdtMh> CtdtMhs { get; set; }
        public virtual ICollection<KhungBg> KhungBgs { get; set; }
    }
}
