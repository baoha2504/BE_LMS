using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class LichDungPhong
    {
        public Guid Id { get; set; }
        public int? StartTiet { get; set; }
        public int? StopTiet { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StopTime { get; set; }
        public int? PhongId { get; set; }
        public string? Content { get; set; }
        public string? Lop { get; set; }
        public Guid? UserLead { get; set; }
        public Guid? UserDayThay { get; set; }
        public Guid? UserReg { get; set; }
        public string? CalendarType { get; set; }
        public string? State { get; set; }
        public string? Note { get; set; }
        public int? RepeaterId { get; set; }
        public bool? CheckEditRepeater { get; set; }

        public virtual CalendarType? CalendarTypeNavigation { get; set; }
        public virtual ClassYear? LopNavigation { get; set; }
        public virtual PhongHoc? Phong { get; set; }
        public virtual CalendarRepeater? Repeater { get; set; }
        public virtual CalendarState? StateNavigation { get; set; }
        public virtual UserInfo? UserDayThayNavigation { get; set; }
        public virtual UserInfo? UserLeadNavigation { get; set; }
        public virtual UserInfo? UserRegNavigation { get; set; }
    }
}
