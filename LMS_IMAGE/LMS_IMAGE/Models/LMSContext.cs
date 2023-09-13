using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LMS_IMAGE.Models
{
    public partial class LMSContext : DbContext
    {
        public LMSContext()
            : base("name=LMSContext")
        {
        }

        public virtual DbSet<account_state> account_state { get; set; }
        public virtual DbSet<bai_giang> bai_giang { get; set; }
        public virtual DbSet<calendar_repeater> calendar_repeater { get; set; }
        public virtual DbSet<calendar_state> calendar_state { get; set; }
        public virtual DbSet<calendar_type> calendar_type { get; set; }
        public virtual DbSet<class_year> class_year { get; set; }
        public virtual DbSet<ct_dao_tao> ct_dao_tao { get; set; }
        public virtual DbSet<ctdt_state> ctdt_state { get; set; }
        public virtual DbSet<ctdt_type> ctdt_type { get; set; }
        public virtual DbSet<danh_muc_dia_chi> danh_muc_dia_chi { get; set; }
        public virtual DbSet<khoi_lop> khoi_lop { get; set; }
        public virtual DbSet<khung_bg> khung_bg { get; set; }
        public virtual DbSet<khung_bg_type> khung_bg_type { get; set; }
        public virtual DbSet<lich_dung_phong> lich_dung_phong { get; set; }
        public virtual DbSet<loai_phong> loai_phong { get; set; }
        public virtual DbSet<mh_group> mh_group { get; set; }
        public virtual DbSet<mh_state> mh_state { get; set; }
        public virtual DbSet<mon_hoc> mon_hoc { get; set; }
        public virtual DbSet<office> offices { get; set; }
        public virtual DbSet<phong_hoc> phong_hoc { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<student_info> student_info { get; set; }
        public virtual DbSet<student_login> student_login { get; set; }
        public virtual DbSet<student_state> student_state { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<thoi_gian_tiet_hoc> thoi_gian_tiet_hoc { get; set; }
        public virtual DbSet<trang_thai_phong> trang_thai_phong { get; set; }
        public virtual DbSet<user_info> user_info { get; set; }
        public virtual DbSet<user_login> user_login { get; set; }
        public virtual DbSet<user_role> user_role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<account_state>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<account_state>()
                .HasMany(e => e.user_info)
                .WithOptional(e => e.account_state)
                .HasForeignKey(e => e.state);

            modelBuilder.Entity<bai_giang>()
                .Property(e => e.mh_id)
                .IsUnicode(false);

            modelBuilder.Entity<bai_giang>()
                .HasMany(e => e.khung_bg)
                .WithOptional(e => e.bai_giang)
                .HasForeignKey(e => e.bg_id);

            modelBuilder.Entity<calendar_repeater>()
                .HasMany(e => e.lich_dung_phong)
                .WithOptional(e => e.calendar_repeater)
                .HasForeignKey(e => e.repeater_id);

            modelBuilder.Entity<calendar_state>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<calendar_state>()
                .HasMany(e => e.lich_dung_phong)
                .WithOptional(e => e.calendar_state)
                .HasForeignKey(e => e.state);

            modelBuilder.Entity<calendar_type>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<calendar_type>()
                .HasMany(e => e.lich_dung_phong)
                .WithOptional(e => e.calendar_type1)
                .HasForeignKey(e => e.calendar_type);

            modelBuilder.Entity<class_year>()
                .Property(e => e.class_year_name)
                .IsUnicode(false);

            modelBuilder.Entity<class_year>()
                .HasMany(e => e.lich_dung_phong)
                .WithOptional(e => e.class_year)
                .HasForeignKey(e => e.lop);

            modelBuilder.Entity<class_year>()
                .HasMany(e => e.student_info)
                .WithOptional(e => e.class_year)
                .HasForeignKey(e => e.class_year_id);

            modelBuilder.Entity<ct_dao_tao>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<ct_dao_tao>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<ct_dao_tao>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<ct_dao_tao>()
                .HasMany(e => e.mon_hoc)
                .WithMany(e => e.ct_dao_tao)
                .Map(m => m.ToTable("ctdt_mh").MapLeftKey("ctdt").MapRightKey("mh_id"));

            modelBuilder.Entity<ctdt_state>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<ctdt_state>()
                .HasMany(e => e.ct_dao_tao)
                .WithOptional(e => e.ctdt_state)
                .HasForeignKey(e => e.state);

            modelBuilder.Entity<ctdt_type>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<ctdt_type>()
                .HasMany(e => e.ct_dao_tao)
                .WithOptional(e => e.ctdt_type)
                .HasForeignKey(e => e.type);

            modelBuilder.Entity<khoi_lop>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<khoi_lop>()
                .HasMany(e => e.mon_hoc)
                .WithOptional(e => e.khoi_lop)
                .HasForeignKey(e => e.grade);

            modelBuilder.Entity<khung_bg>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<khung_bg>()
                .Property(e => e.mh_id)
                .IsUnicode(false);

            modelBuilder.Entity<khung_bg>()
                .HasMany(e => e.khung_bg1)
                .WithOptional(e => e.khung_bg2)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<khung_bg_type>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<khung_bg_type>()
                .HasMany(e => e.khung_bg)
                .WithOptional(e => e.khung_bg_type)
                .HasForeignKey(e => e.type);

            modelBuilder.Entity<lich_dung_phong>()
                .Property(e => e.lop)
                .IsUnicode(false);

            modelBuilder.Entity<lich_dung_phong>()
                .Property(e => e.calendar_type)
                .IsUnicode(false);

            modelBuilder.Entity<lich_dung_phong>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<lich_dung_phong>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<loai_phong>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<loai_phong>()
                .HasMany(e => e.phong_hoc)
                .WithOptional(e => e.loai_phong1)
                .HasForeignKey(e => e.loai_phong);

            modelBuilder.Entity<mh_group>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<mh_group>()
                .HasMany(e => e.mon_hoc)
                .WithOptional(e => e.mh_group)
                .HasForeignKey(e => e.group);

            modelBuilder.Entity<mh_state>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<mh_state>()
                .HasMany(e => e.mon_hoc)
                .WithOptional(e => e.mh_state)
                .HasForeignKey(e => e.state);

            modelBuilder.Entity<mon_hoc>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<mon_hoc>()
                .Property(e => e.grade)
                .IsUnicode(false);

            modelBuilder.Entity<mon_hoc>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<mon_hoc>()
                .Property(e => e.group)
                .IsUnicode(false);

            modelBuilder.Entity<mon_hoc>()
                .HasMany(e => e.bai_giang)
                .WithOptional(e => e.mon_hoc)
                .HasForeignKey(e => e.mh_id);

            modelBuilder.Entity<mon_hoc>()
                .HasMany(e => e.khung_bg)
                .WithOptional(e => e.mon_hoc)
                .HasForeignKey(e => e.mh_id);

            modelBuilder.Entity<office>()
                .HasMany(e => e.bai_giang)
                .WithOptional(e => e.office)
                .HasForeignKey(e => e.office_id);

            modelBuilder.Entity<office>()
                .HasMany(e => e.class_year)
                .WithOptional(e => e.office)
                .HasForeignKey(e => e.office_id);

            modelBuilder.Entity<office>()
                .HasMany(e => e.phong_hoc)
                .WithOptional(e => e.office)
                .HasForeignKey(e => e.office_id);

            modelBuilder.Entity<office>()
                .HasMany(e => e.student_login)
                .WithOptional(e => e.office)
                .HasForeignKey(e => e.office_id);

            modelBuilder.Entity<office>()
                .HasMany(e => e.user_login)
                .WithOptional(e => e.office)
                .HasForeignKey(e => e.office_id);

            modelBuilder.Entity<phong_hoc>()
                .Property(e => e.loai_phong)
                .IsUnicode(false);

            modelBuilder.Entity<phong_hoc>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.user_role)
                .WithRequired(e => e.role1)
                .HasForeignKey(e => e.role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.class_year_id)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.phone_cha)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.phone_me)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.state_code)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .HasOptional(e => e.student_login)
                .WithRequired(e => e.student_info);

            modelBuilder.Entity<student_login>()
                .Property(e => e.student_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<student_login>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<student_login>()
                .Property(e => e.reset_token)
                .IsUnicode(false);

            modelBuilder.Entity<student_login>()
                .Property(e => e.avatar)
                .IsUnicode(false);

            modelBuilder.Entity<student_state>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<student_state>()
                .HasMany(e => e.student_info)
                .WithOptional(e => e.student_state)
                .HasForeignKey(e => e.state_code);

            modelBuilder.Entity<thoi_gian_tiet_hoc>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<trang_thai_phong>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<trang_thai_phong>()
                .HasMany(e => e.phong_hoc)
                .WithOptional(e => e.trang_thai_phong)
                .HasForeignKey(e => e.state);

            modelBuilder.Entity<user_info>()
                .Property(e => e.cccd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_info>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<user_info>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<user_info>()
                .HasMany(e => e.bai_giang)
                .WithOptional(e => e.user_info)
                .HasForeignKey(e => e.giaovien_id);

            modelBuilder.Entity<user_info>()
                .HasMany(e => e.ct_dao_tao)
                .WithOptional(e => e.user_info)
                .HasForeignKey(e => e.approver_id);

            modelBuilder.Entity<user_info>()
                .HasMany(e => e.lich_dung_phong)
                .WithOptional(e => e.user_info)
                .HasForeignKey(e => e.user_lead);

            modelBuilder.Entity<user_info>()
                .HasMany(e => e.lich_dung_phong1)
                .WithOptional(e => e.user_info1)
                .HasForeignKey(e => e.user_day_thay);

            modelBuilder.Entity<user_info>()
                .HasMany(e => e.lich_dung_phong2)
                .WithOptional(e => e.user_info2)
                .HasForeignKey(e => e.user_reg);

            modelBuilder.Entity<user_info>()
                .HasMany(e => e.mon_hoc)
                .WithOptional(e => e.user_info)
                .HasForeignKey(e => e.approver_id);

            modelBuilder.Entity<user_info>()
                .HasOptional(e => e.user_login)
                .WithRequired(e => e.user_info);

            modelBuilder.Entity<user_info>()
                .HasMany(e => e.user_role)
                .WithRequired(e => e.user_info)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user_login>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user_login>()
                .Property(e => e.reset_token)
                .IsUnicode(false);

            modelBuilder.Entity<user_role>()
                .Property(e => e.role)
                .IsUnicode(false);
        }
    }
}
