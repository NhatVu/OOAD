USE QuanLyHoKhau
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Role_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[Role_Insert]
GO 
CREATE PROCEDURE [dbo].[Role_Insert]
@roleName  nvarchar
 AS 
 INSERT INTO Role([roleName]) VALUES(@roleName)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UserManagement_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[UserManagement_Insert]
GO 
CREATE PROCEDURE [dbo].[UserManagement_Insert]
@idRole  int=null,@email  varchar,@username  varchar,@password  varchar
 AS 
 INSERT INTO UserManagement([idRole],[email],[username],[password]) VALUES(@idRole,@email,@username,@password)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DanToc_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[DanToc_Insert]
GO 
CREATE PROCEDURE [dbo].[DanToc_Insert]
@tenDanToc  nvarchar=null
 AS 
 INSERT INTO DanToc([tenDanToc]) VALUES(@tenDanToc)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KhaiSinh_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[KhaiSinh_Insert]
GO 
CREATE PROCEDURE [dbo].[KhaiSinh_Insert]
@idDanToc  int=null,@hoTen  nvarchar=null,@ngaySinh  datetime=null,@gioiTinh  int=null,@queQuan  nvarchar=null,@quocTich  nvarchar=null,@idKhaiSinhCha  int=null,@idKhaiSinhMe  int=null,@noiDangKy  nvarchar=null,@ngayDangKy  datetime=null,@idNguoiLamDon  int=null,@idNguoiKy  int=null
 AS 
 INSERT INTO KhaiSinh([idDanToc],[hoTen],[ngaySinh],[gioiTinh],[queQuan],[quocTich],[idKhaiSinhCha],[idKhaiSinhMe],[noiDangKy],[ngayDangKy],[idNguoiLamDon],[idNguoiKy]) VALUES(@idDanToc,@hoTen,@ngaySinh,@gioiTinh,@queQuan,@quocTich,@idKhaiSinhCha,@idKhaiSinhMe,@noiDangKy,@ngayDangKy,@idNguoiLamDon,@idNguoiKy)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_Insert]
GO 
CREATE PROCEDURE [dbo].[CongDan_Insert]
@idKhaiSinh  int,@cmnd  int,@tonGiao  nvarchar=null,@ngheNghiep  nvarchar=null,@noiLamViec  nvarchar=null,@ngayCapCMND  datetime=null,@noiCap  nvarchar=null,@diaChiThuongTru  nvarchar=null,@trinhDoHocVan  nvarchar=null,@trinhDoChuyenMon  nvarchar=null,@trinhDoNgoaiNgu  nvarchar=null
 AS 
 INSERT INTO CongDan([idKhaiSinh],[cmnd],[tonGiao],[ngheNghiep],[noiLamViec],[ngayCapCMND],[noiCap],[diaChiThuongTru],[trinhDoHocVan],[trinhDoChuyenMon],[trinhDoNgoaiNgu]) VALUES(@idKhaiSinh,@cmnd,@tonGiao,@ngheNghiep,@noiLamViec,@ngayCapCMND,@noiCap,@diaChiThuongTru,@trinhDoHocVan,@trinhDoChuyenMon,@trinhDoNgoaiNgu)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TomTatBanThan_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TomTatBanThan_Insert]
GO 
CREATE PROCEDURE [dbo].[TomTatBanThan_Insert]
@idCongDan  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@choO  nvarchar=null,@ngheNghiep  nvarchar=null
 AS 
 INSERT INTO TomTatBanThan([idCongDan],[ngayBatDau],[ngayKetThuc],[choO],[ngheNghiep]) VALUES(@idCongDan,@ngayBatDau,@ngayKetThuc,@choO,@ngheNghiep)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TienAn_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TienAn_Insert]
GO 
CREATE PROCEDURE [dbo].[TienAn_Insert]
@idCongDan  int=null,@toiDanh  nvarchar=null,@hinhPhat  nvarchar=null,@ngayThang  datetime=null,@noiTuyenAn  nvarchar=null
 AS 
 INSERT INTO TienAn([idCongDan],[toiDanh],[hinhPhat],[ngayThang],[noiTuyenAn]) VALUES(@idCongDan,@toiDanh,@hinhPhat,@ngayThang,@noiTuyenAn)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VaiTroSoHoKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[VaiTroSoHoKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[VaiTroSoHoKhau_Insert]
@tenVaiTro  nvarchar=null
 AS 
 INSERT INTO VaiTroSoHoKhau([tenVaiTro]) VALUES(@tenVaiTro)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HoKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[HoKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[HoKhau_Insert]
@idChuHo  int=null
 AS 
 INSERT INTO HoKhau([idChuHo]) VALUES(@idChuHo)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChiTietHoKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChiTietHoKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[ChiTietHoKhau_Insert]
@idHoKhau  int=null,@idThanhVien  int=null,@idVaiTroSoHoKhau  int=null
 AS 
 INSERT INTO ChiTietHoKhau([idHoKhau],[idThanhVien],[idVaiTroSoHoKhau]) VALUES(@idHoKhau,@idThanhVien,@idVaiTroSoHoKhau)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamVang_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamVang_Insert]
GO 
CREATE PROCEDURE [dbo].[TamVang_Insert]
@idCongDan  int=null,@idTruongCongAn  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@lyDo  nvarchar=null,@diaChiDen  nvarchar=null,@ngayLamDon  datetime=null
 AS 
 INSERT INTO TamVang([idCongDan],[idTruongCongAn],[ngayBatDau],[ngayKetThuc],[lyDo],[diaChiDen],[ngayLamDon]) VALUES(@idCongDan,@idTruongCongAn,@ngayBatDau,@ngayKetThuc,@lyDo,@diaChiDen,@ngayLamDon)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChuyenKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChuyenKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[ChuyenKhau_Insert]
@idCongDan  int=null,@idHoKhauCu  int=null,@idHoKhauMoi  int=null
 AS 
 INSERT INTO ChuyenKhau([idCongDan],[idHoKhauCu],[idHoKhauMoi]) VALUES(@idCongDan,@idHoKhauCu,@idHoKhauMoi)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamTru_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamTru_Insert]
GO 
CREATE PROCEDURE [dbo].[TamTru_Insert]
@idCongDan  int=null,@idHoKhau  int=null,@idTienAn  int=null
 AS 
 INSERT INTO TamTru([idCongDan],[idHoKhau],[idTienAn]) VALUES(@idCongDan,@idHoKhau,@idTienAn)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Role_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[Role_UpdateById]
GO 
CREATE PROCEDURE [dbo].[Role_UpdateById]
@id  int,@roleName  nvarchar
 AS 
 UPDATE Role SET [roleName]=@roleName WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UserManagement_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[UserManagement_UpdateById]
GO 
CREATE PROCEDURE [dbo].[UserManagement_UpdateById]
@id  int,@idRole  int=null,@email  varchar,@username  varchar,@password  varchar
 AS 
 UPDATE UserManagement SET [idRole]=@idRole,[email]=@email,[username]=@username,[password]=@password WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DanToc_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[DanToc_UpdateById]
GO 
CREATE PROCEDURE [dbo].[DanToc_UpdateById]
@id  int,@tenDanToc  nvarchar=null
 AS 
 UPDATE DanToc SET [tenDanToc]=@tenDanToc WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KhaiSinh_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[KhaiSinh_UpdateById]
GO 
CREATE PROCEDURE [dbo].[KhaiSinh_UpdateById]
@id  int,@idDanToc  int=null,@hoTen  nvarchar=null,@ngaySinh  datetime=null,@gioiTinh  int=null,@queQuan  nvarchar=null,@quocTich  nvarchar=null,@idKhaiSinhCha  int=null,@idKhaiSinhMe  int=null,@noiDangKy  nvarchar=null,@ngayDangKy  datetime=null,@idNguoiLamDon  int=null,@idNguoiKy  int=null
 AS 
 UPDATE KhaiSinh SET [idDanToc]=@idDanToc,[hoTen]=@hoTen,[ngaySinh]=@ngaySinh,[gioiTinh]=@gioiTinh,[queQuan]=@queQuan,[quocTich]=@quocTich,[idKhaiSinhCha]=@idKhaiSinhCha,[idKhaiSinhMe]=@idKhaiSinhMe,[noiDangKy]=@noiDangKy,[ngayDangKy]=@ngayDangKy,[idNguoiLamDon]=@idNguoiLamDon,[idNguoiKy]=@idNguoiKy WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_UpdateById]
GO 
CREATE PROCEDURE [dbo].[CongDan_UpdateById]
@id  int,@idKhaiSinh  int,@cmnd  int,@tonGiao  nvarchar=null,@ngheNghiep  nvarchar=null,@noiLamViec  nvarchar=null,@ngayCapCMND  datetime=null,@noiCap  nvarchar=null,@diaChiThuongTru  nvarchar=null,@trinhDoHocVan  nvarchar=null,@trinhDoChuyenMon  nvarchar=null,@trinhDoNgoaiNgu  nvarchar=null
 AS 
 UPDATE CongDan SET [idKhaiSinh]=@idKhaiSinh,[cmnd]=@cmnd,[tonGiao]=@tonGiao,[ngheNghiep]=@ngheNghiep,[noiLamViec]=@noiLamViec,[ngayCapCMND]=@ngayCapCMND,[noiCap]=@noiCap,[diaChiThuongTru]=@diaChiThuongTru,[trinhDoHocVan]=@trinhDoHocVan,[trinhDoChuyenMon]=@trinhDoChuyenMon,[trinhDoNgoaiNgu]=@trinhDoNgoaiNgu WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TomTatBanThan_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TomTatBanThan_UpdateById]
GO 
CREATE PROCEDURE [dbo].[TomTatBanThan_UpdateById]
@id  int,@idCongDan  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@choO  nvarchar=null,@ngheNghiep  nvarchar=null
 AS 
 UPDATE TomTatBanThan SET [idCongDan]=@idCongDan,[ngayBatDau]=@ngayBatDau,[ngayKetThuc]=@ngayKetThuc,[choO]=@choO,[ngheNghiep]=@ngheNghiep WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TienAn_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TienAn_UpdateById]
GO 
CREATE PROCEDURE [dbo].[TienAn_UpdateById]
@id  int,@idCongDan  int=null,@toiDanh  nvarchar=null,@hinhPhat  nvarchar=null,@ngayThang  datetime=null,@noiTuyenAn  nvarchar=null
 AS 
 UPDATE TienAn SET [idCongDan]=@idCongDan,[toiDanh]=@toiDanh,[hinhPhat]=@hinhPhat,[ngayThang]=@ngayThang,[noiTuyenAn]=@noiTuyenAn WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VaiTroSoHoKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[VaiTroSoHoKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[VaiTroSoHoKhau_UpdateById]
@id  int,@tenVaiTro  nvarchar=null
 AS 
 UPDATE VaiTroSoHoKhau SET [tenVaiTro]=@tenVaiTro WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HoKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[HoKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[HoKhau_UpdateById]
@id  int,@idChuHo  int=null
 AS 
 UPDATE HoKhau SET [idChuHo]=@idChuHo WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChiTietHoKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChiTietHoKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[ChiTietHoKhau_UpdateById]
@id  int,@idHoKhau  int=null,@idThanhVien  int=null,@idVaiTroSoHoKhau  int=null
 AS 
 UPDATE ChiTietHoKhau SET [idHoKhau]=@idHoKhau,[idThanhVien]=@idThanhVien,[idVaiTroSoHoKhau]=@idVaiTroSoHoKhau WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamVang_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamVang_UpdateById]
GO 
CREATE PROCEDURE [dbo].[TamVang_UpdateById]
@id  int,@idCongDan  int=null,@idTruongCongAn  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@lyDo  nvarchar=null,@diaChiDen  nvarchar=null,@ngayLamDon  datetime=null
 AS 
 UPDATE TamVang SET [idCongDan]=@idCongDan,[idTruongCongAn]=@idTruongCongAn,[ngayBatDau]=@ngayBatDau,[ngayKetThuc]=@ngayKetThuc,[lyDo]=@lyDo,[diaChiDen]=@diaChiDen,[ngayLamDon]=@ngayLamDon WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChuyenKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChuyenKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[ChuyenKhau_UpdateById]
@id  int,@idCongDan  int=null,@idHoKhauCu  int=null,@idHoKhauMoi  int=null
 AS 
 UPDATE ChuyenKhau SET [idCongDan]=@idCongDan,[idHoKhauCu]=@idHoKhauCu,[idHoKhauMoi]=@idHoKhauMoi WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamTru_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamTru_UpdateById]
GO 
CREATE PROCEDURE [dbo].[TamTru_UpdateById]
@id  int,@idCongDan  int=null,@idHoKhau  int=null,@idTienAn  int=null
 AS 
 UPDATE TamTru SET [idCongDan]=@idCongDan,[idHoKhau]=@idHoKhau,[idTienAn]=@idTienAn WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Role_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[Role_DeleteById]
GO 
CREATE PROCEDURE [dbo].[Role_DeleteById]
@id  int

 AS 
 DELETE FROM Role WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UserManagement_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[UserManagement_DeleteById]
GO 
CREATE PROCEDURE [dbo].[UserManagement_DeleteById]
@id  int

 AS 
 DELETE FROM UserManagement WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DanToc_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[DanToc_DeleteById]
GO 
CREATE PROCEDURE [dbo].[DanToc_DeleteById]
@id  int

 AS 
 DELETE FROM DanToc WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KhaiSinh_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[KhaiSinh_DeleteById]
GO 
CREATE PROCEDURE [dbo].[KhaiSinh_DeleteById]
@id  int

 AS 
 DELETE FROM KhaiSinh WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_DeleteById]
GO 
CREATE PROCEDURE [dbo].[CongDan_DeleteById]
@id  int

 AS 
 DELETE FROM CongDan WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TomTatBanThan_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TomTatBanThan_DeleteById]
GO 
CREATE PROCEDURE [dbo].[TomTatBanThan_DeleteById]
@id  int

 AS 
 DELETE FROM TomTatBanThan WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TienAn_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TienAn_DeleteById]
GO 
CREATE PROCEDURE [dbo].[TienAn_DeleteById]
@id  int

 AS 
 DELETE FROM TienAn WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VaiTroSoHoKhau_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[VaiTroSoHoKhau_DeleteById]
GO 
CREATE PROCEDURE [dbo].[VaiTroSoHoKhau_DeleteById]
@id  int

 AS 
 DELETE FROM VaiTroSoHoKhau WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HoKhau_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[HoKhau_DeleteById]
GO 
CREATE PROCEDURE [dbo].[HoKhau_DeleteById]
@id  int

 AS 
 DELETE FROM HoKhau WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChiTietHoKhau_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChiTietHoKhau_DeleteById]
GO 
CREATE PROCEDURE [dbo].[ChiTietHoKhau_DeleteById]
@id  int

 AS 
 DELETE FROM ChiTietHoKhau WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamVang_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamVang_DeleteById]
GO 
CREATE PROCEDURE [dbo].[TamVang_DeleteById]
@id  int

 AS 
 DELETE FROM TamVang WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChuyenKhau_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChuyenKhau_DeleteById]
GO 
CREATE PROCEDURE [dbo].[ChuyenKhau_DeleteById]
@id  int

 AS 
 DELETE FROM ChuyenKhau WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamTru_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamTru_DeleteById]
GO 
CREATE PROCEDURE [dbo].[TamTru_DeleteById]
@id  int

 AS 
 DELETE FROM TamTru WHERE [id]=@id
GO 
