namespace LMS_IMAGE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lich_dung_phong
    {
        public Guid id { get; set; }

        public int? start_tiet { get; set; }

        public int? stop_tiet { get; set; }

        public DateTime? start_time { get; set; }

        public DateTime? stop_time { get; set; }

        public int? phong_id { get; set; }

        [StringLength(100)]
        public string content { get; set; }

        [StringLength(20)]
        public string lop { get; set; }

        public Guid? user_lead { get; set; }

        public Guid? user_day_thay { get; set; }

        public Guid? user_reg { get; set; }

        [StringLength(10)]
        public string calendar_type { get; set; }

        [StringLength(10)]
        public string state { get; set; }

        public string note { get; set; }

        public int? repeater_id { get; set; }

        public bool? check_edit_repeater { get; set; }

        public virtual calendar_repeater calendar_repeater { get; set; }

        public virtual calendar_state calendar_state { get; set; }

        public virtual calendar_type calendar_type1 { get; set; }

        public virtual class_year class_year { get; set; }

        public virtual user_info user_info { get; set; }

        public virtual user_info user_info1 { get; set; }

        public virtual user_info user_info2 { get; set; }

        public virtual phong_hoc phong_hoc { get; set; }
    }
}
