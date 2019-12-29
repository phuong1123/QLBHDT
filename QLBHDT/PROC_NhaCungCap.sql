USE QLBHDT
GO
----

CREATE PROC sp_SelectNhaCungCap
AS
BEGIN
	SELECT MaNCC, TenNCC, DienThoai, DiaChi
	FROM NhaCungCap
END
GO




-----
CREATE PROC sp_InsertNhaCungCap
(	
	@MaNCC VARCHAR(10),
	@TenNCC NVARCHAR(100),
	@DienThoai NVARCHAR(30),
	@DiaChi NVARCHAR(200)
)
AS
BEGIN
	IF EXISTS (SELECT * FROM NhaCungCap WHERE MaNCC = @MaNCC)
		BEGIN
			PRINT N'Mã nhà cung cấp đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO NhaCungCap VALUES (@MaNCC, @TenNCC, @DienThoai,@DiaChi)
		END	
END
GO



----

CREATE PROC sp_UpdateNhaCungCap
(
	@MaNCC VARCHAR(10),
	@TenNCC NVARCHAR(100),
	@DienThoai NVARCHAR(30),
	@DiaChi NVARCHAR(200)
)
AS
BEGIN
	UPDATE NhaCungCap
	SET TenNCC = @TenNCC,
		DienThoai = @DienThoai,
		DiaChi= @DiaChi
	WHERE MaNCC = @MaNCC 
END
GO



-----



CREATE PROC sp_DeleteNhaCungCap
(	
	@MaNCC VARCHAR(10)
)
AS
BEGIN
	DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC
END
GO