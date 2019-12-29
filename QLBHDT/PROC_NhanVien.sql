USE QLBHDT
GO
----

CREATE PROC sp_SelectNhanVien
AS
BEGIN
	SELECT MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DienThoai, DiaChi, MaCa, MaCongViec
	FROM NhanVien
END
GO




-----
CREATE PROC sp_InsertNhanVien
(	
	@MaNhanVien VARCHAR(10),
	@TenNhanVien NVARCHAR(100)	,
	@GioiTinh NVARCHAR(10),
	@NgaySinh DATETIME,
	@DienThoai NVARCHAR(30),
	@DiaChi NVARCHAR(200),
	@MaCa VARCHAR(10),
	@MaCongViec VARCHAR(10)
)
AS
BEGIN
	IF EXISTS (SELECT * FROM NhanVien WHERE MaNhanVien = @MaNhanVien)
		BEGIN
			PRINT N'Mã nhân viên đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO NhanVien VALUES (@MaNhanVien, @TenNhanVien, @GioiTinh, @NgaySinh, @DienThoai, @DiaChi, @MaCa, @MaCongViec)
		END	
END
GO



----

CREATE PROC sp_UpdateNhanVien
(	
	@MaNhanVien VARCHAR(10),
	@TenNhanVien NVARCHAR(100)	,
	@GioiTinh NVARCHAR(10),
	@NgaySinh DATETIME,
	@DienThoai NVARCHAR(30),
	@DiaChi NVARCHAR(200),
	@MaCa VARCHAR(10),
	@MaCongViec VARCHAR(10)
)
AS
BEGIN
	UPDATE NhanVien
	SET TenNhanVien = @TenNhanVien,
		GioiTinh = @GioiTinh,
		NgaySinh = @NgaySinh,
		DienThoai = @DienThoai,
		DiaChi = @DiaChi,
		MaCa = @MaCa,
		MaCongViec = @MaCongViec
	WHERE MaNhanVien = @MaNhanVien 
END
GO



-----
USE QLBHDT
GO


CREATE PROC sp_DeleteNhanVien
(	
	@MaNhanVien VARCHAR(10)
)
AS
BEGIN
	DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien
END
GO