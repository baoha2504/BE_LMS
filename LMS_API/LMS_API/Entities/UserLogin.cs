using System;
using System.Collections.Generic;

namespace LMS_API.Entities
{
    public partial class UserLogin
    {
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public Guid? OfficeId { get; set; }
        public string? DisplayName { get; set; }
        public string? Password { get; set; }
        public Guid? ResetToken { get; set; }
        public DateTime? ResetTime { get; set; }
        public string? Avatar { get; set; }

        public virtual UserInfo IdNavigation { get; set; } = null!;
        public virtual Office? Office { get; set; }
    }
}
