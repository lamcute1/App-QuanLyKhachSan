namespace Quan_Ly_Khach_San.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class capnhat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DichVu",
                c => new
                    {
                        MaDV = c.String(nullable: false, maxLength: 10),
                        MaPhong = c.String(maxLength: 10),
                        GiaDV = c.Decimal(storeType: "float"),
                        TenDV = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.MaDV);
            
            CreateTable(
                "dbo.Phong",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 10),
                        TinhTrang = c.Boolean(),
                        LoaiPhong = c.Boolean(),
                        GiaTien = c.Decimal(storeType: "float"),
                    })
                .PrimaryKey(t => t.MaPhong);
            
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 10),
                        MaNV = c.String(maxLength: 10),
                        MaKH = c.String(maxLength: 10),
                        SoDem = c.Int(),
                        SoKhach = c.Int(),
                        TongTien = c.Decimal(storeType: "float"),
                    })
                .PrimaryKey(t => t.MaHD)
                .ForeignKey("dbo.KhachHang", t => t.MaKH)
                .ForeignKey("dbo.NhanVien", t => t.MaNV)
                .ForeignKey("dbo.Phong", t => t.MaHD)
                .Index(t => t.MaHD)
                .Index(t => t.MaNV)
                .Index(t => t.MaKH);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 10),
                        CMND = c.String(maxLength: 9, unicode: false),
                        QuocTich = c.String(maxLength: 20),
                        TenKH = c.String(maxLength: 25),
                        MaPhong = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.MaKH)
                .ForeignKey("dbo.Phong", t => t.MaPhong)
                .Index(t => t.MaPhong);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 10),
                        TenNV = c.String(maxLength: 20),
                        DiaChi = c.String(maxLength: 30),
                        NgaySinh = c.DateTime(storeType: "date"),
                        MaTK = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.MaNV)
                .ForeignKey("dbo.TaiKhoan", t => t.MaNV)
                .Index(t => t.MaNV);
            
            CreateTable(
                "dbo.TaiKhoan",
                c => new
                    {
                        MaTK = c.String(nullable: false, maxLength: 10),
                        TenTK = c.String(nullable: false, maxLength: 20, unicode: false),
                        MatKhau = c.String(nullable: false, maxLength: 20, unicode: false),
                        LoaiTK = c.Boolean(nullable: false),
                        MaNV = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.MaTK);
            
            CreateTable(
                "dbo.SuCo",
                c => new
                    {
                        MaSC = c.String(nullable: false, maxLength: 10),
                        TenSC = c.String(maxLength: 20),
                        ChiTietVeSuCo = c.String(maxLength: 50),
                        MaPhong = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.MaSC)
                .ForeignKey("dbo.Phong", t => t.MaPhong)
                .Index(t => t.MaPhong);
            
            CreateTable(
                "dbo.VatTu",
                c => new
                    {
                        MaVT = c.String(nullable: false, maxLength: 10),
                        TenVT = c.String(maxLength: 20),
                        MaPhong = c.String(maxLength: 10),
                        SoDem = c.Int(),
                        SoKhach = c.Int(),
                        TongTien = c.Decimal(storeType: "float"),
                    })
                .PrimaryKey(t => t.MaVT)
                .ForeignKey("dbo.Phong", t => t.MaPhong)
                .Index(t => t.MaPhong);
            
            CreateTable(
                "dbo.PhongDichVu",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 10),
                        MaDV = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => new { t.MaPhong, t.MaDV })
                .ForeignKey("dbo.Phong", t => t.MaPhong, cascadeDelete: true)
                .ForeignKey("dbo.DichVu", t => t.MaDV, cascadeDelete: true)
                .Index(t => t.MaPhong)
                .Index(t => t.MaDV);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VatTu", "MaPhong", "dbo.Phong");
            DropForeignKey("dbo.SuCo", "MaPhong", "dbo.Phong");
            DropForeignKey("dbo.HoaDon", "MaHD", "dbo.Phong");
            DropForeignKey("dbo.NhanVien", "MaNV", "dbo.TaiKhoan");
            DropForeignKey("dbo.HoaDon", "MaNV", "dbo.NhanVien");
            DropForeignKey("dbo.KhachHang", "MaPhong", "dbo.Phong");
            DropForeignKey("dbo.HoaDon", "MaKH", "dbo.KhachHang");
            DropForeignKey("dbo.PhongDichVu", "MaDV", "dbo.DichVu");
            DropForeignKey("dbo.PhongDichVu", "MaPhong", "dbo.Phong");
            DropIndex("dbo.PhongDichVu", new[] { "MaDV" });
            DropIndex("dbo.PhongDichVu", new[] { "MaPhong" });
            DropIndex("dbo.VatTu", new[] { "MaPhong" });
            DropIndex("dbo.SuCo", new[] { "MaPhong" });
            DropIndex("dbo.NhanVien", new[] { "MaNV" });
            DropIndex("dbo.KhachHang", new[] { "MaPhong" });
            DropIndex("dbo.HoaDon", new[] { "MaKH" });
            DropIndex("dbo.HoaDon", new[] { "MaNV" });
            DropIndex("dbo.HoaDon", new[] { "MaHD" });
            DropTable("dbo.PhongDichVu");
            DropTable("dbo.VatTu");
            DropTable("dbo.SuCo");
            DropTable("dbo.TaiKhoan");
            DropTable("dbo.NhanVien");
            DropTable("dbo.KhachHang");
            DropTable("dbo.HoaDon");
            DropTable("dbo.Phong");
            DropTable("dbo.DichVu");
        }
    }
}
