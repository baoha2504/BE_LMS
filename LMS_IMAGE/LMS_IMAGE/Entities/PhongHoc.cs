using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class PhongHoc
    {
        public PhongHoc()
        {
            LichDungPhongs = new HashSet<LichDungPhong>();
        }

        public int PhongId { get; set; }
        public string? TenPhong { get; set; }
        public Guid? OfficeId { get; set; }
        public string? LoaiPhong { get; set; }
        public int? SoGhe { get; set; }
        public string? State { get; set; }
        public string? AddressChitiet { get; set; }
        public string? Note { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual LoaiPhong? LoaiPhongNavigation { get; set; }
        public virtual Office? Office { get; set; }
        public virtual TrangThaiPhong? StateNavigation { get; set; }
        public virtual ICollection<LichDungPhong> LichDungPhongs { get; set; }
    }
}
