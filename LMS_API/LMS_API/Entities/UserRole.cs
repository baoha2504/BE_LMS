using System;
using System.Collections.Generic;

namespace LMS_API.Entities
{
    public partial class UserRole
    {
        public Guid? UserId { get; set; }
        public string? Role { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual UserInfo? User { get; set; }
    }
}
