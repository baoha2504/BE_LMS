using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public string Id { get; set; } = null!;
        public string? Descript { get; set; }
        public string? Note { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
