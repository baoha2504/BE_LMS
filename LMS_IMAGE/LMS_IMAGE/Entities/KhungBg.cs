using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class KhungBg
    {
        public KhungBg()
        {
            InverseParent = new HashSet<KhungBg>();
        }

        public int Id { get; set; }
        public string? KbgType { get; set; }
        public string? Type { get; set; }
        public string? MhId { get; set; }
        public string? ShortTitle { get; set; }
        public string? Title { get; set; }
        public int? ParentId { get; set; }
        public int? SoTiet { get; set; }
        public string? Note { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? BgId { get; set; }

        public virtual BaiGiang? Bg { get; set; }
        public virtual MonHoc? Mh { get; set; }
        public virtual KhungBg? Parent { get; set; }
        public virtual KhungBgType? TypeNavigation { get; set; }
        public virtual ICollection<KhungBg> InverseParent { get; set; }
    }
}
