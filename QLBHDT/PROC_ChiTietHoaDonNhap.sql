USE QLBHDT
GO
----

CREATE PROC sp_SelectChiTietHoaDonNhap
AS
BEGIN
	SELECT SoHDN, MaHang, SoLuong, DonGiaNhap, GiamGia, ThanhTien
	FROM ChiTietHoaDonNhap
END
GO




-----
CREATE PROC sp_InsertChiTietHoaDonNhap
(	
	@SoHDN VARCHAR(10),
	@MaHang VARCHAR(10),
	@SoLuong INT,
	@DonGiaNhap INT,
	@GiamGia INT,
	@ThanhTien INT
)
AS
BEGIN
	IF EXISTS (SELECT * FROM ChiTietHoaDonNhap WHERE SoHDN = @SoHDN AND MaHang = @MaHang)
		BEGIN
			PRINT N'Số hóa đơn chứa mã hãng đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO ChiTietHoaDonNhap VALUES (@SoHDN, @MaHang, @SoLuong, @DonGiaNhap, @GiamGia, @ThanhTien)
		END	
END
GO



----

CREATE PROC sp_UpdateChiTietHoaDonNhap
(
	@SoHDN VARCHAR(10),
	@MaHang VARCHAR(10),
	@SoLuong INT,
	@DonGiaNhap INT,
	@GiamGia INT,
	@ThanhTien INT
)
AS
BEGIN
	UPDATE ChiTietHoaDonNhap
	SET SoLuong = @SoLuong,
		DonGiaNhap = @DonGiaNhap,
		GiamGia = @GiamGia,
		ThanhTien = @ThanhTien
	WHERE SoHDN = @SoHDN AND MaHang = @MaHang
END
GO



-----
USE QLBHDT
GO


CREATE PROC sp_DeleteChiTietHoaDonNhap
(	
	@SoHDN VARCHAR(10),
	@MaHang VARCHAR(10)
)
AS
BEGIN
	DELETE FROM ChiTietHoaDonNhap WHERE SoHDN = @SoHDN AND MaHang = @MaHang
END
GO