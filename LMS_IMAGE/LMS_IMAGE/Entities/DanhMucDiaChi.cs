using System;
using System.Collections.Generic;

namespace LMS_IMAGE.Entities
{
    public partial class DanhMucDiaChi
    {
        public int Id { get; set; }
        public string? AddressTinh { get; set; }
        public string? AddressHuyen { get; set; }
        public string? AddressXa { get; set; }
        public string? Note { get; set; }
    }
}
