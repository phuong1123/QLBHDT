USE QLBHDT
GO
----

CREATE PROC sp_SelectHoaDonBan
AS
BEGIN
	SELECT SoHDB, MaNhanVien, NgayBan, MaKhach, TongTien
	FROM HoaDonBan
END
GO




-----
CREATE PROC sp_InsertHoaDonBan
(	
	@SoHDB VARCHAR(10),
	@MaNhanVien VARCHAR(10),
	@NgayBan DATETIME,
	@MaKhach VARCHAR(10),
	@TongTien INT
)
AS
BEGIN
	IF EXISTS (SELECT * FROM HoaDonBan WHERE SoHDB = @SoHDB)
		BEGIN
			PRINT N'Số hóa đơn bán đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO HoaDonBan VALUES (@SoHDB, @MaNhanVien, @NgayBan, @MaKhach, @TongTien)
		END	
END
GO



----

CREATE PROC sp_UpdateHoaDonBan
(
	@SoHDB VARCHAR(10),
	@MaNhanVien VARCHAR(10),
	@NgayBan DATETIME,
	@MaKhach VARCHAR(10),
	@TongTien INT
)
AS
BEGIN
	UPDATE HoaDonBan
	SET MaNhanVien = @MaNhanVien,
		NgayBan = @NgayBan,
		MaKhach = @MaKhach,
		TongTien = @TongTien
	WHERE SoHDB = @SoHDB
END
GO



-----

USE QLBHDT
GO

CREATE PROC sp_DeleteHoaDonBan
(	
	@SoHDB VARCHAR(10)
)
AS
BEGIN
	DELETE FROM HoaDonBan WHERE SoHDB = @SoHDB
END
GO