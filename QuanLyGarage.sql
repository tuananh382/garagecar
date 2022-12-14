USE [master]
GO
/****** Object:  Database [QuanLyGarage] ******/
CREATE DATABASE [QuanLyGarage]
GO
/****** Setup Database [QuanLyGarage] ******/
ALTER DATABASE [QuanLyGarage] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyGarage].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyGarage] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyGarage] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyGarage] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyGarage] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyGarage] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyGarage] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyGarage] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyGarage] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyGarage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyGarage] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyGarage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyGarage] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyGarage] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyGarage] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyGarage] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyGarage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyGarage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyGarage] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyGarage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyGarage] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyGarage] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyGarage] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyGarage] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyGarage] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyGarage] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyGarage] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyGarage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyGarage] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyGarage] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyGarage', N'ON'
GO
ALTER DATABASE [QuanLyGarage] SET QUERY_STORE = OFF
GO
USE [QuanLyGarage]
GO
/****** Setup Table [dbo].[BAOCAOTON] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAOTON](
	[MaBCT] [int] NOT NULL,
	[ThoiDiemBaoCao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Setup Table [dbo].[CHITIETPHIEUSUACHUA] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUSUACHUA](
	[MaPhieuSuaChua] [int] NULL,
	[MaTC] [int] NULL,
	[MaPhuTung] [int] NULL,
	[SoLuongPhuTung] [int] NULL
) ON [PRIMARY]
GO
/****** Setup Table [dbo].[CT_BAOCAOTON]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_BAOCAOTON](
	[MaBCT] [int] NOT NULL,
	[MaPhuTung] [int] NOT NULL,
	[TonDau] [int] NULL,
	[PhatSinh] [int] NULL,
	[TonCuoi] [int] NULL,
 CONSTRAINT [pk_ctBCT] PRIMARY KEY CLUSTERED 
(
	[MaBCT] ASC,
	[MaPhuTung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Setup Table [dbo].[HIEUXE]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIEUXE](
	[MaHX] [int] NOT NULL,
	[TenHieuXe] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Setup Table [dbo].[KHACHHANG]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] NOT NULL,
	[TenKH] [varchar](30) NULL,
	[DienThoai] [varchar](10) NULL,
	[DiaChi] [varchar](100) NULL,
	[TienNo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Setup Table [dbo].[KHO]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHO](
	[MaPhuTung] [int] NOT NULL,
	[TenVatTuPhuTung] [varchar](30) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhuTung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Setup Table [dbo].[PHIEUNHAPVTPT]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAPVTPT](
	[MaPNVTPT] [int] NOT NULL,
	[MaPhuTung] [int] NULL,
	[SoLuong] [int] NULL,
	[ThoiDiem] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPNVTPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Setup Table [dbo].[PHIEUSUACHUA]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUSUACHUA](
	[MaPhieuSuaChua] [int] NOT NULL,
	[BienSo] [varchar](10) NULL,
	[MaKH] [int] NULL,
	[TienCong] [int] NULL,
	[TienPhuTung] [int] NULL,
	[TongTien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuSuaChua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Setup Table [dbo].[PHIEUTHUTIEN]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUTIEN](
	[MaPhieuThuTien] [int] NOT NULL,
	[MaKH] [int] NULL,
	[TienThu] [int] NULL,
	[NgayThuTien] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Setup Table [dbo].[TAIKHOAN]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MaTK] [int] NOT NULL,
	[TenChuTaiKhoan] [varchar](20) NULL,
	[TenDangNhap] [varchar](20) NULL,
	[MatKhau] [varchar](20) NULL,
	[QuyenHan] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Setup Table [dbo].[THAMSO]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[MaThamSo] [varchar](5) NOT NULL,
	[TenThamSo] [varchar](50) NULL,
	[GiaTri] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThamSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Setup Table [dbo].[TIENCONG]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIENCONG](
	[MaTC] [int] NOT NULL,
	[TenTienCong] [varchar](100) NULL,
	[ChiPhi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Setup Table [dbo].[XE]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XE](
	[BienSo] [varchar](10) NOT NULL,
	[MaHX] [int] NULL,
	[MaKH] [int] NULL,
	[NgayTiepNhan] [datetime] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BienSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Insert Data to Database ******/
INSERT [dbo].[HIEUXE] ([MaHX], [TenHieuXe]) VALUES (0, N'Toyota')
INSERT [dbo].[HIEUXE] ([MaHX], [TenHieuXe]) VALUES (1, N'Kia')
INSERT [dbo].[HIEUXE] ([MaHX], [TenHieuXe]) VALUES (2, N'Mazda')
INSERT [dbo].[HIEUXE] ([MaHX], [TenHieuXe]) VALUES (3, N'Ford')
INSERT [dbo].[HIEUXE] ([MaHX], [TenHieuXe]) VALUES (4, N'Honda')
INSERT [dbo].[HIEUXE] ([MaHX], [TenHieuXe]) VALUES (5, N'Chevrolet')
INSERT [dbo].[HIEUXE] ([MaHX], [TenHieuXe]) VALUES (6, N'Mitsubishi')
INSERT [dbo].[HIEUXE] ([MaHX], [TenHieuXe]) VALUES (7, N'Suzuki')
INSERT [dbo].[HIEUXE] ([MaHX], [TenHieuXe]) VALUES (8, N'Isuzu')
INSERT [dbo].[HIEUXE] ([MaHX], [TenHieuXe]) VALUES (9, N'Mercedes')
INSERT [dbo].[HIEUXE] ([MaHX], [TenHieuXe]) VALUES (10, N'Lexus')
INSERT [dbo].[HIEUXE] ([MaHX], [TenHieuXe]) VALUES (11, N'Peugeot')
INSERT [dbo].[HIEUXE] ([MaHX], [TenHieuXe]) VALUES (12, N'Audi')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DienThoai], [DiaChi], [TienNo]) VALUES (1, N'Tran Kim Trung', N'1', N'QN', 1000)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DienThoai], [DiaChi], [TienNo]) VALUES (2, N'Tran Thi Kim Dung', N'2', N'QN', 2000)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DienThoai], [DiaChi], [TienNo]) VALUES (3, N'Ta Thi Thu Lieu', N'3', N'QN', 3000)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DienThoai], [DiaChi], [TienNo]) VALUES (4, N'Tran Kim Ngoc', N'4', N'QN', 0)
INSERT [dbo].[KHO] ([MaPhuTung], [TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (0, N'Guong chieu hau', 100, 3400000)
INSERT [dbo].[KHO] ([MaPhuTung], [TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (1, N'Den hau', 100, 1900000)
INSERT [dbo].[KHO] ([MaPhuTung], [TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (2, N'Den pha', 100, 3700000)
INSERT [dbo].[KHO] ([MaPhuTung], [TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (3, N'Kinh chan gio', 100, 1600000)
INSERT [dbo].[KHO] ([MaPhuTung], [TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (4, N'Nap binh xang', 100, 220000)
INSERT [dbo].[KHO] ([MaPhuTung], [TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (5, N'Binh xang', 100, 4800000)
INSERT [dbo].[KHO] ([MaPhuTung], [TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (6, N'Chan bun', 100, 1300000)
INSERT [dbo].[KHO] ([MaPhuTung], [TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (7, N'Lop xe', 100, 2000000)
INSERT [dbo].[KHO] ([MaPhuTung], [TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (8, N'Cam bien ABS', 100, 1500000)
INSERT [dbo].[KHO] ([MaPhuTung], [TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (9, N'Bugi', 100, 230000)
INSERT [dbo].[KHO] ([MaPhuTung], [TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (10, N'Ken xe', 100, 240000)
INSERT [dbo].[PHIEUNHAPVTPT] ([MaPNVTPT], [MaPhuTung], [SoLuong], [ThoiDiem]) VALUES (1, 0, 10, CAST(N'2019-07-11T02:05:49.927' AS DateTime))
INSERT [dbo].[PHIEUNHAPVTPT] ([MaPNVTPT], [MaPhuTung], [SoLuong], [ThoiDiem]) VALUES (2, 5, 10, CAST(N'2019-07-11T02:05:57.117' AS DateTime))
INSERT [dbo].[PHIEUNHAPVTPT] ([MaPNVTPT], [MaPhuTung], [SoLuong], [ThoiDiem]) VALUES (3, 7, 10, CAST(N'2019-07-11T02:06:07.780' AS DateTime))
INSERT [dbo].[TAIKHOAN] ([MaTK], [TenChuTaiKhoan], [TenDangNhap], [MatKhau], [QuyenHan]) VALUES (0, N'Nguyen Van Boss', N'admin', N'0', N'admin')
INSERT [dbo].[TAIKHOAN] ([MaTK], [TenChuTaiKhoan], [TenDangNhap], [MatKhau], [QuyenHan]) VALUES (1, N'Nguyen Thi Thu Ky', N'user', N'1', N'Nhan vien')
INSERT [dbo].[THAMSO] ([MaThamSo], [TenThamSo], [GiaTri]) VALUES (N'TS2', N'So xe sua chua toi da', 30)
INSERT [dbo].[THAMSO] ([MaThamSo], [TenThamSo], [GiaTri]) VALUES (N'TS3', N'So loai vat tu', 200)
INSERT [dbo].[THAMSO] ([MaThamSo], [TenThamSo], [GiaTri]) VALUES (N'TS4', N'So loai tien cong', 100)
INSERT [dbo].[TIENCONG] ([MaTC], [TenTienCong], [ChiPhi]) VALUES (0, N'Thay guong chieu hau', 50000)
INSERT [dbo].[TIENCONG] ([MaTC], [TenTienCong], [ChiPhi]) VALUES (1, N'Thay den xe', 100000)
INSERT [dbo].[TIENCONG] ([MaTC], [TenTienCong], [ChiPhi]) VALUES (2, N'Thay kinh chan gio', 70000)
INSERT [dbo].[TIENCONG] ([MaTC], [TenTienCong], [ChiPhi]) VALUES (3, N'Thay binh xang', 150000)
INSERT [dbo].[TIENCONG] ([MaTC], [TenTienCong], [ChiPhi]) VALUES (4, N'Thay la chan bun', 60000)
INSERT [dbo].[TIENCONG] ([MaTC], [TenTienCong], [ChiPhi]) VALUES (5, N'Thay lop xe', 80000)
INSERT [dbo].[TIENCONG] ([MaTC], [TenTienCong], [ChiPhi]) VALUES (6, N'Gan cam bien ABS', 120000)
INSERT [dbo].[TIENCONG] ([MaTC], [TenTienCong], [ChiPhi]) VALUES (7, N'Thay bugi', 100000)
INSERT [dbo].[TIENCONG] ([MaTC], [TenTienCong], [ChiPhi]) VALUES (8, N'Thay ken xe', 90000)
INSERT [dbo].[TIENCONG] ([MaTC], [TenTienCong], [ChiPhi]) VALUES (9, N'Bom banh xe', 40000)
INSERT [dbo].[TIENCONG] ([MaTC], [TenTienCong], [ChiPhi]) VALUES (10, N'Ve sinh phu tung xe', 200000)
INSERT [dbo].[TIENCONG] ([MaTC], [TenTienCong], [ChiPhi]) VALUES (11, N'Son xe', 5000000)

/****** Add Constraint to Table ******/

ALTER TABLE [dbo].[CHITIETPHIEUSUACHUA]  WITH CHECK ADD FOREIGN KEY([MaPhieuSuaChua])
REFERENCES [dbo].[PHIEUSUACHUA] ([MaPhieuSuaChua])
GO
ALTER TABLE [dbo].[CHITIETPHIEUSUACHUA]  WITH CHECK ADD FOREIGN KEY([MaPhuTung])
REFERENCES [dbo].[KHO] ([MaPhuTung])
GO
ALTER TABLE [dbo].[CHITIETPHIEUSUACHUA]  WITH CHECK ADD FOREIGN KEY([MaTC])
REFERENCES [dbo].[TIENCONG] ([MaTC])
GO
ALTER TABLE [dbo].[CT_BAOCAOTON]  WITH CHECK ADD FOREIGN KEY([MaPhuTung])
REFERENCES [dbo].[KHO] ([MaPhuTung])
GO
ALTER TABLE [dbo].[PHIEUSUACHUA]  WITH CHECK ADD FOREIGN KEY([BienSo])
REFERENCES [dbo].[XE] ([BienSo])
GO
ALTER TABLE [dbo].[PHIEUSUACHUA]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[XE]  WITH CHECK ADD FOREIGN KEY([MaHX])
REFERENCES [dbo].[HIEUXE] ([MaHX])
GO
ALTER TABLE [dbo].[XE]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
/****** StoredProcedure [dbo].[BaoCaoDoanhThu]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BaoCaoDoanhThu]
		@Thang int,
		@Nam int
AS
BEGIN
  select KH.TenKH as 'Tên KH',KH.DienThoai as 'Số điện thoại',kh.DiaChi as 'Địa chỉ' ,HX.TenHieuXe as 'Hiệu xe', SQRT(COUNT(PSC.MaPhieuSuaChua)) as 'Số Lượt Sửa', SUM(PTT.TienThu)/SQRT(COUNT(PSC.MaPhieuSuaChua)) as 'Đã thanh toán', KH.TienNo as 'Còn thiếu'
	FROM KHACHHANG as KH, XE, HIEUXE as HX, PHIEUTHUTIEN as PTT, PHIEUSUACHUA as PSC
	WHERE KH.MaKH = XE.MaKH and XE.MaHX = HX.MaHX and PTT.MaKH = KH.MaKH and PSC.BienSo = Xe.BienSo
	group by KH.TenKH, HX.TenHieuXe, KH.TienNo,KH.DienThoai,kh.DiaChi
END
GO
/****** StoredProcedure [dbo].[DoiMK]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DoiMK]
	@MaTK int,
	@MatKhauMoi varchar(20)
AS
BEGIN
	UPDATE TAIKHOAN
	SET MatKhau = @MatKhauMoi 
	WHERE MaTK = @MaTK
END
GO
/****** StoredProcedure [dbo].[NhapMoiVTPT]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[NhapMoiVTPT]
	@TenPhuTung varchar(30),
	@SoLuong int,
	@DonGia int,
	@ThoiDiem datetime
AS
BEGIN
	DECLARE @iMPNVTPT int
	SELECT @iMPNVTPT = COUNT(MaPNVTPT) FROM PHIEUNHAPVTPT
	SET @iMPNVTPT = @iMPNVTPT + 1
	DECLARE @iMVTPT int
	SELECT @iMVTPT = COUNT(MaPhuTung) FROM KHO
	SET @iMVTPT = @iMVTPT + 1
	INSERT INTO KHO (MaPhuTung, TenVatTuPhuTung, SoLuong, DonGia) VALUES (@iMVTPT, @TenPhuTung, @SoLuong, @DonGia)
	INSERT INTO PHIEUNHAPVTPT (MaPNVTPT, MaPhuTung, SoLuong, ThoiDiem) VALUES (@iMPNVTPT, @iMVTPT, @SoLuong, @ThoiDiem)
END
GO
/****** StoredProcedure [dbo].[NhapVTPT]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[NhapVTPT]
	@MaPhuTung int,
	@SoLuong int,
	@ThoiDiem datetime
AS
BEGIN
	DECLARE @iMPNVTPT int
	SELECT @iMPNVTPT = COUNT(MaPNVTPT) FROM PHIEUNHAPVTPT
	SET @iMPNVTPT = @iMPNVTPT + 1
	INSERT INTO PHIEUNHAPVTPT (MaPNVTPT, MaPhuTung, SoLuong, ThoiDiem) VALUES (@iMPNVTPT, @MaPhuTung, @SoLuong, @ThoiDiem)
	UPDATE KHO SET SoLuong = SoLuong + @SoLuong WHERE MaPhuTung = @MaPhuTung
END
GO
/******  StoredProcedure [dbo].[ThemKhachHang]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemKhachHang]
	@TenKH varchar(30),
	@DienThoai varchar(10),
	@DiaChi varchar(100),
	@TienNo int
AS
BEGIN
	DECLARE @test int
	SELECT @test=COUNT(MaKH) FROM KHACHHANG WHERE (@TenKH = TenKH) and (@DienThoai = DienThoai) 
	if @test = 0
	BEGIN
		DECLARE @imakh int
		select  @imakh = MAX(MaKH) from KHACHHANG
		IF (@imakh is null) set @imakh = 0
		else set @imakh = @imakh + 1			
		INSERT INTO KHACHHANG (MaKH, TenKH, DiaChi, DienThoai, TienNo) VALUES (@imakh, @TenKH, @DiaChi,@DienThoai, @TienNo)
	END
END;
GO
/******  StoredProcedure [dbo].[ThemPhieuThuTien]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ThemPhieuThuTien]
	@BienSo varchar(10),
	@TienThu int,
	@NgayThuTien datetime
AS
BEGIN
		DECLARE @imaptt int
		DECLARE @MaKH int
		SELECT @imaptt = COUNT(MaPhieuThuTien) from PHIEUTHUTIEN
		SET @imaptt = @imaptt + 1
		SELECT @MaKH = MaKH FROM XE WHERE XE.BienSo = @BienSo
		INSERT INTO PHIEUTHUTIEN (MaPhieuThuTien, MaKH, TienThu, NgayThuTien) VALUES (@imaptt, @MaKH, @TienThu, @NgayThuTien)
		UPDATE KHACHHANG SET TienNo = TienNo - @TienThu WHERE MaKH = @MaKH
		UPDATE XE SET TrangThai = 0 WHERE BienSo = @BienSo
END
GO
/****** StoredProcedure [dbo].[ThemXe]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemXe]
	@BienSo varchar(10) ,
	@HieuXe int,
	@MaKH int,
	@NgayTiepNhan datetime
AS
BEGIN
	INSERT INTO Xe (BienSo, MaHX, MaKH, NgayTiepNhan, TrangThai) VALUES (@BienSo, @HieuXe, @MaKH,@NgayTiepNhan, 1)
END;
GO
/******  StoredProcedure [dbo].[TimKiemChinhXac]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TimKiemChinhXac]
	@BienSo varchar(10),
	@HieuXe varchar(30)
AS
BEGIN
	SELECT BienSo , TenHieuXe, TenKH, DienThoai, DiaChi, TienNo
	FROM XE, HIEUXE as HX, KHACHHANG as KH, PHIEUSUACHUA as PSC
	WHERE XE.MaHX = HX.MaHX and KH.MaKH = XE.MaKH and @BienSo = XE.BienSo and @HieuXe = HX.TenHieuXe 
END
GO
/******  StoredProcedure [dbo].[TimKiemTuongDoi]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TimKiemTuongDoi]
	@DuLieu varchar(100)
AS
BEGIN
	SELECT BienSo, TenHieuXe, TenKH, DienThoai, DiaChi, TienNo
	FROM KHACHHANG as KH, XE, HIEUXE as HX
	WHERE KH.MaKH = XE.MaKH and XE.MaHX = HX.MaHX and ((BienSo LIKE '%'+@DuLieu+'%') or (TenHieuXe LIKE '%'+@DuLieu+'%') or (TenKH LIKE '%'+@DuLieu+'%') or (DienThoai LIKE '%'+@DuLieu+'%') or (DiaChi LIKE '%'+@DuLieu+'%'))
END
GO
/******  StoredProcedure [dbo].[TongTienDoanhThu]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TongTienDoanhThu]
		@Thang int,
		@Nam int
AS
BEGIN
	select sum(PTT.TienThu)
	from PHIEUTHUTIEN as PTT
	WHERE Month(PTT.NgayThuTien) = @Thang and YEAR(PTT.NgayThuTien) = @Nam
END
GO
/******  StoredProcedure [dbo].[USP_DangNhap]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_DangNhap]
@TenDangNhap nvarchar(50), @MatKhau nvarchar(50)
AS
BEGIN
	SELECT * FROM dbo.TAIKHOAN WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyGarage] SET  READ_WRITE 
GO