USE QLBHDT
GO

CREATE TABLE Users(
	Id INT IDENTITY PRIMARY KEY,
	MaNhanVien VARCHAR(10) FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
	[Password] NVARCHAR(50),
	Active INT
)
GO

----------------

CREATE PROC sp_SelectUsers
AS
BEGIN
	SELECT MaNhanVien, [Password], Active
	FROM Users
END
GO



CREATE PROC sp_InsertUsers
(	
	@MaNhanVien VARCHAR(10),
	@Password NVARCHAR(50),
	@Active INT
)
AS
BEGIN
	IF EXISTS (SELECT * FROM Users WHERE MaNhanVien = @MaNhanVien AND [Password] = @Password)
		BEGIN
			PRINT N'Mã nhân viên đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO Users VALUES (@MaNhanVien, @Password, @Active)
		END	
END
GO



CREATE PROC sp_UpdateUsers
(
	@MaNhanVien VARCHAR(10),
	@Password NVARCHAR(50),
	@Active INT
)
AS
BEGIN
	UPDATE Users
	SET [Password] = @Password,
		Active = @Active
	WHERE MaNhanVien = @MaNhanVien
END
GO



CREATE PROC sp_DeleteUsers
(
	@MaNhanVien VARCHAR(10)
)
AS
BEGIN
	DELETE FROM Users	WHERE MaNhanVien = @MaNhanVien
END
GO


---
CREATE PROC sp_DangNhap
(
	@MaNhanVien VARCHAR(30),
	@Password NVARCHAR(50)
)
AS
BEGIN
	
END