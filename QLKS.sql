USE master
GO
IF EXISTS (SELECT * FROM sysdatabases WHERE NAME = 'qlks')
	DROP DATABASE qlks
	GO
CREATE DATABASE qlks
GO

USE qlks
GO
	
CREATE TABLE Phong (MaPhong nvarchar(10) PRIMARY KEY,
					TinhTrang bit,
					LoaiPhong bit,
					GiaTien float)
CREATE TABLE TaiKhoan ( MaTK nvarchar(10) PRIMARY KEY,
						TenTK varchar(20) NOT NULL,
						MatKhau varchar(20) NOT NULL,
						LoaiTK bit NOT NULL,
						MaNV nvarchar(10)
						)

CREATE TABLE NhanVien (MaNV nvarchar(10) PRIMARY KEY,
						TenNV nvarchar(20),
						DiaChi nvarchar(30),
						NgaySinh Date,
						MaTK nvarchar(10),
						)

CREATE TABLE KhachHang (MaKH nvarchar(10) PRIMARY KEY,
						CMND varchar (9) UNIQUE,
						QuocTich nvarchar(20),
						TenKH nvarchar(25),
						MaPhong nvarchar(10),
						FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
						)
CREATE TABLE SuCo (MaSC nvarchar(10) PRIMARY KEY,
					TenSC nvarchar(20),
					ChiTietVeSuCo nvarchar(50),
					MaPhong nvarchar(10),
					FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
					)

CREATE TABLE HoaDon (MaHD nvarchar(10) PRIMARY KEY,
						MaNV nvarchar(10),
						MaKH nvarchar(10),
						SoDem INTEGER,
						SoKhach INTEGER,
						TongTien float,
						FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
						FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
					)

CREATE TABLE VatTu (MaVT nvarchar(10) PRIMARY KEY,
					TenVT nvarchar(20),
					MaPhong nvarchar(10),
					SoDem INTEGER,
					SoKhach INTEGER,
					TongTien float,
					FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
					)

CREATE TABLE DichVu (MaDV nvarchar(10) PRIMARY KEY,
					MaPhong nvarchar(10),
					GiaDV float,
					TenDV nvarchar(20)
					)

/*Cấu hình relationshop many to many giữa Dịch Vụ với Phòng*/
CREATE TABLE PhongDichVu ( MaPhong nvarchar(10) NOT NULL,
							MaDV nvarchar(10) NOT NULL,
							PRIMARY KEY (MaPhong, MaDV),
							FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong),
							FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV)
							)
INSERT INTO TaiKhoan Values ('TK01', 'LamCute', 'lam123', 1, 'NV01')
INSERT INTO NhanVien VALUES ('NV01', 'LamHeo', 'QuyNhon', NULL, 'TK01')

select * from TaiKhoan

select * from NhanVien

INSERT INTO TaiKhoan Values ('TK02', 'Lamxx', 'lam123', 1, 'NV02')
INSERT INTO NhanVien VALUES ('NV02', 'LamHeo@', 'QuyNhon', NULL, 'TK02')



/*Note:
ALTER TABLE TaiKhoan ADD CONSTRAINT FK_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)

ALTER TABLE TaiKhoan DROP CONSTRAINT FK_MaNV
Phong vs Hoa Don : 1 vs 1 =>  hoa don la 1 phan con phong la toan bo
TaiKhoan vs Nhan Vien: 1 vs 1 => tai khoan la toan bo con nhan vien la 1 phan 
Phong vs Dich Vu:  Many vs Many
*/

select * from TaiKhoan 
