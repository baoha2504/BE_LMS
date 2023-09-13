namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class danh_muc_dia_chi
    {
        public int id { get; set; }

        [StringLength(50)]
        public string address_tinh { get; set; }

        [StringLength(50)]
        public string address_huyen { get; set; }

        [StringLength(50)]
        public string address_xa { get; set; }

        public string note { get; set; }
    }
}
