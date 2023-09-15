using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class CalendarType
    {
        public CalendarType()
        {
            LichDungPhongs = new HashSet<LichDungPhong>();
        }

        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public string? Note { get; set; }

        public virtual ICollection<LichDungPhong> LichDungPhongs { get; set; }
    }
}
