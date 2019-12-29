USE QLBHDT
GO
----

CREATE PROC sp_SelectDonViTinh
AS
BEGIN
	SELECT MaDonVi, TenDonVi
	FROM DonViTinh
END
GO




-----
CREATE PROC sp_InsertDonViTinh
(	
	@MaDonVi VARCHAR(10),
	@TenDonVi NVARCHAR(100)	
)
AS
BEGIN
	IF EXISTS (SELECT * FROM DonViTinh WHERE MaDonVi = @MaDonVi)
		BEGIN
			PRINT N'Mã đơn vị đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO DonViTinh VALUES (@MaDonVi, @TenDonVi)
		END	
END
GO



----

CREATE PROC sp_UpdateDonViTinh
(	
	@MaDonVi VARCHAR(10),
	@TenDonVi NVARCHAR(100)
)
AS
BEGIN
	UPDATE DonViTinh
	SET TenDonVi = @TenDonVi
	WHERE MaDonVi = @MaDonVi 
END
GO



-----
USE QLBHDT
GO


CREATE PROC sp_DeleteDonViTinh
(	
	@MaDonVi VARCHAR(10)
)
AS
BEGIN
	DELETE FROM DonViTinh WHERE MaDonVi = @MaDonVi
END
GO