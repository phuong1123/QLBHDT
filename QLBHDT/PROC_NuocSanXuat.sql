USE QLBHDT
GO
----

CREATE PROC sp_SelectNuocSanXuat
AS
BEGIN
	SELECT MaNuocSanXuat, TenNuocSanXuat
	FROM NuocSanXuat
END
GO




-----
CREATE PROC sp_InsertNuocSanXuat
(	
	@MaNuocSanXuat VARCHAR(10),
	@TenNuocSanXuat NVARCHAR(100)	
)
AS
BEGIN
	IF EXISTS (SELECT * FROM NuocSanXuat WHERE MaNuocSanXuat = @MaNuocSanXuat)
		BEGIN
			PRINT N'Mã nước sản xuất đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO NuocSanXuat VALUES (@MaNuocSanXuat, @TenNuocSanXuat)
		END	
END
GO



----

CREATE PROC sp_UpdateNuocSanXuat
(	
	@MaNuocSanXuat VARCHAR(10),
	@TenNuocSanXuat NVARCHAR(100)
)
AS
BEGIN
	UPDATE NuocSanXuat
	SET TenNuocSanXuat = @TenNuocSanXuat
	WHERE MaNuocSanXuat = @MaNuocSanXuat 
END
GO



-----



CREATE PROC sp_DeleteNuocSanXuat
(	
	@MaNuocSanXuat VARCHAR(10)
)
AS
BEGIN
	DELETE FROM NuocSanXuat WHERE MaNuocSanXuat = @MaNuocSanXuat
END
GO