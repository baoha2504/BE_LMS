using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class StudentInfo
    {
        public Guid StudentId { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Sex { get; set; }
        public string? ClassYearId { get; set; }
        public string? AddressTinh { get; set; }
        public string? AddressHuyen { get; set; }
        public string? AddressXa { get; set; }
        public string? AddressChitiet { get; set; }
        public string? Phone { get; set; }
        public string? ImageOffice { get; set; }
        public string? TenCha { get; set; }
        public DateTime? BirthdayCha { get; set; }
        public string? JobCha { get; set; }
        public string? PhoneCha { get; set; }
        public string? TenMe { get; set; }
        public DateTime? BirthdayMe { get; set; }
        public string? JobMe { get; set; }
        public string? PhoneMe { get; set; }
        public string? QueQuan { get; set; }
        public string? StateCode { get; set; }
        public Guid? CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ModifyTime { get; set; }

        public virtual ClassYear? ClassYear { get; set; }
        public virtual StudentState? StateCodeNavigation { get; set; }
        public virtual StudentLogin StudentLogin { get; set; } = null!;
    }
}
