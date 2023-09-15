using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class CalendarState
    {
        public CalendarState()
        {
            LichDungPhongs = new HashSet<LichDungPhong>();
        }

        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public string? Note { get; set; }

        public virtual ICollection<LichDungPhong> LichDungPhongs { get; set; }
    }
}
