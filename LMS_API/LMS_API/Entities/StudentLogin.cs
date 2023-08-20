using System;
using System.Collections.Generic;

namespace LMS_API.Entities
{
    public partial class StudentLogin
    {
        public Guid Id { get; set; }
        public string? StudentCode { get; set; }
        public Guid? OfficeId { get; set; }
        public string? Password { get; set; }
        public string? DisplayName { get; set; }
        public Guid? ResetToken { get; set; }
        public byte[] ResetTime { get; set; } = null!;
        public string? Avatar { get; set; }

        public virtual StudentInfo IdNavigation { get; set; } = null!;
        public virtual Office? Office { get; set; }
    }
}
