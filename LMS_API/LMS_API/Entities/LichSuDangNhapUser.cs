using System;
using System.Collections.Generic;

namespace LMS_API.Entities
{
    public partial class LichSuDangNhapUser
    {
        public Guid? UserId { get; set; }
        public DateTime? LoginTime { get; set; }
        public bool? Status { get; set; }
        public string? LoginFailureNote { get; set; }
        public string? IpAddress { get; set; }

        public virtual UserInfo? User { get; set; }
    }
}
