USE [master]
GO
/****** Object:  Database [QLHH]    Script Date: 4/3/2021 7:47:14 AM ******/
CREATE DATABASE [QLHH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLHH', FILENAME = N'D:\sql\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLHH.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLHH_log', FILENAME = N'D:\sql\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLHH_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLHH] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLHH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLHH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLHH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLHH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLHH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLHH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLHH] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLHH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLHH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLHH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLHH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLHH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLHH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLHH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLHH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLHH] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLHH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLHH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLHH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLHH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLHH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLHH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLHH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLHH] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLHH] SET  MULTI_USER 
GO
ALTER DATABASE [QLHH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLHH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLHH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLHH] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLHH] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLHH]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 4/3/2021 7:47:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[DanhMucId] [int] IDENTITY(1,1) NOT NULL,
	[TenDanhMuc] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[DanhMucId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 4/3/2021 7:47:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[KhoId] [int] NOT NULL,
	[DanhMucId] [int] NOT NULL,
	[GiaNhap] [int] NOT NULL,
	[GiaBan] [int] NOT NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 4/3/2021 7:47:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[HoaDonId] [int] NOT NULL,
	[HangHoaId] [int] NOT NULL,
	[TenMatHang] [nvarchar](max) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[KhoId] [int] NOT NULL,
	[LoaiId] [int] NOT NULL,
	[GiaBan] [int] NOT NULL,
	[NgayBan] [date] NOT NULL,
	[Lai] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/3/2021 7:47:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[IdKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[IdHoaDon] [int] NOT NULL,
	[TenKhachHang] [nvarchar](max) NOT NULL,
	[NgayMua] [date] NOT NULL,
	[TongTien] [int] NOT NULL,
	[Lai] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[IdKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kho]    Script Date: 4/3/2021 7:47:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[KhoId] [int] IDENTITY(1,1) NOT NULL,
	[TenKho] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[KhoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 4/3/2021 7:47:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[CMND] [nvarchar](max) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[DanhMuc] ON 

INSERT [dbo].[DanhMuc] ([DanhMucId], [TenDanhMuc]) VALUES (0, N'All')
INSERT [dbo].[DanhMuc] ([DanhMucId], [TenDanhMuc]) VALUES (1, N'Đồ điện tử')
INSERT [dbo].[DanhMuc] ([DanhMucId], [TenDanhMuc]) VALUES (2, N'Đồ điện lạnh')
INSERT [dbo].[DanhMuc] ([DanhMucId], [TenDanhMuc]) VALUES (3, N'Thực phẩm')
INSERT [dbo].[DanhMuc] ([DanhMucId], [TenDanhMuc]) VALUES (4, N'Mỹ phẩm')
SET IDENTITY_INSERT [dbo].[DanhMuc] OFF
SET IDENTITY_INSERT [dbo].[HangHoa] ON 

INSERT [dbo].[HangHoa] ([Id], [Ten], [SoLuong], [KhoId], [DanhMucId], [GiaNhap], [GiaBan]) VALUES (17, N'SamsungGalaxy S21 Ultra', 1993, 1, 1, 22000000, 30000000)
INSERT [dbo].[HangHoa] ([Id], [Ten], [SoLuong], [KhoId], [DanhMucId], [GiaNhap], [GiaBan]) VALUES (18, N'AppleIphone 12', 2998, 1, 1, 25000000, 32000000)
INSERT [dbo].[HangHoa] ([Id], [Ten], [SoLuong], [KhoId], [DanhMucId], [GiaNhap], [GiaBan]) VALUES (19, N'Điều hòa Panasonic P4000', 2994, 1, 2, 7500000, 8900000)
INSERT [dbo].[HangHoa] ([Id], [Ten], [SoLuong], [KhoId], [DanhMucId], [GiaNhap], [GiaBan]) VALUES (22, N'Pepsi zero calories 330ml', 5242, 3, 3, 7000, 9000)
INSERT [dbo].[HangHoa] ([Id], [Ten], [SoLuong], [KhoId], [DanhMucId], [GiaNhap], [GiaBan]) VALUES (23, N'CocaCola 330ml', 9993, 1, 3, 7000, 9000)
INSERT [dbo].[HangHoa] ([Id], [Ten], [SoLuong], [KhoId], [DanhMucId], [GiaNhap], [GiaBan]) VALUES (24, N'Xiaomi Mi9T', 6490, 1, 1, 6500000, 7900000)
INSERT [dbo].[HangHoa] ([Id], [Ten], [SoLuong], [KhoId], [DanhMucId], [GiaNhap], [GiaBan]) VALUES (28, N'sadfdfg', 0, 1, 4, 34, 123)
INSERT [dbo].[HangHoa] ([Id], [Ten], [SoLuong], [KhoId], [DanhMucId], [GiaNhap], [GiaBan]) VALUES (29, N'Snack Ngô Poca', 6542, 3, 3, 3500, 5000)
INSERT [dbo].[HangHoa] ([Id], [Ten], [SoLuong], [KhoId], [DanhMucId], [GiaNhap], [GiaBan]) VALUES (30, N'Tủ lạnh LG 400L', 5231, 2, 2, 25000000, 30000000)
SET IDENTITY_INSERT [dbo].[HangHoa] OFF
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (3, 17, N'SamsungGalaxy S21 Ultra', 1, 1, 1, 30000000, CAST(N'2021-04-01' AS Date), 8000000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (3, 18, N'AppleIphone 12', 1, 1, 1, 32000000, CAST(N'2021-04-01' AS Date), 7000000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (3, 19, N'Điều hòa Panasonic P4000', 1, 1, 2, 8900000, CAST(N'2021-04-01' AS Date), 1400000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (3, 22, N'Pepsi zero calories 330ml', 1, 3, 3, 9000, CAST(N'2021-04-01' AS Date), 2000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (3, 23, N'CocaCola 330ml', 1, 1, 3, 9000, CAST(N'2021-04-01' AS Date), 2000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (4, 17, N'SamsungGalaxy S21 Ultra', 1, 1, 1, 30000000, CAST(N'2021-04-01' AS Date), 8000000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (4, 19, N'Điều hòa Panasonic P4000', 1, 1, 2, 8900000, CAST(N'2021-04-01' AS Date), 1400000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (4, 23, N'CocaCola 330ml', 1, 1, 3, 9000, CAST(N'2021-04-01' AS Date), 2000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (5, 17, N'SamsungGalaxy S21 Ultra', 1, 1, 1, 30000000, CAST(N'2021-04-02' AS Date), 8000000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (6, 25, N'ád', 1, 1, 4, 234, CAST(N'2021-04-02' AS Date), 0)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (7, 22, N'Pepsi zero calories 330ml', 1, 3, 3, 9000, CAST(N'2021-04-02' AS Date), 2000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (7, 23, N'CocaCola 330ml', 1, 1, 3, 9000, CAST(N'2021-04-02' AS Date), 2000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (7, 24, N'Xiaomi Mi9T', 1, 1, 1, 7900000, CAST(N'2021-04-02' AS Date), 1400000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (7, 25, N'ád', 1, 1, 4, 234, CAST(N'2021-04-02' AS Date), 0)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (8, 17, N'SamsungGalaxy S21 Ultra', 1, 1, 1, 30000000, CAST(N'2021-04-02' AS Date), 8000000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (8, 19, N'Điều hòa Panasonic P4000', 1, 1, 2, 8900000, CAST(N'2021-04-02' AS Date), 1400000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (8, 22, N'Pepsi zero calories 330ml', 1, 3, 3, 9000, CAST(N'2021-04-02' AS Date), 2000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (8, 23, N'CocaCola 330ml', 1, 1, 3, 9000, CAST(N'2021-04-02' AS Date), 2000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (9, 23, N'CocaCola 330ml', 1, 1, 3, 9000, CAST(N'2021-04-02' AS Date), 2000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (10, 29, N'Snack Ngô Poca', 1, 3, 3, 5000, CAST(N'2021-04-02' AS Date), 1500)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (10, 30, N'Tủ lạnh LG 400L', 1, 2, 2, 30000000, CAST(N'2021-04-02' AS Date), 5000000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (10, 22, N'Pepsi zero calories 330ml', 1, 3, 3, 9000, CAST(N'2021-04-02' AS Date), 2000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (10, 24, N'Xiaomi Mi9T', 1, 1, 1, 7900000, CAST(N'2021-04-02' AS Date), 1400000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (11, 17, N'SamsungGalaxy S21 Ultra', 3, 1, 1, 30000000, CAST(N'2021-04-03' AS Date), 24000000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (11, 18, N'AppleIphone 12', 1, 1, 1, 32000000, CAST(N'2021-04-03' AS Date), 7000000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (11, 19, N'Điều hòa Panasonic P4000', 1, 1, 2, 8900000, CAST(N'2021-04-03' AS Date), 1400000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (11, 23, N'CocaCola 330ml', 1, 1, 3, 9000, CAST(N'2021-04-03' AS Date), 2000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (1, 17, N'SamsungGalaxy S21 Ultra', 1, 1, 2, 30000000, CAST(N'2021-03-31' AS Date), 8000000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (1, 18, N'AppleIphone 12', 1, 1, 1, 32000000, CAST(N'2021-03-31' AS Date), 7000000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (1, 19, N'Điều hòa Panasonic P4000', 1, 1, 3, 8900000, CAST(N'2021-03-31' AS Date), 1400000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (2, 19, N'Điều hòa Panasonic P4000', 2, 1, 3, 8900000, CAST(N'2021-03-31' AS Date), 2800000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (2, 22, N'Pepsi zero calories 330ml', 1, 3, 4, 9000, CAST(N'2021-03-31' AS Date), 2000)
INSERT [dbo].[HoaDon] ([HoaDonId], [HangHoaId], [TenMatHang], [SoLuong], [KhoId], [LoaiId], [GiaBan], [NgayBan], [Lai]) VALUES (2, 23, N'CocaCola 330ml', 1, 2, 4, 9000, CAST(N'2021-03-31' AS Date), 2000)
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([IdKhachHang], [IdHoaDon], [TenKhachHang], [NgayMua], [TongTien], [Lai]) VALUES (3, 1, N'Thanh', CAST(N'2021-03-31' AS Date), 70900000, 16400000)
INSERT [dbo].[KhachHang] ([IdKhachHang], [IdHoaDon], [TenKhachHang], [NgayMua], [TongTien], [Lai]) VALUES (4, 2, N'Long', CAST(N'2021-03-31' AS Date), 17818000, 2804000)
INSERT [dbo].[KhachHang] ([IdKhachHang], [IdHoaDon], [TenKhachHang], [NgayMua], [TongTien], [Lai]) VALUES (5, 3, N'KhachHangA', CAST(N'2021-04-01' AS Date), 70918000, 16404000)
INSERT [dbo].[KhachHang] ([IdKhachHang], [IdHoaDon], [TenKhachHang], [NgayMua], [TongTien], [Lai]) VALUES (6, 4, N'DonalTrump', CAST(N'2021-04-01' AS Date), 38909000, 9402000)
INSERT [dbo].[KhachHang] ([IdKhachHang], [IdHoaDon], [TenKhachHang], [NgayMua], [TongTien], [Lai]) VALUES (7, 6, N'dfgdf', CAST(N'2021-04-02' AS Date), 234, 0)
INSERT [dbo].[KhachHang] ([IdKhachHang], [IdHoaDon], [TenKhachHang], [NgayMua], [TongTien], [Lai]) VALUES (8, 7, N'Hoa', CAST(N'2021-04-02' AS Date), 7918234, 1404000)
INSERT [dbo].[KhachHang] ([IdKhachHang], [IdHoaDon], [TenKhachHang], [NgayMua], [TongTien], [Lai]) VALUES (9, 8, N'123', CAST(N'2021-04-02' AS Date), 38918000, 9404000)
INSERT [dbo].[KhachHang] ([IdKhachHang], [IdHoaDon], [TenKhachHang], [NgayMua], [TongTien], [Lai]) VALUES (10, 10, N'Anh Kien', CAST(N'2021-04-02' AS Date), 37914000, 6403500)
INSERT [dbo].[KhachHang] ([IdKhachHang], [IdHoaDon], [TenKhachHang], [NgayMua], [TongTien], [Lai]) VALUES (11, 11, N'Le', CAST(N'2021-04-03' AS Date), 130909000, 32402000)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[Kho] ON 

INSERT [dbo].[Kho] ([KhoId], [TenKho]) VALUES (1, N'Hà Nội')
INSERT [dbo].[Kho] ([KhoId], [TenKho]) VALUES (2, N'Hồ Chí Minh')
INSERT [dbo].[Kho] ([KhoId], [TenKho]) VALUES (3, N'Đà Nẵng')
SET IDENTITY_INSERT [dbo].[Kho] OFF
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([Id], [UserName], [Password], [Ten], [DiaChi], [CMND]) VALUES (1, N'admin', N'123', NULL, NULL, NULL)
INSERT [dbo].[TaiKhoan] ([Id], [UserName], [Password], [Ten], [DiaChi], [CMND]) VALUES (2, N'thanh', N'123', N'Nguyen Van Thanh', N'Dai Hoc FPT', N'026200000231')
INSERT [dbo].[TaiKhoan] ([Id], [UserName], [Password], [Ten], [DiaChi], [CMND]) VALUES (6, N'long', N'1234', N'Nguyen Thanh Long', N'Dai Hoc FPT', N'81270234123')
INSERT [dbo].[TaiKhoan] ([Id], [UserName], [Password], [Ten], [DiaChi], [CMND]) VALUES (12, N'haha', N'123', N'Le Van Ha', N'Dai Hoc FPT', N'8436529347134')
INSERT [dbo].[TaiKhoan] ([Id], [UserName], [Password], [Ten], [DiaChi], [CMND]) VALUES (14, N'asd', N'rjth', N'345', N'ert', N'ewwrwe')
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
USE [master]
GO
ALTER DATABASE [QLHH] SET  READ_WRITE 
GO
