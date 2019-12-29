USE QLBHDT
GO
----

CREATE PROC sp_SelectCongViec
AS
BEGIN
	SELECT MaCongViec, TenCongViec
	FROM CongViec
END
GO




-----
CREATE PROC sp_InsertCongViec
(	
	@MaCongViec VARCHAR(10),
	@TenCongViec NVARCHAR(100)	
)
AS
BEGIN
	IF EXISTS (SELECT * FROM CongViec WHERE MaCongViec = @MaCongViec)
		BEGIN
			PRINT N'Mã công việc đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO CongViec VALUES (@MaCongViec, @TenCongViec)
		END	
END
GO



----

CREATE PROC sp_UpdateCongViec
(	
	@MaCongViec VARCHAR(10),
	@TenCongViec NVARCHAR(100)	
)
AS
BEGIN
	UPDATE CongViec
	SET TenCongViec = @TenCongViec
	WHERE MaCongViec = @MaCongViec 
END
GO



-----
USE QLBHDT
GO


CREATE PROC sp_DeleteCongViec
(	
	@MaCongViec VARCHAR(10)
)
AS
BEGIN
	DELETE FROM CongViec WHERE MaCongViec = @MaCongViec
END
GO