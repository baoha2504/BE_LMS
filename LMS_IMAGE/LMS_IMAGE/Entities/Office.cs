using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class Office
    {
        public Office()
        {
            BaiGiangs = new HashSet<BaiGiang>();
            ClassYears = new HashSet<ClassYear>();
            PhongHocs = new HashSet<PhongHoc>();
            StudentLogins = new HashSet<StudentLogin>();
            UserLogins = new HashSet<UserLogin>();
        }

        public Guid Id { get; set; }
        public string? OfficeName { get; set; }
        public string? AddressTinh { get; set; }
        public string? AddressHuyen { get; set; }
        public string? AddressXa { get; set; }
        public string? AddressChitiet { get; set; }
        public string? Note { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual ICollection<BaiGiang> BaiGiangs { get; set; }
        public virtual ICollection<ClassYear> ClassYears { get; set; }
        public virtual ICollection<PhongHoc> PhongHocs { get; set; }
        public virtual ICollection<StudentLogin> StudentLogins { get; set; }
        public virtual ICollection<UserLogin> UserLogins { get; set; }
    }
}
