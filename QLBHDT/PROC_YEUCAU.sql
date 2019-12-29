USE QLBHDT
GO
---Cập nhật số lượng trong bảng DMhangHoa khi nhập và bán hàng
CREATE PROC sp_CapNhatSoLuong
(
	@MaHang VARCHAR(10)
)
AS
BEGIN
	DECLARE @SoLuongBan INT, @SoLuongNhap INT, @SoLuongTrongKho INT	
	
	SET @SoLuongNhap = (SELECT ChiTietHoaDonNhap.SoLuong 
						FROM  ChiTietHoaDonNhap INNER JOIN DanhMucHangHoa
						ON ChiTietHoaDonNhap.MaHang = DanhMucHangHoa.MaHang
						WHERE ChiTietHoaDonNhap.MaHang = @MaHang)

	SET @SoLuongBan = (SELECT ChiTietHoaDonBan.SoLuong 
						FROM  ChiTietHoaDonBan INNER JOIN DanhMucHangHoa
						ON ChiTietHoaDonBan.MaHang = DanhMucHangHoa.MaHang						
						WHERE ChiTietHoaDonBan.MaHang = @MaHang)
	
	SET @SoLuongTrongKho = @SoLuongNhap - @SoLuongBan;
	UPDATE DanhMucHangHoa
	SET SoLuong = SoLuong + @SoLuongTrongKho
	WHERE MaHang = @MaHang
END
GO


-- giá nhập trong bảng DMhanghoa được tự động cập nhật khi nhập hàng
-- giá bán bằng 110% giá nhập
CREATE PROC sp_CapNhatGiaNhapGiaBan
(
	@MaHang VARCHAR(10)
)
AS
BEGIN
	DECLARE @GiaNhap INT, @GiaBan INT
	
	SET @GiaNhap = (SELECT DonGiaNhap FROM  ChiTietHoaDonNhap WHERE MaHang = @MaHang)
	SET @GiaBan =  @GiaNhap * 110 / 100
	UPDATE DanhMucHangHoa
	SET DonGiaNhap = @GiaNhap,
		DonGiaBan = @GiaBan
	WHERE MaHang = @MaHang
END
GO

