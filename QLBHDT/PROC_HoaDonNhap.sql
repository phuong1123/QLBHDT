USE QLBHDT
GO
----

CREATE PROC sp_SelectHoaDonNhap
AS
BEGIN
	SELECT SoHDN, MaNhanVien, NgayNhap, MaNCC,  TongTien
	FROM HoaDonNhap
END
GO




-----
CREATE PROC sp_InsertHoaDonNhap
(	
	@SoHDN VARCHAR(10),
	@MaNhanVien VARCHAR(10),
	@NgayNhap DATETIME,
	@MaNCC VARCHAR(10),
	@TongTien INT
)
AS
BEGIN
	IF EXISTS (SELECT * FROM HoaDonNhap WHERE SoHDN = @SoHDN)
		BEGIN
			PRINT N'Số hóa đơn nhập đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO HoaDonNhap VALUES (@SoHDN, @MaNhanVien, @NgayNhap, @MaNCC, @TongTien)
		END	
END
GO



----

CREATE PROC sp_UpdateHoaDonNhap
(
	@SoHDN VARCHAR(10),
	@MaNhanVien VARCHAR(10),
	@NgayNhap DATETIME,
	@MaNCC VARCHAR(10),
	@TongTien INT
)
AS
BEGIN
	UPDATE HoaDonNhap
	SET MaNhanVien = @MaNhanVien,
		NgayNhap = @NgayNhap,
		MaNCC = @MaNCC,
		TongTien = @TongTien
	WHERE SoHDN = @SoHDN
END
GO



-----
USE QLBHDT
GO


CREATE PROC sp_DeleteHoaDonNhap
(	
	@SoHDN VARCHAR(10)
)
AS
BEGIN
	DELETE FROM HoaDonNhap WHERE SoHDN = @SoHDN
END
GO