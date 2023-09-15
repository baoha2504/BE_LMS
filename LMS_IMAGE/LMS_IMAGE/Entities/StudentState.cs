using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class StudentState
    {
        public StudentState()
        {
            StudentInfos = new HashSet<StudentInfo>();
        }

        public string Code { get; set; } = null!;
        public string? StateName { get; set; }
        public string? Note { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual ICollection<StudentInfo> StudentInfos { get; set; }
    }
}
