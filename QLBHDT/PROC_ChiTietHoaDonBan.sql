USE QLBHDT
GO
----

CREATE PROC sp_SelectChiTietHoaDonBan
AS
BEGIN
	SELECT SoHDB, MaHang, SoLuong,DonGiaNhap, GiamGia, ThanhTien
	FROM ChiTietHoaDonBan
END
GO




-----
CREATE PROC sp_InsertChiTietHoaDonBan
(	
	@SoHDB VARCHAR(10),
	@MaHang VARCHAR(10),
	@SoLuong INT,
	@DonGiaNhap INT,
	@GiamGia INT,
	@ThanhTien INT
)
AS
BEGIN
	IF EXISTS (SELECT * FROM ChiTietHoaDonBan WHERE SoHDB = @SoHDB AND MaHang = @MaHang)
		BEGIN
			PRINT N'Số hóa đơn chứa mã hãng đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO ChiTietHoaDonBan VALUES (@SoHDB, @MaHang, @SoLuong, @DonGiaNhap, @GiamGia, @ThanhTien)
		END	
END
GO



----

CREATE PROC sp_UpdateChiTietHoaDonBan
(
	@SoHDB VARCHAR(10),
	@MaHang VARCHAR(10),
	@SoLuong INT,
	@DonGiaNhap INT,
	@GiamGia INT,
	@ThanhTien INT
)
AS
BEGIN
	UPDATE ChiTietHoaDonBan
	SET SoLuong = @SoLuong,
		DonGiaNhap = @DonGiaNhap,
		GiamGia = @GiamGia,
		ThanhTien = @ThanhTien
	WHERE SoHDB = @SoHDB AND MaHang = @MaHang
END
GO



-----
USE QLBHDT
GO


CREATE PROC sp_DeleteChiTietHoaDonBan
(	
	@SoHDB VARCHAR(10),
	@MaHang VARCHAR(10)
)
AS
BEGIN
	DELETE FROM ChiTietHoaDonBan WHERE SoHDB = @SoHDB AND MaHang = @MaHang
END
GO