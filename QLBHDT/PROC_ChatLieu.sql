USE QLBHDT
GO
----

CREATE PROC sp_SelectChatLieu
AS
BEGIN
	SELECT MaChatLieu, TenChatLieu
	FROM ChatLieu
END
GO




-----
CREATE PROC sp_InsertChatLieu
(	
	@MaChatLieu VARCHAR(10),
	@TenChatLieu NVARCHAR(100)	
)
AS
BEGIN
	IF EXISTS (SELECT * FROM ChatLieu WHERE MaChatLieu = @MaChatLieu)
		BEGIN
			PRINT N'Mã chất liệu đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO ChatLieu VALUES (@MaChatLieu, @TenChatLieu)
		END	
END
GO



----

CREATE PROC sp_UpdateChatLieu
(	
	@MaChatLieu VARCHAR(10),
	@TenChatLieu NVARCHAR(100)	
)
AS
BEGIN
	UPDATE ChatLieu
	SET TenChatLieu = @TenChatLieu
	WHERE MaChatLieu = @MaChatLieu 
END
GO



-----
USE QLBHDT
GO


CREATE PROC sp_DeleteChatLieu
(	
	@MaChatLieu VARCHAR(10)
)
AS
BEGIN
	DELETE FROM ChatLieu WHERE MaChatLieu = @MaChatLieu
END
GO