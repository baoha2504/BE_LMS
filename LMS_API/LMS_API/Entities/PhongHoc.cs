using System;
using System.Collections.Generic;

namespace LMS_API.Entities
{
    public partial class PhongHoc
    {
        public int PhongId { get; set; }
        public string? TenPhong { get; set; }
        public Guid? OfficeId { get; set; }
        public string? LoaiPhong { get; set; }
        public int? SoGhe { get; set; }
        public bool? State { get; set; }
        public string? AddressChitiet { get; set; }
        public string? Note { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual Office? Office { get; set; }
    }
}
