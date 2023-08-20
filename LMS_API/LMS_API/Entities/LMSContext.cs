using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LMS_API.Entities
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
        public virtual DbSet<ClassYear> ClassYears { get; set; } = null!;
        public virtual DbSet<LichSuDangNhapStudent> LichSuDangNhapStudents { get; set; } = null!;
        public virtual DbSet<LichSuDangNhapUser> LichSuDangNhapUsers { get; set; } = null!;
        public virtual DbSet<Office> Offices { get; set; } = null!;
        public virtual DbSet<PhongHoc> PhongHocs { get; set; } = null!;
        public virtual DbSet<StudentInfo> StudentInfos { get; set; } = null!;
        public virtual DbSet<StudentLogin> StudentLogins { get; set; } = null!;
        public virtual DbSet<StudentState> StudentStates { get; set; } = null!;
        public virtual DbSet<UserInfo> UserInfos { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=123.31.24.17,1435;Initial Catalog=LMS;Persist Security Info=True;User ID=sa;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountState>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__account___357D4CF8758DB8AA");

                entity.ToTable("account_state");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
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

            modelBuilder.Entity<ClassYear>(entity =>
            {
                entity.HasKey(e => e.ClassYearName)
                    .HasName("PK__class_ye__4BCD02E13C56941A");

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
                    .HasConstraintName("FK__class_yea__offic__3C69FB99");
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
                    .HasConstraintName("FK__Lich_su_d__stude__68487DD7");
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
                    .HasConstraintName("FK__Lich_su_d__user___4BAC3F29");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.ToTable("office");

                entity.HasIndex(e => e.OfficeName, "UQ__office__D15EE29C5FAF7165")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressChitiet)
                    .HasMaxLength(100)
                    .HasColumnName("address_chitiet");

                entity.Property(e => e.AddressHuyen)
                    .HasMaxLength(20)
                    .HasColumnName("address_huyen");

                entity.Property(e => e.AddressTinh)
                    .HasMaxLength(20)
                    .HasColumnName("address_tinh");

                entity.Property(e => e.AddressXa)
                    .HasMaxLength(20)
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
                    .HasName("PK__phong_ho__F67F2229E317BD87");

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
                    .HasMaxLength(50)
                    .HasColumnName("loai_phong");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.SoGhe).HasColumnName("so_ghe");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.TenPhong)
                    .HasMaxLength(50)
                    .HasColumnName("ten_phong");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.PhongHocs)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK__phong_hoc__offic__3F466844");
            });

            modelBuilder.Entity<StudentInfo>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__student___2A33069A7270EA0B");

                entity.ToTable("student_info");

                entity.Property(e => e.StudentId)
                    .HasColumnName("student_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressChitiet)
                    .HasMaxLength(100)
                    .HasColumnName("address_chitiet");

                entity.Property(e => e.AddressHuyen)
                    .HasMaxLength(20)
                    .HasColumnName("address_huyen");

                entity.Property(e => e.AddressTinh)
                    .HasMaxLength(20)
                    .HasColumnName("address_tinh");

                entity.Property(e => e.AddressXa)
                    .HasMaxLength(20)
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
                    .IsUnicode(false)
                    .HasColumnName("que_quan");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .HasColumnName("sex");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(5)
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
                    .HasConstraintName("FK__student_i__class__619B8048");

                entity.HasOne(d => d.StateCodeNavigation)
                    .WithMany(p => p.StudentInfos)
                    .HasForeignKey(d => d.StateCode)
                    .HasConstraintName("FK__student_i__state__628FA481");
            });

            modelBuilder.Entity<StudentLogin>(entity =>
            {
                entity.ToTable("student_login");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("avatar");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("display_name");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.ResetTime)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("reset_time");

                entity.Property(e => e.ResetToken).HasColumnName("reset_token");

                entity.Property(e => e.StudentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("student_code");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.StudentLogin)
                    .HasForeignKey<StudentLogin>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__student_logi__id__66603565");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.StudentLogins)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK__student_l__offic__656C112C");
            });

            modelBuilder.Entity<StudentState>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__student___357D4CF83FD68DD1");

                entity.ToTable("student_state");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
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

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__user_inf__B9BE370F981CED83");

                entity.ToTable("user_info");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressChitiet)
                    .HasMaxLength(100)
                    .HasColumnName("address_chitiet");

                entity.Property(e => e.AddressHuyen)
                    .HasMaxLength(20)
                    .HasColumnName("address_huyen");

                entity.Property(e => e.AddressTinh)
                    .HasMaxLength(20)
                    .HasColumnName("address_tinh");

                entity.Property(e => e.AddressXa)
                    .HasMaxLength(20)
                    .HasColumnName("address_xa");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("cccd");

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(255)
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
                    .HasMaxLength(100)
                    .HasColumnName("que_quan");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .HasColumnName("sex");

                entity.Property(e => e.State)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.ToChuyenMon)
                    .HasMaxLength(255)
                    .HasColumnName("to_chuyen_mon");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.UserInfos)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK__user_info__state__44FF419A");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.ToTable("user_login");

                entity.HasIndex(e => e.Email, "UQ__user_log__AB6E6164C03A02A6")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(255)
                    .HasColumnName("avatar");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .HasColumnName("display_name");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.ResetTime)
                    .HasColumnType("datetime")
                    .HasColumnName("reset_time");

                entity.Property(e => e.ResetToken).HasColumnName("reset_token");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.UserLogin)
                    .HasForeignKey<UserLogin>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__user_login__id__48CFD27E");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK__user_logi__offic__49C3F6B7");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_role");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUser).HasColumnName("create_user");

                entity.Property(e => e.ModifyTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_time");

                entity.Property(e => e.ModifyUser).HasColumnName("modify_user");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__user_role__user___4D94879B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
