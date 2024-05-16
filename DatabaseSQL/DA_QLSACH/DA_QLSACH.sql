CREATE DATABASE [DA_QLSACH] COLLATE SQL_Latin1_General_CP1_CI_AS
GO
RAISERROR(N'Create Stored Procedure [dbo].[proc_dangnhap]', 0, 1) WITH NOWAIT;
GO
CREATE PROCEDURE [dbo].[proc_dangnhap]
@user VARCHAR (50), @pass VARCHAR (30)
WITH EXECUTE AS CALLER
AS
begin
	select * from NhanVien where NhanVien.UsernameNV = @user and NhanVien.PasswordNV = @pass
end
GO
RAISERROR(N'Create Table [dbo].[HoaDon]', 0, 1) WITH NOWAIT;
GO
CREATE TABLE [dbo].[HoaDon] (
    [MaHD]        INT             IDENTITY (1, 1) NOT NULL,
    [MaNV]        INT             NULL,
    [MaKH]        INT             NULL,
    [NgayTao_HD]  DATETIME        NULL,
    [TongTien_HD] DECIMAL (18, 0) NULL,
    [TrangThai]   INT             NULL,
    CONSTRAINT [PK__HoaDon__2725A6E00DAF0CB0] PRIMARY KEY CLUSTERED ([MaHD]) WITH (IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF)
)
GO
RAISERROR(N'Create Table [dbo].[KhachHang]', 0, 1) WITH NOWAIT;
GO
CREATE TABLE [dbo].[KhachHang] (
    [MaKH]        INT            IDENTITY (1, 1) NOT NULL,
    [TenKH]       NVARCHAR (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [SDT_KH]      VARCHAR (12)   COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [NgayTaoKH]   DATETIME       NULL,
    [TrangThaiKH] INT            NULL,
    CONSTRAINT [PK__KhachHan__2725CF1E060DEAE8] PRIMARY KEY CLUSTERED ([MaKH]) WITH (IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF)
)
GO
RAISERROR(N'Create Table [dbo].[NhanVien]', 0, 1) WITH NOWAIT;
GO
CREATE TABLE [dbo].[NhanVien] (
    [MaNV]        INT            IDENTITY (1, 1) NOT NULL,
    [TenNV]       NVARCHAR (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [UsernameNV]  VARCHAR (50)   COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [PasswordNV]  VARCHAR (30)   COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Quyen]       INT            NULL,
    [TrangThaiNV] INT            NULL,
    [NgayTaoNV]   DATETIME       NULL,
    CONSTRAINT [UQ__NhanVien__15DC503D023D5A04] UNIQUE NONCLUSTERED ([UsernameNV]) WITH (IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF),
    CONSTRAINT [PK__NhanVien__2725D70A7F60ED59] PRIMARY KEY CLUSTERED ([MaNV]) WITH (IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF)
)
GO
RAISERROR(N'Create Table [dbo].[PhieuNhap]', 0, 1) WITH NOWAIT;
GO
CREATE TABLE [dbo].[PhieuNhap] (
    [MaPN]        INT             IDENTITY (1, 1) NOT NULL,
    [MaNCC]       INT             NULL,
    [MaNV]        INT             NULL,
    [NgayTao_PN]  DATETIME        NULL,
    [TongTien_PN] DECIMAL (18, 0) NULL,
    [TrangThai]   INT             NULL,
    CONSTRAINT [PK__PhieuNha__2725E7F01920BF5C] PRIMARY KEY CLUSTERED ([MaPN]) WITH (IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF)
)
GO
RAISERROR(N'Create Table [dbo].[TheLoai]', 0, 1) WITH NOWAIT;
GO
CREATE TABLE [dbo].[TheLoai] (
    [MaTL]  INT            IDENTITY (1, 1) NOT NULL,
    [TenTL] NVARCHAR (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    CONSTRAINT [PK__TheLoai__2725007120C1E124] PRIMARY KEY CLUSTERED ([MaTL]) WITH (IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF)
)
GO
RAISERROR(N'Create Table [dbo].[CTPhieuNhap]', 0, 1) WITH NOWAIT;
GO
CREATE TABLE [dbo].[CTPhieuNhap] (
    [Ma_CTPN]     INT             IDENTITY (1, 1) NOT NULL,
    [MaPN]        INT             NULL,
    [MaSach]      INT             NULL,
    [SoLuongNhap] INT             NULL,
    [DonGiaNhap]  DECIMAL (18, 0) NULL,
    [ThanhTien]   DECIMAL (18, 0) NULL,
    CONSTRAINT [PK__CTPhieuN__3FEC89221CF15040] PRIMARY KEY CLUSTERED ([Ma_CTPN]) WITH (IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF)
)
GO
RAISERROR(N'Create Table [dbo].[NhaCungCap]', 0, 1) WITH NOWAIT;
GO
CREATE TABLE [dbo].[NhaCungCap] (
    [MaNCC]         INT            IDENTITY (1, 1) NOT NULL,
    [TenNCC]        NVARCHAR (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [DiaChiNCC]     NVARCHAR (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [SDT_NCC]       VARCHAR (12)   COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Email_NCC]     VARCHAR (50)   COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [NgayTao_NCC]   DATETIME       NULL,
    [TrangThai_NCC] INT            NULL,
    CONSTRAINT [PK__NhaCungC__3A185DEB15502E78] PRIMARY KEY CLUSTERED ([MaNCC]) WITH (IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF)
)
GO
RAISERROR(N'Create Table [dbo].[CTHoaDon]', 0, 1) WITH NOWAIT;
GO
CREATE TABLE [dbo].[CTHoaDon] (
    [MA_CTHD]     INT             IDENTITY (1, 1) NOT NULL,
    [MaHD]        INT             NULL,
    [MaSach]      INT             NULL,
    [SoLuong]     INT             NULL,
    [DonGia]      DECIMAL (18, 0) NULL,
    [ThanhTienSP] DECIMAL (18, 0) NULL,
    CONSTRAINT [PK__CTHoaDon__B74B6E15117F9D94] PRIMARY KEY CLUSTERED ([MA_CTHD]) WITH (IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF)
)
GO
RAISERROR(N'Create Trigger [dbo].[CTHoaDon].[KiemTraSoLuongSachTruocKhiThemHD]', 0, 1) WITH NOWAIT;
GO
CREATE TRIGGER [dbo].[KiemTraSoLuongSachTruocKhiThemHD]
    ON [dbo].[CTHoaDon]
    WITH EXECUTE AS CALLER
    AFTER INSERT
    AS BEGIN
    SET NOCOUNT ON;

    DECLARE @SoLuong INT, @MaSach INT

    SELECT @SoLuong = SoLuong, @MaSach = MaSach
    FROM inserted

    IF @SoLuong > (SELECT SoLuong FROM Sach WHERE MaSach = @MaSach)
    BEGIN
        ROLLBACK;
        RAISERROR ('Số lượng sách không đủ', 16, 1);
    END
END
GO
RAISERROR(N'Create Trigger [dbo].[CTHoaDon].[CapNhatTongTienHD]', 0, 1) WITH NOWAIT;
GO
CREATE TRIGGER [dbo].[CapNhatTongTienHD]
    ON [dbo].[CTHoaDon]
    WITH EXECUTE AS CALLER
    AFTER INSERT
    AS BEGIN
    UPDATE HoaDon
    SET TongTien_HD = (SELECT SUM(ThanhTienSP) FROM inserted WHERE MaHD = HoaDon.MaHD)
    FROM HoaDon
    INNER JOIN inserted ON HoaDon.MaHD = inserted.MaHD
END
GO
RAISERROR(N'Create Table [dbo].[Sach]', 0, 1) WITH NOWAIT;
GO
CREATE TABLE [dbo].[Sach] (
    [MaSach]         INT             IDENTITY (1, 1) NOT NULL,
    [TenSach]        NVARCHAR (255)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [TenTacGia]      NVARCHAR (255)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [TenTheLoai]     NVARCHAR (255)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [HinhAnh]        NVARCHAR (225)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [SoLuong]        INT             NULL,
    [GiaBan]         DECIMAL (18, 0) NULL,
    [TrangThai_Sach] INT             NULL,
    [NgayXuatBan]    DATETIME        NULL,
    CONSTRAINT [PK__Sach__B235742D09DE7BCC] PRIMARY KEY CLUSTERED ([MaSach]) WITH (IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF)
)
GO
RAISERROR(N'Create Table [dbo].[TacGia]', 0, 1) WITH NOWAIT;
GO
CREATE TABLE [dbo].[TacGia] (
    [MaTG]  INT            IDENTITY (1, 1) NOT NULL,
    [TenTG] NVARCHAR (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [MoTa]  NVARCHAR (MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    CONSTRAINT [PK__TacGia__2725007424927208] PRIMARY KEY CLUSTERED ([MaTG]) WITH (IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF)
)
GO
