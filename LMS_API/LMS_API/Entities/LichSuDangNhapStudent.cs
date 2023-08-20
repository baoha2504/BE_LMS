using System;
using System.Collections.Generic;

namespace LMS_API.Entities
{
    public partial class LichSuDangNhapStudent
    {
        public Guid? StudentId { get; set; }
        public DateTime? LoginTime { get; set; }
        public bool? Status { get; set; }
        public string? LoginFailureNote { get; set; }
        public string? IpAddress { get; set; }

        public virtual StudentInfo? Student { get; set; }
    }
}
