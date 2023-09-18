using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class BaiGiang
    {
        public int Id { get; set; }
        public Guid? OfficeId { get; set; }
        public Guid? GiaovienId { get; set; }
        public string? Giaovien2 { get; set; }
        public string? MhId { get; set; }
        public string? Content { get; set; }
        public int? ViewNumber { get; set; }
        public bool? State { get; set; }
        public Guid? ApproverId { get; set; }
        public int? KbgId { get; set; }

        public virtual UserInfo? Giaovien { get; set; }
        public virtual KhungBg? Kbg { get; set; }
        public virtual MonHoc? Mh { get; set; }
        public virtual Office? Office { get; set; }
    }
}
