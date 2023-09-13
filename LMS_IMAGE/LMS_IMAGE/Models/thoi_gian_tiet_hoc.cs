namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class thoi_gian_tiet_hoc
    {
        public int id { get; set; }

        public int tiet { get; set; }

        public TimeSpan? start_time { get; set; }

        public TimeSpan? stop_time { get; set; }

        [StringLength(10)]
        public string ca { get; set; }

        public string note { get; set; }

        public Guid? create_user { get; set; }

        public DateTime? create_time { get; set; }

        public Guid? modify_user { get; set; }

        public DateTime? modify_time { get; set; }
    }
}
