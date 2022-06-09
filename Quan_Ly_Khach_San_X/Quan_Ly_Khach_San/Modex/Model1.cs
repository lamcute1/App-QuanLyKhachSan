using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Quan_Ly_Khach_San.Modex
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=QLKSModelX")
        {
        }

        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<SuCo> SuCoes { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<VatTu> VatTus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DichVu>()
                .Property(e => e.GiaDV)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.GiaTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.DichVus)
                .WithMany(e => e.Phongs)
                .Map(m => m.ToTable("PhongDichVu").MapLeftKey("MaPhong").MapRightKey("MaDV"));

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenTK)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<VatTu>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);
            modelBuilder.Entity<Phong>()
                .HasRequired(s => s.hoadon)
                .WithRequiredPrincipal(ad => ad.phong);
            modelBuilder.Entity<TaiKhoan>()
                .HasRequired(s => s.nhanvien)
                .WithRequiredPrincipal(ad => ad.taikhoan);
        }
    }
}
