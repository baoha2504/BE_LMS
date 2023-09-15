using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class AccountState
    {
        public AccountState()
        {
            UserInfos = new HashSet<UserInfo>();
        }

        public string Code { get; set; } = null!;
        public string? AccountState1 { get; set; }
        public string? Description { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual ICollection<UserInfo> UserInfos { get; set; }
    }
}
