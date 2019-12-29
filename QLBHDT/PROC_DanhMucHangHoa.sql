USE QLBHDT
GO
----

CREATE PROC sp_SelectDanhMucHangHoa
AS
BEGIN
	SELECT MaHang, TenHang, MaNhom, MaLoai, MaDonVi, MaChatLieu, MaNuocSanXuat,
			SoLuong, DonGiaNhap, DonGiaBan, ThoiGianBaoHanh, Anh, GhiChu
	FROM DanhMucHangHoa
END
GO




-----
CREATE PROC sp_InsertDanhMucHangHoa
(	
	@MaHang VARCHAR(10),
	@TenHang NVARCHAR(100),
	@MaNhom VARCHAR(10),
	@MaLoai VARCHAR(10),
	@MaDonVi VARCHAR(10),
	@MaChatLieu VARCHAR(10),
	@MaNuocSanXuat VARCHAR(10),
	@SoLuong INT,
	@DonGiaNhap INT,
	@DonGiaBan INT,
	@ThoiGianBaoHanh NVARCHAR(30),
	@Anh NVARCHAR(100),
	@GhiChu NVARCHAR(100)

)
AS
BEGIN
	IF EXISTS (SELECT * FROM DanhMucHangHoa WHERE MaHang = @MaHang)
		BEGIN
			PRINT N'Mã hàng hóa đã tồn tại!'
		END
	ELSE
		BEGIN
			INSERT INTO DanhMucHangHoa VALUES (@MaHang, @TenHang, @MaNhom, @MaLoai, @MaDonVi, @MaChatLieu, @MaNuocSanXuat,
												@SoLuong, @DonGiaNhap, @DonGiaBan, @ThoiGianBaoHanh, @Anh, @GhiChu)
		END	
END
GO



----

CREATE PROC sp_UpdateDanhMucHangHoa
(
	@MaHang VARCHAR(10),
	@TenHang NVARCHAR(100),
	@MaNhom VARCHAR(10),
	@MaLoai VARCHAR(10),
	@MaDonVi VARCHAR(10),
	@MaChatLieu VARCHAR(10),
	@MaNuocSanXuat VARCHAR(10),
	@SoLuong INT,
	@DonGiaNhap INT,
	@DonGiaBan INT,
	@ThoiGianBaoHanh NVARCHAR(30),
	@Anh NVARCHAR(100),
	@GhiChu NVARCHAR(100)
)
AS
BEGIN
	UPDATE DanhMucHangHoa
	SET TenHang = @TenHang,
		MaNhom = @MaNhom,
		MaLoai = @MaLoai,
		MaDonVi = @MaDonVi,
		MaChatLieu = @MaChatLieu,
		MaNuocSanXuat = @MaNuocSanXuat,
		SoLuong = @SoLuong,
		DonGiaNhap = @DonGiaNhap,
		DonGiaBan = @DonGiaBan,
		ThoiGianBaoHanh = @ThoiGianBaoHanh,
		Anh = @Anh,
		GhiChu = @GhiChu
	WHERE MaHang = @MaHang
END
GO



-----
USE QLBHDT
GO


CREATE PROC sp_DeleteDanhMucHangHoa
(	
	@MaHang VARCHAR(10)
)
AS
BEGIN
	DELETE FROM DanhMucHangHoa WHERE MaHang = @MaHang
END
GO