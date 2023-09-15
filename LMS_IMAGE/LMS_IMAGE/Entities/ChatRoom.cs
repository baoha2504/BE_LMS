using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class ChatRoom
    {
        public ChatRoom()
        {
            Messages = new HashSet<Message>();
            UserChatrooms = new HashSet<UserChatroom>();
        }

        public Guid RoomId { get; set; }
        public string? Roomname { get; set; }
        public bool IsGroupchat { get; set; }
        public string Type { get; set; } = null!;
        public bool? Status { get; set; }
        public Guid? UserLead { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string? Avatar { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<UserChatroom> UserChatrooms { get; set; }
    }
}
