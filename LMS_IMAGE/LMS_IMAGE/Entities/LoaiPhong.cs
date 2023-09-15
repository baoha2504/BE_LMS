using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class LoaiPhong
    {
        public LoaiPhong()
        {
            PhongHocs = new HashSet<PhongHoc>();
        }

        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public string? Note { get; set; }

        public virtual ICollection<PhongHoc> PhongHocs { get; set; }
    }
}
