using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            BaiGiangs = new HashSet<BaiGiang>();
            CtDaoTaos = new HashSet<CtDaoTao>();
            LichDungPhongUserDayThayNavigations = new HashSet<LichDungPhong>();
            LichDungPhongUserLeadNavigations = new HashSet<LichDungPhong>();
            LichDungPhongUserRegNavigations = new HashSet<LichDungPhong>();
            MonHocs = new HashSet<MonHoc>();
            UserRoles = new HashSet<UserRole>();
        }

        public Guid UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Sex { get; set; }
        public string Cccd { get; set; } = null!;
        public string? ChucVu { get; set; }
        public string? ToChuyenMon { get; set; }
        public string? AddressTinh { get; set; }
        public string? AddressHuyen { get; set; }
        public string? AddressXa { get; set; }
        public string? AddressChitiet { get; set; }
        public string? Phone { get; set; }
        public string? QueQuan { get; set; }
        public string? Note { get; set; }
        public string? State { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual AccountState? StateNavigation { get; set; }
        public virtual UserLogin UserLogin { get; set; } = null!;
        public virtual ICollection<BaiGiang> BaiGiangs { get; set; }
        public virtual ICollection<CtDaoTao> CtDaoTaos { get; set; }
        public virtual ICollection<LichDungPhong> LichDungPhongUserDayThayNavigations { get; set; }
        public virtual ICollection<LichDungPhong> LichDungPhongUserLeadNavigations { get; set; }
        public virtual ICollection<LichDungPhong> LichDungPhongUserRegNavigations { get; set; }
        public virtual ICollection<MonHoc> MonHocs { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
