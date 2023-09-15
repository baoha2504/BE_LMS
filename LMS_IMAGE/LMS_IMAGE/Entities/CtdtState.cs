using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class CtdtState
    {
        public CtdtState()
        {
            CtDaoTaos = new HashSet<CtDaoTao>();
        }

        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public string? Note { get; set; }

        public virtual ICollection<CtDaoTao> CtDaoTaos { get; set; }
    }
}
