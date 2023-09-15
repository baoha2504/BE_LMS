using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class UserRole
    {
        public Guid UserId { get; set; }
        public string Role { get; set; } = null!;
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual Role RoleNavigation { get; set; } = null!;
        public virtual UserInfo User { get; set; } = null!;
    }
}
