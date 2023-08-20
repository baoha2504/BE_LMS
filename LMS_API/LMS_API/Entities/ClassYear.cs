using System;
using System.Collections.Generic;

namespace LMS_API.Entities
{
    public partial class ClassYear
    {
        public ClassYear()
        {
            StudentInfos = new HashSet<StudentInfo>();
        }

        public string ClassYearName { get; set; } = null!;
        public Guid? OfficeId { get; set; }
        public string? Note { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual Office? Office { get; set; }
        public virtual ICollection<StudentInfo> StudentInfos { get; set; }
    }
}
