USE QLBHDT
GO
----

CREATE PROC sp_SelectCaLam
AS
BEGIN
	SELECT MaCa, TenCa
	FROM CaLam
END
GO




-----
CREATE PROC sp_InsertCaLam
(	
	@MaCa VARCHAR(10),
	@TenCa NVARCHAR(100)	
)
AS
BEGIN
	IF EXISTS (SELECT * FROM CaLam WHERE MaCa = @MaCa)
		BEGIN
			PRINT N'Mã ca đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO CaLam VALUES (@MaCa, @TenCa)
		END	
END
GO



----

CREATE PROC sp_UpdateCaLam
(	
	@MaCa VARCHAR(10),
	@TenCa NVARCHAR(100)
)
AS
BEGIN
	UPDATE CaLam
	SET TenCa = @TenCa
	WHERE MaCa = @MaCa 
END
GO



-----
USE QLBHDT
GO


CREATE PROC sp_DeleteCaLam
(	
	@MaCa VARCHAR(10)
)
AS
BEGIN
	DELETE FROM CaLam WHERE MaCa = @MaCa
END
GO