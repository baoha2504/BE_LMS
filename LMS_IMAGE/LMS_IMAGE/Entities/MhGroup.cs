using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class MhGroup
    {
        public MhGroup()
        {
            MonHocs = new HashSet<MonHoc>();
        }

        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public string? Note { get; set; }
        public Guid? ApproverId { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual ICollection<MonHoc> MonHocs { get; set; }
    }
}
