using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class CalendarRepeater
    {
        public CalendarRepeater()
        {
            LichDungPhongs = new HashSet<LichDungPhong>();
        }

        public int Id { get; set; }
        public DateTime? StartSetDate { get; set; }
        public DateTime? StopSetDate { get; set; }
        public bool? Repeat2 { get; set; }
        public bool? Repeat3 { get; set; }
        public bool? Repeat4 { get; set; }
        public bool? Repeat5 { get; set; }
        public bool? Repeat6 { get; set; }
        public bool? Repeat7 { get; set; }
        public bool? RepeatCn { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual ICollection<LichDungPhong> LichDungPhongs { get; set; }
    }
}
