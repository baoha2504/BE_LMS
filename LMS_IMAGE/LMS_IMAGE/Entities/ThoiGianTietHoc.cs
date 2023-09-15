using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class ThoiGianTietHoc
    {
        public int Id { get; set; }
        public int Tiet { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? StopTime { get; set; }
        public string? Ca { get; set; }
        public string? Note { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
