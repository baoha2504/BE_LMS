using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class StudentLogin
    {
        public Guid Id { get; set; }
        public string StudentCode { get; set; } = null!;
        public Guid? OfficeId { get; set; }
        public string? Password { get; set; }
        public string? DisplayName { get; set; }
        public string? ResetToken { get; set; }
        public DateTime? ResetTime { get; set; }
        public string? Avatar { get; set; }

        public virtual StudentInfo IdNavigation { get; set; } = null!;
        public virtual Office? Office { get; set; }
    }
}
