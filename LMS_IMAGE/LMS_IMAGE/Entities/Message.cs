using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class Message
    {
        public Guid Messageid { get; set; }
        public Guid RoomId { get; set; }
        public Guid Userid { get; set; }
        public string Content { get; set; } = null!;
        public DateTime CreateTime { get; set; }
        public bool IsStudent { get; set; }

        public virtual ChatRoom Room { get; set; } = null!;
    }
}
