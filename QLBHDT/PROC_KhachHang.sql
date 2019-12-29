USE QLBHDT
GO
----

CREATE PROC sp_SelectKhachHang
AS
BEGIN
	SELECT MaKhach, TenKhach, DienThoai, DiaChi
	FROM KhachHang
END
GO




-----
CREATE PROC sp_InsertKhachHang
(	
	@MaKhach VARCHAR(10),
	@TenKhach NVARCHAR(100)	,
	@DienThoai NVARCHAR(30),
	@DiaChi NVARCHAR(200)
)
AS
BEGIN
	IF EXISTS (SELECT * FROM KhachHang WHERE MaKhach = @MaKhach)
		BEGIN
			PRINT N'Mã khách hàng đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO KhachHang VALUES (@MaKhach, @TenKhach, @DienThoai,@DiaChi)
		END	
END
GO



----

CREATE PROC sp_UpdateKhachHang
(	
	@MaKhach VARCHAR(10),
	@TenKhach NVARCHAR(100)	,
	@DienThoai NVARCHAR(30),
	@DiaChi NVARCHAR(200)
)
AS
BEGIN
	UPDATE KhachHang
	SET TenKhach = @TenKhach,
		DienThoai = @DienThoai,
		DiaChi= @DiaChi
	WHERE MaKhach = @MaKhach 
END
GO



-----

USE QLBHDT
GO

CREATE PROC sp_DeleteKhachHang
(	
	@MaKhach VARCHAR(10)
)
AS
BEGIN
	DELETE FROM KhachHang WHERE MaKhach = @MaKhach
END
GO