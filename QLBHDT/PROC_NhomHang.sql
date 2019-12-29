

USE QLBHDT
GO
----

CREATE PROC sp_SelectNhomHang
AS
BEGIN
	SELECT MaNhom, TenNhom, CongDung
	FROM NhomHang
END
GO




-----
CREATE PROC sp_InsertNhomHang
(	
	@MaNhom VARCHAR(10),
	@TenNhom NVARCHAR(100),
	@CongDung NVARCHAR(200)
	
)
AS
BEGIN
	IF EXISTS (SELECT * FROM NhomHang WHERE MaNhom = @MaNhom)
		BEGIN
			PRINT N'Mã nhom hang đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO NhomHang VALUES (@MaNhom, @TenNhom, @CongDung)
		END	
END
GO



----

CREATE PROC sp_UpdateNhomHang
(	
	@MaNhom VARCHAR(10),
	@TenNhom NVARCHAR(100),
	@CongDung NVARCHAR(200)
	
)
AS
BEGIN
	UPDATE NhomHang
	SET TenNhom = @TenNhom,
		CongDung = @CongDung
	WHERE MaNhom = @MaNhom
END
GO



-----
USE QLBHDT
GO


CREATE PROC sp_DeleteNhomHang
(	
	@MaNhom VARCHAR(10)
)
AS
BEGIN
	DELETE FROM NhomHang WHERE MaNhom = @MaNhom
END
GO

