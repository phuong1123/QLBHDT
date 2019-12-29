USE QLBHDT
GO
----

CREATE PROC sp_SelectLoaiHang
AS
BEGIN
	SELECT MaLoai, MaNhom, TenLoai
	FROM LoaiHang
END
GO




-----
CREATE PROC sp_InsertLoaiHang
(	
	@MaLoai VARCHAR(10),
	@MaNhom VARCHAR(10),
	@TenLoai NVARCHAR(100)	
)
AS
BEGIN
	IF EXISTS (SELECT * FROM LoaiHang WHERE MaLoai = @MaLoai AND MaNhom = @MaNhom)
		BEGIN
			PRINT N'Mã loại hàng đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO LoaiHang VALUES (@MaLoai,@MaNhom, @TenLoai)
		END	
END
GO



----

CREATE PROC sp_UpdateLoaiHang
(	
	@MaLoai VARCHAR(10),
	@MaNhom VARCHAR(10),
	@TenLoai NVARCHAR(100)	
)
AS
BEGIN
	UPDATE LoaiHang
	SET TenLoai = @TenLoai
	WHERE MaLoai = @MaLoai AND MaNhom = @MaNhom
END
GO



-----
USE QLBHDT
GO


CREATE PROC sp_DeleteLoaiHang
(	
	@MaLoai VARCHAR(10)
)
AS
BEGIN
	DELETE FROM LoaiHang WHERE MaLoai = @MaLoai 
END
GO