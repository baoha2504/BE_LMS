using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class UserChatroom
    {
        public Guid UserChatroomid { get; set; }
        public Guid Userid { get; set; }
        public Guid RoomId { get; set; }
        public bool? Status { get; set; }

        public virtual ChatRoom Room { get; set; } = null!;
    }
}
