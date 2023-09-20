using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LMS_IMAGE.Entities
{
    public partial class LMSContext : DbContext
    {
        public LMSContext()
        {
        }

        public LMSContext(DbContextOptions<LMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountState> AccountStates { get; set; } = null!;
        public virtual DbSet<BaiGiang> BaiGiangs { get; set; } = null!;
        public virtual DbSet<CalendarRepeater> CalendarRepeaters { get; set; } = null!;
        public virtual DbSet<CalendarState> CalendarStates { get; set; } = null!;
        public virtual DbSet<CalendarType> CalendarTypes { get; set; } = null!;
        public virtual DbSet<ChatRoom> ChatRooms { get; set; } = null!;
        public virtual DbSet<ClassYear> ClassYears { get; set; } = null!;
        public virtual DbSet<CtDaoTao> CtDaoTaos { get; set; } = null!;
        public virtual DbSet<CtdtMh> CtdtMhs { get; set; } = null!;
        public virtual DbSet<CtdtState> CtdtStates { get; set; } = null!;
        public virtual DbSet<CtdtType> CtdtTypes { get; set; } = null!;
        public virtual DbSet<DanhMucDiaChi> DanhMucDiaChis { get; set; } = null!;
        public virtual DbSet<KhoiLop> KhoiLops { get; set; } = null!;
        public virtual DbSet<KhungBg> KhungBgs { get; set; } = null!;
        public virtual DbSet<KhungBgType> KhungBgTypes { get; set; } = null!;
        public virtual DbSet<LichDungPhong> LichDungPhongs { get; set; } = null!;
        public virtual DbSet<LichSuDangNhapStudent> LichSuDangNhapStudents { get; set; } = null!;
        public virtual DbSet<LichSuDangNhapUser> LichSuDangNhapUsers { get; set; } = null!;
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<MhGroup> MhGroups { get; set; } = null!;
        public virtual DbSet<MhState> MhStates { get; set; } = null!;
        public virtual DbSet<MonHoc> MonHocs { get; set; } = null!;
        public virtual DbSet<Office> Offices { get; set; } = null!;
        public virtual DbSet<PhongHoc> PhongHocs { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<StudentInfo> StudentInfos { get; set; } = null!;
        public virtual DbSet<StudentLogin> StudentLogins { get; set; } = null!;
        public virtual DbSet<StudentState> StudentStates { get; set; } = null!;
        public virtual DbSet<ThoiGianTietHoc> ThoiGianTietHocs { get; set; } = null!;
        public virtual DbSet<TrangThaiPhong> TrangThaiPhongs { get; set; } = null!;
        public virtual DbSet<UserChatroom> UserChatrooms { get; set; } = null!;
        public virtual DbSet<UserInfo> UserInfos { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=14.231.93.67,13393;Initial Catalog=LMS;Persist Security Info=True;User ID=sa;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountState>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__account___357D4CF8E4B0368B");

                entity.ToTable("account_state");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.AccountState1)
                    .HasMaxLength(50)
                    .HasColumnName("account_state");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");
            });

            modelBuilder.Entity<BaiGiang>(entity =>
            {
                entity.ToTable("bai_giang");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApproverId).HasColumnName("approver_id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Giaovien2).HasColumnName("giaovien_2");

                entity.Property(e => e.GiaovienId).HasColumnName("giaovien_id");

                entity.Property(e => e.KbgId).HasColumnName("kbg_id");

                entity.Property(e => e.MhId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mh_id");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.ViewNumber).HasColumnName("view_number");

                entity.HasOne(d => d.Giaovien)
                    .WithMany(p => p.BaiGiangs)
                    .HasForeignKey(d => d.GiaovienId)
                    .HasConstraintName("FK__bai_giang__giaov__66603565");

                entity.HasOne(d => d.Kbg)
                    .WithMany(p => p.BaiGiangs)
                    .HasForeignKey(d => d.KbgId)
                    .HasConstraintName("FK__bai_giang__kbg_i__2739D489");

                entity.HasOne(d => d.Mh)
                    .WithMany(p => p.BaiGiangs)
                    .HasForeignKey(d => d.MhId)
                    .HasConstraintName("FK__bai_giang__mh_id__6754599E");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.BaiGiangs)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK__bai_giang__offic__68487DD7");
            });

            modelBuilder.Entity<CalendarRepeater>(entity =>
            {
                entity.ToTable("calendar_repeater");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Repeat2).HasColumnName("repeat_2");

                entity.Property(e => e.Repeat3).HasColumnName("repeat_3");

                entity.Property(e => e.Repeat4).HasColumnName("repeat_4");

                entity.Property(e => e.Repeat5).HasColumnName("repeat_5");

                entity.Property(e => e.Repeat6).HasColumnName("repeat_6");

                entity.Property(e => e.Repeat7).HasColumnName("repeat_7");

                entity.Property(e => e.RepeatCn).HasColumnName("repeat_cn");

                entity.Property(e => e.StartSetDate)
                    .HasColumnType("date")
                    .HasColumnName("start_set_date");

                entity.Property(e => e.StopSetDate)
                    .HasColumnType("date")
                    .HasColumnName("stop_set_date");
            });

            modelBuilder.Entity<CalendarState>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__calendar__357D4CF84836DF25");

                entity.ToTable("calendar_state");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Note).HasColumnName("note");
            });

            modelBuilder.Entity<CalendarType>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__calendar__357D4CF80EDDD5DC");

                entity.ToTable("calendar_type");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Note).HasColumnName("note");
            });

            modelBuilder.Entity<ChatRoom>(entity =>
            {
                entity.HasKey(e => e.RoomId)
                    .HasName("PK__chat_roo__19675A8A26D6E158");

                entity.ToTable("chat_room");

                entity.Property(e => e.RoomId)
                    .HasColumnName("room_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(255)
                    .HasColumnName("avatar");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.IsGroupchat).HasColumnName("is_groupchat");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Roomname)
                    .HasMaxLength(255)
                    .HasColumnName("roomname");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UserLead).HasColumnName("user_lead");
            });

            modelBuilder.Entity<ClassYear>(entity =>
            {
                entity.HasKey(e => e.ClassYearName)
                    .HasName("PK__class_ye__4BCD02E151B89307");

                entity.ToTable("class_year");

                entity.Property(e => e.ClassYearName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("class_year_name");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.ClassYears)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK__class_yea__offic__693CA210");
            });

            modelBuilder.Entity<CtDaoTao>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__ct_dao_t__357D4CF89F73375E");

                entity.ToTable("ct_dao_tao");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.ApproverId).HasColumnName("approver_id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Period).HasColumnName("period");

                entity.Property(e => e.PeriodUnit)
                    .HasMaxLength(10)
                    .HasColumnName("period_unit");

                entity.Property(e => e.StartTime)
                    .HasColumnType("date")
                    .HasColumnName("start_time");

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.HasOne(d => d.Approver)
                    .WithMany(p => p.CtDaoTaos)
                    .HasForeignKey(d => d.ApproverId)
                    .HasConstraintName("FK__ct_dao_ta__appro__6A30C649");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.CtDaoTaos)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK__ct_dao_ta__state__6B24EA82");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.CtDaoTaos)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK__ct_dao_tao__type__6C190EBB");
            });

            modelBuilder.Entity<CtdtMh>(entity =>
            {
                entity.HasKey(e => new { e.Ctdt, e.MhId })
                    .HasName("PK__ctdt_mh__1E1F9DE52232531B");

                entity.ToTable("ctdt_mh");

                entity.Property(e => e.Ctdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ctdt");

                entity.Property(e => e.MhId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mh_id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.HasOne(d => d.CtdtNavigation)
                    .WithMany(p => p.CtdtMhs)
                    .HasForeignKey(d => d.Ctdt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ctdt_mh__ctdt__6D0D32F4");

                entity.HasOne(d => d.Mh)
                    .WithMany(p => p.CtdtMhs)
                    .HasForeignKey(d => d.MhId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ctdt_mh__mh_id__6E01572D");
            });

            modelBuilder.Entity<CtdtState>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__ctdt_sta__357D4CF8CEDBD7C2");

                entity.ToTable("ctdt_state");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Note).HasColumnName("note");
            });

            modelBuilder.Entity<CtdtType>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__ctdt_typ__357D4CF863FB4D58");

                entity.ToTable("ctdt_type");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Note).HasColumnName("note");
            });

            modelBuilder.Entity<DanhMucDiaChi>(entity =>
            {
                entity.ToTable("danh_muc_dia_chi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressHuyen)
                    .HasMaxLength(50)
                    .HasColumnName("address_huyen");

                entity.Property(e => e.AddressTinh)
                    .HasMaxLength(50)
                    .HasColumnName("address_tinh");

                entity.Property(e => e.AddressXa)
                    .HasMaxLength(50)
                    .HasColumnName("address_xa");

                entity.Property(e => e.Note).HasColumnName("note");
            });

            modelBuilder.Entity<KhoiLop>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__khoi_lop__357D4CF856A522B6");

                entity.ToTable("khoi_lop");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Note).HasColumnName("note");
            });

            modelBuilder.Entity<KhungBg>(entity =>
            {
                entity.ToTable("khung_bg");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.KbgType)
                    .HasMaxLength(50)
                    .HasColumnName("kbg_type");

                entity.Property(e => e.MhId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mh_id");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.ShortTitle).HasColumnName("short_title");

                entity.Property(e => e.SoTiet).HasColumnName("so_tiet");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.HasOne(d => d.Mh)
                    .WithMany(p => p.KhungBgs)
                    .HasForeignKey(d => d.MhId)
                    .HasConstraintName("FK__khung_bg__mh_id__6FE99F9F");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__khung_bg__parent__70DDC3D8");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.KhungBgs)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK__khung_bg__type__71D1E811");
            });

            modelBuilder.Entity<KhungBgType>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__khung_bg__357D4CF8F2E03FD4");

                entity.ToTable("khung_bg_type");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Note).HasColumnName("note");
            });

            modelBuilder.Entity<LichDungPhong>(entity =>
            {
                entity.ToTable("lich_dung_phong");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CalendarType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("calendar_type");

                entity.Property(e => e.CheckEditRepeater).HasColumnName("check_edit_repeater");

                entity.Property(e => e.Content)
                    .HasMaxLength(100)
                    .HasColumnName("content");

                entity.Property(e => e.Lop)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lop");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.PhongId).HasColumnName("phong_id");

                entity.Property(e => e.RepeaterId).HasColumnName("repeater_id");

                entity.Property(e => e.StartTiet).HasColumnName("start_tiet");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time");

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.StopTiet).HasColumnName("stop_tiet");

                entity.Property(e => e.StopTime)
                    .HasColumnType("datetime")
                    .HasColumnName("stop_time");

                entity.Property(e => e.UserDayThay).HasColumnName("user_day_thay");

                entity.Property(e => e.UserLead).HasColumnName("user_lead");

                entity.Property(e => e.UserReg).HasColumnName("user_reg");

                entity.HasOne(d => d.CalendarTypeNavigation)
                    .WithMany(p => p.LichDungPhongs)
                    .HasForeignKey(d => d.CalendarType)
                    .HasConstraintName("FK__lich_dung__calen__72C60C4A");

                entity.HasOne(d => d.LopNavigation)
                    .WithMany(p => p.LichDungPhongs)
                    .HasForeignKey(d => d.Lop)
                    .HasConstraintName("FK__lich_dung_p__lop__778AC167");

                entity.HasOne(d => d.Phong)
                    .WithMany(p => p.LichDungPhongs)
                    .HasForeignKey(d => d.PhongId)
                    .HasConstraintName("fk_phong_id");

                entity.HasOne(d => d.Repeater)
                    .WithMany(p => p.LichDungPhongs)
                    .HasForeignKey(d => d.RepeaterId)
                    .HasConstraintName("fk_repeater_id");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.LichDungPhongs)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK__lich_dung__state__73BA3083");

                entity.HasOne(d => d.UserDayThayNavigation)
                    .WithMany(p => p.LichDungPhongUserDayThayNavigations)
                    .HasForeignKey(d => d.UserDayThay)
                    .HasConstraintName("FK__lich_dung__user___75A278F5");

                entity.HasOne(d => d.UserLeadNavigation)
                    .WithMany(p => p.LichDungPhongUserLeadNavigations)
                    .HasForeignKey(d => d.UserLead)
                    .HasConstraintName("FK__lich_dung__user___74AE54BC");

                entity.HasOne(d => d.UserRegNavigation)
                    .WithMany(p => p.LichDungPhongUserRegNavigations)
                    .HasForeignKey(d => d.UserReg)
                    .HasConstraintName("FK__lich_dung__user___76969D2E");
            });

            modelBuilder.Entity<LichSuDangNhapStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lich_su_dang_nhap_student");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(100)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LoginFailureNote).HasColumnName("login_failure_note");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("login_time");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StudentId).HasColumnName("student_id");

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__Lich_su_d__stude__7A672E12");
            });

            modelBuilder.Entity<LichSuDangNhapUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lich_su_dang_nhap_user");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(100)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LoginFailureNote).HasColumnName("login_failure_note");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("login_time");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Lich_su_d__user___7B5B524B");
            });

            modelBuilder.Entity<LoaiPhong>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__loai_pho__357D4CF8E7EB5098");

                entity.ToTable("loai_phong");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Note).HasColumnName("note");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("message");

                entity.Property(e => e.Messageid)
                    .HasColumnName("messageid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsStudent).HasColumnName("is_student");

                entity.Property(e => e.RoomId).HasColumnName("room_id");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__message__room_id__19DFD96B");
            });

            modelBuilder.Entity<MhGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__mh_group__357D4CF85CD753CB");

                entity.ToTable("mh_group");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Note).HasColumnName("note");
            });

            modelBuilder.Entity<MhState>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__mh_state__357D4CF813483F87");

                entity.ToTable("mh_state");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Note).HasColumnName("note");
            });

            modelBuilder.Entity<MonHoc>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__mon_hoc__357D4CF84B706579");

                entity.ToTable("mon_hoc");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.ApproverId).HasColumnName("approver_id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.FileGiaotrinh).HasColumnName("file_giaotrinh");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grade");

                entity.Property(e => e.Group)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("group");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.SoTiet).HasColumnName("so_tiet");

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.TenGiaotrinh).HasColumnName("ten_giaotrinh");

                entity.HasOne(d => d.Approver)
                    .WithMany(p => p.MonHocs)
                    .HasForeignKey(d => d.ApproverId)
                    .HasConstraintName("FK__mon_hoc__approve__7C4F7684");

                entity.HasOne(d => d.GradeNavigation)
                    .WithMany(p => p.MonHocs)
                    .HasForeignKey(d => d.Grade)
                    .HasConstraintName("FK__mon_hoc__grade__7D439ABD");

                entity.HasOne(d => d.GroupNavigation)
                    .WithMany(p => p.MonHocs)
                    .HasForeignKey(d => d.Group)
                    .HasConstraintName("FK__mon_hoc__group__7E37BEF6");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.MonHocs)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK__mon_hoc__state__7F2BE32F");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.ToTable("office");

                entity.HasIndex(e => e.OfficeName, "UQ__office__D15EE29CD9B94090")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressChitiet)
                    .HasMaxLength(200)
                    .HasColumnName("address_chitiet");

                entity.Property(e => e.AddressHuyen)
                    .HasMaxLength(50)
                    .HasColumnName("address_huyen");

                entity.Property(e => e.AddressTinh)
                    .HasMaxLength(50)
                    .HasColumnName("address_tinh");

                entity.Property(e => e.AddressXa)
                    .HasMaxLength(50)
                    .HasColumnName("address_xa");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.OfficeName)
                    .HasMaxLength(100)
                    .HasColumnName("office_name");
            });

            modelBuilder.Entity<PhongHoc>(entity =>
            {
                entity.HasKey(e => e.PhongId)
                    .HasName("PK__phong_ho__F67F22293E61257D");

                entity.ToTable("phong_hoc");

                entity.Property(e => e.PhongId).HasColumnName("phong_id");

                entity.Property(e => e.AddressChitiet)
                    .HasMaxLength(100)
                    .HasColumnName("address_chitiet");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.LoaiPhong)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("loai_phong");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.SoGhe).HasColumnName("so_ghe");

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.TenPhong)
                    .HasMaxLength(50)
                    .HasColumnName("ten_phong");

                entity.HasOne(d => d.LoaiPhongNavigation)
                    .WithMany(p => p.PhongHocs)
                    .HasForeignKey(d => d.LoaiPhong)
                    .HasConstraintName("FK__phong_hoc__loai___00200768");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.PhongHocs)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK__phong_hoc__offic__01142BA1");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.PhongHocs)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK__phong_hoc__state__02084FDA");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Descript)
                    .HasMaxLength(255)
                    .HasColumnName("descript");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .HasColumnName("note");
            });

            modelBuilder.Entity<StudentInfo>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__student___2A33069A5F073173");

                entity.ToTable("student_info");

                entity.HasIndex(e => e.Email, "UQ__student___AB6E6164B2405CF9")
                    .IsUnique();

                entity.Property(e => e.StudentId)
                    .HasColumnName("student_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressChitiet)
                    .HasMaxLength(200)
                    .HasColumnName("address_chitiet");

                entity.Property(e => e.AddressHuyen)
                    .HasMaxLength(50)
                    .HasColumnName("address_huyen");

                entity.Property(e => e.AddressTinh)
                    .HasMaxLength(50)
                    .HasColumnName("address_tinh");

                entity.Property(e => e.AddressXa)
                    .HasMaxLength(50)
                    .HasColumnName("address_xa");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.BirthdayCha)
                    .HasColumnType("date")
                    .HasColumnName("birthday_cha");

                entity.Property(e => e.BirthdayMe)
                    .HasColumnType("date")
                    .HasColumnName("birthday_me");

                entity.Property(e => e.ClassYearId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("class_year_id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .HasColumnName("first_name");

                entity.Property(e => e.ImageOffice)
                    .HasMaxLength(255)
                    .HasColumnName("image_office");

                entity.Property(e => e.JobCha)
                    .HasMaxLength(255)
                    .HasColumnName("job_cha");

                entity.Property(e => e.JobMe)
                    .HasMaxLength(255)
                    .HasColumnName("job_me");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .HasColumnName("last_name");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PhoneCha)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone_cha");

                entity.Property(e => e.PhoneMe)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone_me");

                entity.Property(e => e.QueQuan)
                    .HasMaxLength(100)
                    .HasColumnName("que_quan");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .HasColumnName("sex");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("state_code");

                entity.Property(e => e.TenCha)
                    .HasMaxLength(50)
                    .HasColumnName("ten_cha");

                entity.Property(e => e.TenMe)
                    .HasMaxLength(50)
                    .HasColumnName("ten_me");

                entity.HasOne(d => d.ClassYear)
                    .WithMany(p => p.StudentInfos)
                    .HasForeignKey(d => d.ClassYearId)
                    .HasConstraintName("FK__student_i__class__02FC7413");

                entity.HasOne(d => d.StateCodeNavigation)
                    .WithMany(p => p.StudentInfos)
                    .HasForeignKey(d => d.StateCode)
                    .HasConstraintName("FK__student_i__state__03F0984C");
            });

            modelBuilder.Entity<StudentLogin>(entity =>
            {
                entity.ToTable("student_login");

                entity.HasIndex(e => e.StudentCode, "UQ__student___6DF33C45EB2D0F6C")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("avatar");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .HasColumnName("display_name");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.ResetTime)
                    .HasColumnType("datetime")
                    .HasColumnName("reset_time");

                entity.Property(e => e.ResetToken)
                    .IsUnicode(false)
                    .HasColumnName("reset_token");

                entity.Property(e => e.StudentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("student_code")
                    .IsFixedLength();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.StudentLogin)
                    .HasForeignKey<StudentLogin>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__student_logi__id__05D8E0BE");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.StudentLogins)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK__student_l__offic__04E4BC85");
            });

            modelBuilder.Entity<StudentState>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__student___357D4CF8C1EDBDF6");

                entity.ToTable("student_state");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.StateName)
                    .HasMaxLength(50)
                    .HasColumnName("state_name");
            });

            modelBuilder.Entity<ThoiGianTietHoc>(entity =>
            {
                entity.ToTable("thoi_gian_tiet_hoc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ca)
                    .HasMaxLength(10)
                    .HasColumnName("ca");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StopTime).HasColumnName("stop_time");

                entity.Property(e => e.Tiet).HasColumnName("tiet");
            });

            modelBuilder.Entity<TrangThaiPhong>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__trang_th__357D4CF8A21D51A8");

                entity.ToTable("trang_thai_phong");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Note).HasColumnName("note");
            });

            modelBuilder.Entity<UserChatroom>(entity =>
            {
                entity.ToTable("user_chatroom");

                entity.Property(e => e.UserChatroomid)
                    .HasColumnName("user_chatroomid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RoomId).HasColumnName("room_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.UserChatrooms)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__user_chat__room___151B244E");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__user_inf__B9BE370F2B63758C");

                entity.ToTable("user_info");

                entity.HasIndex(e => e.Cccd, "UQ__user_inf__37D42BFAB5C8D426")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressChitiet)
                    .HasMaxLength(200)
                    .HasColumnName("address_chitiet");

                entity.Property(e => e.AddressHuyen)
                    .HasMaxLength(50)
                    .HasColumnName("address_huyen");

                entity.Property(e => e.AddressTinh)
                    .HasMaxLength(50)
                    .HasColumnName("address_tinh");

                entity.Property(e => e.AddressXa)
                    .HasMaxLength(50)
                    .HasColumnName("address_xa");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("cccd")
                    .IsFixedLength();

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(100)
                    .HasColumnName("chuc_vu");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .HasColumnName("last_name");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.QueQuan)
                    .HasMaxLength(200)
                    .HasColumnName("que_quan");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .HasColumnName("sex");

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.ToChuyenMon)
                    .HasMaxLength(100)
                    .HasColumnName("to_chuyen_mon");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.UserInfos)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK__user_info__state__06CD04F7");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.ToTable("user_login");

                entity.HasIndex(e => e.Email, "UQ__user_log__AB6E61640D88B5DF")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Avatar).HasColumnName("avatar");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .HasColumnName("display_name");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.ResetTime)
                    .HasColumnType("datetime")
                    .HasColumnName("reset_time");

                entity.Property(e => e.ResetToken)
                    .IsUnicode(false)
                    .HasColumnName("reset_token");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.UserLogin)
                    .HasForeignKey<UserLogin>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__user_login__id__08B54D69");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK__user_logi__offic__07C12930");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.Role, e.UserId })
                    .HasName("PK__user_rol__6DA6C23989E7ABB6");

                entity.ToTable("user_role");

                entity.Property(e => e.Role)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.Role)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__user_role__role__09A971A2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__user_role__user___0A9D95DB");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
