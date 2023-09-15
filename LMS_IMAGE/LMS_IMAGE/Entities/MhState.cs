using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class MhState
    {
        public MhState()
        {
            MonHocs = new HashSet<MonHoc>();
        }

        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public string? Note { get; set; }

        public virtual ICollection<MonHoc> MonHocs { get; set; }
    }
}
