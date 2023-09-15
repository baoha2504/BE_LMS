using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class KhungBgType
    {
        public KhungBgType()
        {
            KhungBgs = new HashSet<KhungBg>();
        }

        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public string? Note { get; set; }

        public virtual ICollection<KhungBg> KhungBgs { get; set; }
    }
}
