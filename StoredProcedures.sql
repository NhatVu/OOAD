USE QuanLyHoKhau
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DanToc_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[DanToc_Insert]
GO 
CREATE PROCEDURE [dbo].[DanToc_Insert]
@tenDanToc  nvarchar(100)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 INSERT INTO DanToc([tenDanToc],[ghiChu],[active]) output INSERTED.ID VALUES(@tenDanToc,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_Insert]
GO 
CREATE PROCEDURE [dbo].[CongDan_Insert]
@idDanToc  int=null,@hoTen  nvarchar(100)=null,@ngaySinh  datetime=null,@gioiTinh  int=null,@queQuan  nvarchar(200)=null,@quocTich  nvarchar(200)=null,@noiDangKyKS  nvarchar(200)=null,@ngayDangKyKS  datetime=null,@idNguoiLamDonKS  int=null,@idCDNguoiKyKS  int=null,@cmnd  int=null,@tonGiao  nvarchar(100)=null,@ngheNghiep  nvarchar(200)=null,@noiLamViec  nvarchar(600)=null,@ngayCapCMND  datetime=null,@noiCap  nvarchar(200)=null,@diaChiThuongTru  nvarchar(600)=null,@trinhDoHocVan  nvarchar(60)=null,@trinhDoChuyenMon  nvarchar(200)=null,@trinhDoNgoaiNgu  nvarchar(200)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 INSERT INTO CongDan([idDanToc],[hoTen],[ngaySinh],[gioiTinh],[queQuan],[quocTich],[noiDangKyKS],[ngayDangKyKS],[idNguoiLamDonKS],[idCDNguoiKyKS],[cmnd],[tonGiao],[ngheNghiep],[noiLamViec],[ngayCapCMND],[noiCap],[diaChiThuongTru],[trinhDoHocVan],[trinhDoChuyenMon],[trinhDoNgoaiNgu],[ghiChu],[active]) output INSERTED.ID VALUES(@idDanToc,@hoTen,@ngaySinh,@gioiTinh,@queQuan,@quocTich,@noiDangKyKS,@ngayDangKyKS,@idNguoiLamDonKS,@idCDNguoiKyKS,@cmnd,@tonGiao,@ngheNghiep,@noiLamViec,@ngayCapCMND,@noiCap,@diaChiThuongTru,@trinhDoHocVan,@trinhDoChuyenMon,@trinhDoNgoaiNgu,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongAn_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongAn_Insert]
GO 
CREATE PROCEDURE [dbo].[CongAn_Insert]
@id  int,@email  varchar(50)=null,@username  varchar(20)=null,@password  varchar(500)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 INSERT INTO CongAn([id],[email],[username],[password],[ghiChu],[active]) output INSERTED.ID VALUES(@id,@email,@username,@password,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TomTatBanThan_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TomTatBanThan_Insert]
GO 
CREATE PROCEDURE [dbo].[TomTatBanThan_Insert]
@idCongDan  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@choO  nvarchar(200)=null,@ngheNghiep  nvarchar(200)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 INSERT INTO TomTatBanThan([idCongDan],[ngayBatDau],[ngayKetThuc],[choO],[ngheNghiep],[ghiChu],[active]) output INSERTED.ID VALUES(@idCongDan,@ngayBatDau,@ngayKetThuc,@choO,@ngheNghiep,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TienAn_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TienAn_Insert]
GO 
CREATE PROCEDURE [dbo].[TienAn_Insert]
@idCongDan  int=null,@toiDanh  nvarchar(600)=null,@hinhPhat  nvarchar(600)=null,@ngayThang  datetime=null,@noiTuyenAn  nvarchar(600)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 INSERT INTO TienAn([idCongDan],[toiDanh],[hinhPhat],[ngayThang],[noiTuyenAn],[ghiChu],[active]) output INSERTED.ID VALUES(@idCongDan,@toiDanh,@hinhPhat,@ngayThang,@noiTuyenAn,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VaiTroSoHoKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[VaiTroSoHoKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[VaiTroSoHoKhau_Insert]
@tenVaiTro  nvarchar(200)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 INSERT INTO VaiTroSoHoKhau([tenVaiTro],[ghiChu],[active]) output INSERTED.ID VALUES(@tenVaiTro,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HoKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[HoKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[HoKhau_Insert]
@idCDTruongCongAn  int=null,@noiCap  nvarchar(600)=null,@ngayCap  datetime=null,@noiDangKyThuongTru  nvarchar(600)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 INSERT INTO HoKhau([idCDTruongCongAn],[noiCap],[ngayCap],[noiDangKyThuongTru],[ghiChu],[active]) output INSERTED.ID VALUES(@idCDTruongCongAn,@noiCap,@ngayCap,@noiDangKyThuongTru,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChiTietHoKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChiTietHoKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[ChiTietHoKhau_Insert]
@idHoKhau  int=null,@idCDThanhVien  int=null,@idVaiTroSoHoKhau  int=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 INSERT INTO ChiTietHoKhau([idHoKhau],[idCDThanhVien],[idVaiTroSoHoKhau],[ghiChu],[active]) output INSERTED.ID VALUES(@idHoKhau,@idCDThanhVien,@idVaiTroSoHoKhau,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamVang_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamVang_Insert]
GO 
CREATE PROCEDURE [dbo].[TamVang_Insert]
@idCongDan  int=null,@idTruongCongAn  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@lyDo  nvarchar(600)=null,@diaChiDen  nvarchar(600)=null,@ngayLamDon  datetime=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 INSERT INTO TamVang([idCongDan],[idTruongCongAn],[ngayBatDau],[ngayKetThuc],[lyDo],[diaChiDen],[ngayLamDon],[ghiChu],[active]) output INSERTED.ID VALUES(@idCongDan,@idTruongCongAn,@ngayBatDau,@ngayKetThuc,@lyDo,@diaChiDen,@ngayLamDon,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChuyenKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChuyenKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[ChuyenKhau_Insert]
@idCongDan  int=null,@idHoKhauCu  int=null,@idHoKhauMoi  int=null,@lyDo  nvarchar(600)=null,@idVaiTroSoHoKhau  int=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 INSERT INTO ChuyenKhau([idCongDan],[idHoKhauCu],[idHoKhauMoi],[lyDo],[idVaiTroSoHoKhau],[ghiChu],[active]) output INSERTED.ID VALUES(@idCongDan,@idHoKhauCu,@idHoKhauMoi,@lyDo,@idVaiTroSoHoKhau,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamTru_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamTru_Insert]
GO 
CREATE PROCEDURE [dbo].[TamTru_Insert]
@idCongDan  int=null,@idTruongCongAn  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@lyDo  nvarchar(600)=null,@diaChiDen  nvarchar(600)=null,@ngayLamDon  datetime=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 INSERT INTO TamTru([idCongDan],[idTruongCongAn],[ngayBatDau],[ngayKetThuc],[lyDo],[diaChiDen],[ngayLamDon],[ghiChu],[active]) output INSERTED.ID VALUES(@idCongDan,@idTruongCongAn,@ngayBatDau,@ngayKetThuc,@lyDo,@diaChiDen,@ngayLamDon,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LichSuHoKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[LichSuHoKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[LichSuHoKhau_Insert]
@originalId  int=null,@hoTenTruongCongAn  nvarchar(200)=null,@hoTenThanhVien  nvarchar(200)=null,@vaiTro  nvarchar(200)=null,@thoiGianThayDoi  datetime=null
 AS 
 INSERT INTO LichSuHoKhau([originalId],[hoTenTruongCongAn],[hoTenThanhVien],[vaiTro],[thoiGianThayDoi]) output INSERTED.ID VALUES(@originalId,@hoTenTruongCongAn,@hoTenThanhVien,@vaiTro,@thoiGianThayDoi)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sysdiagrams_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[sysdiagrams_Insert]
GO 
CREATE PROCEDURE [dbo].[sysdiagrams_Insert]
@name  sysname,@principal_id  int,@version  int=null,@definition  image=null
 AS 
 INSERT INTO sysdiagrams([name],[principal_id],[version],[definition]) VALUES(@name,@principal_id,@version,@definition)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DanToc_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[DanToc_UpdateById]
GO 
CREATE PROCEDURE [dbo].[DanToc_UpdateById]
@id  int,@tenDanToc  nvarchar(100)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 UPDATE DanToc SET [tenDanToc]=@tenDanToc,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_UpdateById]
GO 
CREATE PROCEDURE [dbo].[CongDan_UpdateById]
@id  int,@idDanToc  int=null,@hoTen  nvarchar(100)=null,@ngaySinh  datetime=null,@gioiTinh  int=null,@queQuan  nvarchar(200)=null,@quocTich  nvarchar(200)=null,@noiDangKyKS  nvarchar(200)=null,@ngayDangKyKS  datetime=null,@idNguoiLamDonKS  int=null,@idCDNguoiKyKS  int=null,@cmnd  int=null,@tonGiao  nvarchar(100)=null,@ngheNghiep  nvarchar(200)=null,@noiLamViec  nvarchar(600)=null,@ngayCapCMND  datetime=null,@noiCap  nvarchar(200)=null,@diaChiThuongTru  nvarchar(600)=null,@trinhDoHocVan  nvarchar(60)=null,@trinhDoChuyenMon  nvarchar(200)=null,@trinhDoNgoaiNgu  nvarchar(200)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 UPDATE CongDan SET [idDanToc]=@idDanToc,[hoTen]=@hoTen,[ngaySinh]=@ngaySinh,[gioiTinh]=@gioiTinh,[queQuan]=@queQuan,[quocTich]=@quocTich,[noiDangKyKS]=@noiDangKyKS,[ngayDangKyKS]=@ngayDangKyKS,[idNguoiLamDonKS]=@idNguoiLamDonKS,[idCDNguoiKyKS]=@idCDNguoiKyKS,[cmnd]=@cmnd,[tonGiao]=@tonGiao,[ngheNghiep]=@ngheNghiep,[noiLamViec]=@noiLamViec,[ngayCapCMND]=@ngayCapCMND,[noiCap]=@noiCap,[diaChiThuongTru]=@diaChiThuongTru,[trinhDoHocVan]=@trinhDoHocVan,[trinhDoChuyenMon]=@trinhDoChuyenMon,[trinhDoNgoaiNgu]=@trinhDoNgoaiNgu,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongAn_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongAn_UpdateById]
GO 
CREATE PROCEDURE [dbo].[CongAn_UpdateById]
@id  int,@email  varchar(50)=null,@username  varchar(20)=null,@password  varchar(500)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 UPDATE CongAn SET [id]=@id,[email]=@email,[username]=@username,[password]=@password,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TomTatBanThan_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TomTatBanThan_UpdateById]
GO 
CREATE PROCEDURE [dbo].[TomTatBanThan_UpdateById]
@id  int,@idCongDan  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@choO  nvarchar(200)=null,@ngheNghiep  nvarchar(200)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 UPDATE TomTatBanThan SET [idCongDan]=@idCongDan,[ngayBatDau]=@ngayBatDau,[ngayKetThuc]=@ngayKetThuc,[choO]=@choO,[ngheNghiep]=@ngheNghiep,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TienAn_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TienAn_UpdateById]
GO 
CREATE PROCEDURE [dbo].[TienAn_UpdateById]
@id  int,@idCongDan  int=null,@toiDanh  nvarchar(600)=null,@hinhPhat  nvarchar(600)=null,@ngayThang  datetime=null,@noiTuyenAn  nvarchar(600)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 UPDATE TienAn SET [idCongDan]=@idCongDan,[toiDanh]=@toiDanh,[hinhPhat]=@hinhPhat,[ngayThang]=@ngayThang,[noiTuyenAn]=@noiTuyenAn,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VaiTroSoHoKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[VaiTroSoHoKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[VaiTroSoHoKhau_UpdateById]
@id  int,@tenVaiTro  nvarchar(200)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 UPDATE VaiTroSoHoKhau SET [tenVaiTro]=@tenVaiTro,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HoKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[HoKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[HoKhau_UpdateById]
@id  int,@idCDTruongCongAn  int=null,@noiCap  nvarchar(600)=null,@ngayCap  datetime=null,@noiDangKyThuongTru  nvarchar(600)=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 UPDATE HoKhau SET [idCDTruongCongAn]=@idCDTruongCongAn,[noiCap]=@noiCap,[ngayCap]=@ngayCap,[noiDangKyThuongTru]=@noiDangKyThuongTru,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChiTietHoKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChiTietHoKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[ChiTietHoKhau_UpdateById]
@id  int,@idHoKhau  int=null,@idCDThanhVien  int=null,@idVaiTroSoHoKhau  int=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 UPDATE ChiTietHoKhau SET [idHoKhau]=@idHoKhau,[idCDThanhVien]=@idCDThanhVien,[idVaiTroSoHoKhau]=@idVaiTroSoHoKhau,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamVang_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamVang_UpdateById]
GO 
CREATE PROCEDURE [dbo].[TamVang_UpdateById]
@id  int,@idCongDan  int=null,@idTruongCongAn  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@lyDo  nvarchar(600)=null,@diaChiDen  nvarchar(600)=null,@ngayLamDon  datetime=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 UPDATE TamVang SET [idCongDan]=@idCongDan,[idTruongCongAn]=@idTruongCongAn,[ngayBatDau]=@ngayBatDau,[ngayKetThuc]=@ngayKetThuc,[lyDo]=@lyDo,[diaChiDen]=@diaChiDen,[ngayLamDon]=@ngayLamDon,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChuyenKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChuyenKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[ChuyenKhau_UpdateById]
@id  int,@idCongDan  int=null,@idHoKhauCu  int=null,@idHoKhauMoi  int=null,@lyDo  nvarchar(600)=null,@idVaiTroSoHoKhau  int=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 UPDATE ChuyenKhau SET [idCongDan]=@idCongDan,[idHoKhauCu]=@idHoKhauCu,[idHoKhauMoi]=@idHoKhauMoi,[lyDo]=@lyDo,[idVaiTroSoHoKhau]=@idVaiTroSoHoKhau,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamTru_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamTru_UpdateById]
GO 
CREATE PROCEDURE [dbo].[TamTru_UpdateById]
@id  int,@idCongDan  int=null,@idTruongCongAn  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@lyDo  nvarchar(600)=null,@diaChiDen  nvarchar(600)=null,@ngayLamDon  datetime=null,@ghiChu  nvarchar(600)=null,@active  int=null
 AS 
 UPDATE TamTru SET [idCongDan]=@idCongDan,[idTruongCongAn]=@idTruongCongAn,[ngayBatDau]=@ngayBatDau,[ngayKetThuc]=@ngayKetThuc,[lyDo]=@lyDo,[diaChiDen]=@diaChiDen,[ngayLamDon]=@ngayLamDon,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LichSuHoKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[LichSuHoKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[LichSuHoKhau_UpdateById]
@id  int,@originalId  int=null,@hoTenTruongCongAn  nvarchar(200)=null,@hoTenThanhVien  nvarchar(200)=null,@vaiTro  nvarchar(200)=null,@thoiGianThayDoi  datetime=null
 AS 
 UPDATE LichSuHoKhau SET [originalId]=@originalId,[hoTenTruongCongAn]=@hoTenTruongCongAn,[hoTenThanhVien]=@hoTenThanhVien,[vaiTro]=@vaiTro,[thoiGianThayDoi]=@thoiGianThayDoi WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sysdiagrams_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[sysdiagrams_UpdateById]
GO 
CREATE PROCEDURE [dbo].[sysdiagrams_UpdateById]
@name  sysname,@principal_id  int,@diagram_id  int,@version  int=null,@definition  image=null
 AS 
 UPDATE sysdiagrams SET [name]=@name,[principal_id]=@principal_id,[version]=@version,[definition]=@definition WHERE [diagram_id]=@diagram_id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DanToc_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[DanToc_DeleteById]
GO 
CREATE PROCEDURE [dbo].[DanToc_DeleteById]
@id  int

 AS 
 DELETE FROM DanToc WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_DeleteById]
GO 
CREATE PROCEDURE [dbo].[CongDan_DeleteById]
@id  int

 AS 
 DELETE FROM CongDan WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongAn_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongAn_DeleteById]
GO 
CREATE PROCEDURE [dbo].[CongAn_DeleteById]
@id int
 AS 
 DELETE FROM CongAn WHERE [id]=@id
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
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LichSuHoKhau_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[LichSuHoKhau_DeleteById]
GO 
CREATE PROCEDURE [dbo].[LichSuHoKhau_DeleteById]
@id  int

 AS 
 DELETE FROM LichSuHoKhau WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sysdiagrams_DeleteById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[sysdiagrams_DeleteById]
GO 
CREATE PROCEDURE [dbo].[sysdiagrams_DeleteById]
@diagram_id  int

 AS 
 DELETE FROM sysdiagrams WHERE [diagram_id]=@diagram_id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DanToc_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[DanToc_SelectAll]
GO 
CREATE PROCEDURE [dbo].[DanToc_SelectAll]
AS 
 SELECT * FROM DanToc
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DanToc_SelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[DanToc_SelectById]
GO 
CREATE PROCEDURE [dbo].[DanToc_SelectById]
@id  int

 AS 
 SELECT * FROM DanToc WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_SelectAll]
GO 
CREATE PROCEDURE [dbo].[CongDan_SelectAll]
AS 
 SELECT * FROM CongDan
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_SelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_SelectById]
GO 
CREATE PROCEDURE [dbo].[CongDan_SelectById]
@id  int

 AS 
 SELECT * FROM CongDan WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongAn_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongAn_SelectAll]
GO 
CREATE PROCEDURE [dbo].[CongAn_SelectAll]
AS 
 SELECT * FROM CongAn
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongAn_SelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongAn_SelectById]
GO 
CREATE PROCEDURE [dbo].[CongAn_SelectById]
@id int
 AS 
 SELECT * FROM CongAn WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TomTatBanThan_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TomTatBanThan_SelectAll]
GO 
CREATE PROCEDURE [dbo].[TomTatBanThan_SelectAll]
AS 
 SELECT * FROM TomTatBanThan
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TomTatBanThan_SelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TomTatBanThan_SelectById]
GO 
CREATE PROCEDURE [dbo].[TomTatBanThan_SelectById]
@id  int

 AS 
 SELECT * FROM TomTatBanThan WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TienAn_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TienAn_SelectAll]
GO 
CREATE PROCEDURE [dbo].[TienAn_SelectAll]
AS 
 SELECT * FROM TienAn
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TienAn_SelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TienAn_SelectById]
GO 
CREATE PROCEDURE [dbo].[TienAn_SelectById]
@id  int

 AS 
 SELECT * FROM TienAn WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VaiTroSoHoKhau_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[VaiTroSoHoKhau_SelectAll]
GO 
CREATE PROCEDURE [dbo].[VaiTroSoHoKhau_SelectAll]
AS 
 SELECT * FROM VaiTroSoHoKhau
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VaiTroSoHoKhau_SelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[VaiTroSoHoKhau_SelectById]
GO 
CREATE PROCEDURE [dbo].[VaiTroSoHoKhau_SelectById]
@id  int

 AS 
 SELECT * FROM VaiTroSoHoKhau WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HoKhau_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[HoKhau_SelectAll]
GO 
CREATE PROCEDURE [dbo].[HoKhau_SelectAll]
AS 
 SELECT * FROM HoKhau
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HoKhau_SelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[HoKhau_SelectById]
GO 
CREATE PROCEDURE [dbo].[HoKhau_SelectById]
@id  int

 AS 
 SELECT * FROM HoKhau WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChiTietHoKhau_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChiTietHoKhau_SelectAll]
GO 
CREATE PROCEDURE [dbo].[ChiTietHoKhau_SelectAll]
AS 
 SELECT * FROM ChiTietHoKhau
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChiTietHoKhau_SelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChiTietHoKhau_SelectById]
GO 
CREATE PROCEDURE [dbo].[ChiTietHoKhau_SelectById]
@id  int

 AS 
 SELECT * FROM ChiTietHoKhau WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamVang_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamVang_SelectAll]
GO 
CREATE PROCEDURE [dbo].[TamVang_SelectAll]
AS 
 SELECT * FROM TamVang
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamVang_SelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamVang_SelectById]
GO 
CREATE PROCEDURE [dbo].[TamVang_SelectById]
@id  int

 AS 
 SELECT * FROM TamVang WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChuyenKhau_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChuyenKhau_SelectAll]
GO 
CREATE PROCEDURE [dbo].[ChuyenKhau_SelectAll]
AS 
 SELECT * FROM ChuyenKhau
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChuyenKhau_SelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChuyenKhau_SelectById]
GO 
CREATE PROCEDURE [dbo].[ChuyenKhau_SelectById]
@id  int

 AS 
 SELECT * FROM ChuyenKhau WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamTru_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamTru_SelectAll]
GO 
CREATE PROCEDURE [dbo].[TamTru_SelectAll]
AS 
 SELECT * FROM TamTru
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamTru_SelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamTru_SelectById]
GO 
CREATE PROCEDURE [dbo].[TamTru_SelectById]
@id  int

 AS 
 SELECT * FROM TamTru WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LichSuHoKhau_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[LichSuHoKhau_SelectAll]
GO 
CREATE PROCEDURE [dbo].[LichSuHoKhau_SelectAll]
AS 
 SELECT * FROM LichSuHoKhau
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LichSuHoKhau_SelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[LichSuHoKhau_SelectById]
GO 
CREATE PROCEDURE [dbo].[LichSuHoKhau_SelectById]
@id  int

 AS 
 SELECT * FROM LichSuHoKhau WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sysdiagrams_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[sysdiagrams_SelectAll]
GO 
CREATE PROCEDURE [dbo].[sysdiagrams_SelectAll]
AS 
 SELECT * FROM sysdiagrams
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sysdiagrams_SelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[sysdiagrams_SelectById]
GO 
CREATE PROCEDURE [dbo].[sysdiagrams_SelectById]
@diagram_id  int

 AS 
 SELECT * FROM sysdiagrams WHERE [diagram_id]=@diagram_id
GO 

-- -----------------------------------------------------------------------------------------------------------
-- get CongAn by email
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongAn_SelectByEmail]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongAn_SelectByEmail]
GO 
CREATE PROCEDURE [dbo].[CongAn_SelectByEmail]
@email  varchar(50)

 AS 
 SELECT * FROM CongAn WHERE [email]=@email
GO 

-- get Quan ly tam tru Info
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamTru_GetAllInfo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamTru_GetAllInfo]
GO 
create procedure [dbo].[TamTru_GetAllInfo]
as
select t.id, c.hoTen, c.ngaySinh, c.gioiTinh, c.diaChiThuongTru, c.cmnd,
t.ngayBatDau, t.ngayKetThuc, t.ghiChu
from TamTru as t inner join CongDan as c
	on t.idCongDan = c.id
where t.active = 1 and c.active = 1
go

-- get Quan ly tam vang Info
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamVang_GetAllInfo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamVang_GetAllInfo]
GO 
create procedure [dbo].[TamVang_GetAllInfo]
as
select t.id, c.hoTen, c.ngaySinh, c.gioiTinh, c.diaChiThuongTru, c.cmnd,
t.ngayBatDau, t.ngayKetThuc, t.ghiChu
from TamVang as t inner join CongDan as c
	on t.idCongDan = c.id
where t.active = 1 and c.active = 1
go

-- select CongDan Id that not in HoKhau
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_SelectIdNotInHoKhau]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_SelectIdNotInHoKhau] 
GO
create procedure [dbo].[CongDan_SelectIdNotInHoKhau] 
as
select *
from CongDan 
where id not in (select idCDThanhVien from ChiTietHoKhau)
go

-- select HoKhau info
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HoKhau_GetAllInfo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[HoKhau_GetAllInfo] 
GO
create procedure [dbo].[HoKhau_GetAllInfo] 
as
select h.id,  ca.hoTen as congAn, cd.hoTen as chuHo, h.noiDangKyThuongTru, h.noiCap,  h.ngayCap
from (HoKhau as h inner join ChiTietHoKhau as c
on h.id = c.idHoKhau) inner join CongDan as cd
on (cd.id = c.idCDThanhVien) inner join CongDan as ca
on ca.id = h.idCDTruongCongAn
where c.idVaiTroSoHoKhau = 1 and h.active = 1 and c.active = 1 and cd.active = 1 and ca.active = 1;
go

-- hoKhau serach (by id, cmnd, hoten)
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HoKhau_Search]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[HoKhau_Search] 
GO
create procedure [dbo].[HoKhau_Search] 
@idCD int=null, @cmnd int=null, @hoTenChuHo nvarchar(50)=null, @cmndCA int=null,@hoTenCongAn nvarchar(50)=null, @noiCap nvarchar(300) =null
as
select h.id,  ca.hoTen as congAn, cd.hoTen as chuHo, h.noiDangKyThuongTru, h.noiCap,  h.ngayCap
from (HoKhau as h inner join ChiTietHoKhau as c
on h.id = c.idHoKhau) inner join CongDan as cd
on (cd.id = c.idCDThanhVien) inner join CongDan as ca
on ca.id = h.idCDTruongCongAn
where c.idVaiTroSoHoKhau = 1 and h.active = 1 and c.active = 1 and cd.active = 1 and ca.active = 1
and( cd.id = @idCD or cd.cmnd=@cmnd or cd.hoTen like '%'+ isNull(@hoTenChuHo,'') +'%' or ca.hoTen like '%' + isNull(@hoTenCongAn,'') + '%' or ca.cmnd=@cmndCA or h.noiCap like '%'+ isNull(@noiCap,'') +'%');
go

-- exec HoKhau_Search null,null,N'Vũ Minh Cha',null,null,N'TP HCM'

-- TamTru search
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamTru_Search]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamTru_Search] 
GO
create procedure [dbo].[TamTru_Search] 
@idCD int =null, @cmnd int=null, @hoTen nvarchar(50)=null
as
select c.id, c.hoTen, c.ngaySinh, c.gioiTinh, c.diaChiThuongTru, c.cmnd,
t.ngayBatDau, t.ngayKetThuc, t.ghiChu
from TamTru as t inner join CongDan as c
	on t.idCongDan = c.id
where t.active = 1 and c.active = 1 and (t.idCongDan = @idCD or t.idCongDan in (select id from CongDan as c where c.cmnd = @cmnd or c.hoTen like '%'+ isNull(@hoTen,'') +'%'))
go

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamVang_Search]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamVang_Search] 
GO
create procedure [dbo].[TamVang_Search] 
@idCD int =null, @cmnd int=null, @hoTen nvarchar(50)=null
as
select c.id, c.hoTen, c.ngaySinh, c.gioiTinh, c.diaChiThuongTru, c.cmnd,
t.ngayBatDau, t.ngayKetThuc, t.ghiChu
from TamVang as t inner join CongDan as c
	on t.idCongDan = c.id
where t.active = 1 and c.active = 1
and (t.idCongDan = @idCD or t.idCongDan in (select id from CongDan as c where c.cmnd = @cmnd or c.hoTen like '%'+ isNull(@hoTen,'') +'%')) 
go

-- tổng số nhân khẩu, tổng hộ khẩu, số nữ, và trên 14 tuổi
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HoKhau_ThongKe]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[HoKhau_ThongKe]
GO 
create procedure [dbo].[HoKhau_ThongKe] 
@thang int=null,
@nam int=null,
@tongNhanKhau int out,
@tongHoKhau int out,
@tongNuGioi int out,
@tongTrenMuoiBonTuoi int out
as
begin 

select @tongNhanKhau=count(*)
from CongDan as c 
where c.active = 1

select @tongHoKhau=count(*)
from HoKhau as h
where h.active = 1

select @tongNuGioi=count(*)
from CongDan as c
where c.active = 1 and c.gioiTinh = 0

select @tongTrenMuoiBonTuoi = count(*)
from CongDan as c 
where c.active = 1 and (@nam - YEAR(c.ngaySinh) > 13)
end
go

/*declare @tongNhanKhau int;
declare @tongHoKhau int;
declare @tongNuGioi int;
declare @tongTrenMuoiBonTuoi int;
exec HoKhau_ThongKe 12,2016,@tongNhanKhau output, @tongHoKhau output, @tongNuGioi output, @tongTrenMuoiBonTuoi output
select @tongNhanKhau as TongNhanKhau, @tongHoKhau, @tongNuGioi, @tongTrenMuoiBonTuoi*/

-- thống kê tạm trú

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamTru_ThongKe]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamTru_ThongKe]
GO
create procedure [dbo].[TamTru_ThongKe]
@thang int,
@nam int,
@tong int out,
@tongNu int out,
@tongTrenMuoiBonTuoi int out
as
begin 
select @tong = count(*) 
from TamTru as t
where t.active = 1 and year(t.ngayLamDon) = @nam and MONTH(t.ngayLamDon) = @thang

select @tongNu = count(*) 
from TamTru as t inner join CongDan as c
on c.id = t.idCongDan
where t.active = 1 and year(t.ngayLamDon) = @nam and MONTH(t.ngayLamDon) = @thang and c.gioiTinh = 0

select @tongTrenMuoiBonTuoi = count(*) 
from TamTru as t inner join CongDan as c
on c.id = t.idCongDan
where t.active = 1 and year(t.ngayLamDon) = @nam and MONTH(t.ngayLamDon) = @thang and (@nam - year(c.ngaySinh) > 13)
end
go 

--declare @tong int;
--declare @tongNu int;
--declare @tongTrenMuoiBonTuoi int;
--exec TamVang_ThongKe 12, 2016, @tong output, @tongNu output, @tongTrenMuoiBonTuoi output
--select @tong, @tongNu, @tongTrenMuoiBonTuoi



-- thống kê tạm trú

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamVang_ThongKe]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamVang_ThongKe]
GO
create procedure [dbo].[TamVang_ThongKe]
@thang int,
@nam int,
@tong int out,
@tongNu int out,
@tongTrenMuoiBonTuoi int out
as
begin 
select @tong = count(*) 
from TamVang as t
where t.active = 1 and year(t.ngayLamDon) = @nam and MONTH(t.ngayLamDon) = @thang

select @tongNu = count(*) 
from TamVang as t inner join CongDan as c
on c.id = t.idCongDan
where t.active = 1 and year(t.ngayLamDon) = @nam and MONTH(t.ngayLamDon) = @thang and c.gioiTinh = 0

select @tongTrenMuoiBonTuoi = count(*) 
from TamVang as t inner join CongDan as c
on c.id = t.idCongDan
where t.active = 1 and year(t.ngayLamDon) = @nam and MONTH(t.ngayLamDon) = @thang and (@nam - year(c.ngaySinh) > 13)
end
go 

-- select ChiTietHoKhau by HoKhauID
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChiTietHoKhau_GetByHoKhauId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChiTietHoKhau_GetByHoKhauId]
GO
create procedure [dbo].[ChiTietHoKhau_GetByHoKhauId]
@hoKhauId int=null
as
begin 
select cd.id, cd.cmnd, cd.hoTen as name, cd.gioiTinh, cd.ngaySinh, vt.tenVaiTro as quanHe, c.ghiChu, c.id as chiTietHoKhauId
from (ChiTietHoKhau as c inner join CongDan as cd
on c.idCDThanhVien = cd.id) inner join VaiTroSoHoKhau as vt
on vt.id = c.idVaiTroSoHoKhau
where c.idHoKhau = @hoKhauId and c.active = 1;
end
go

-- select chitiethokhau by hokhauid
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChiTietHoKhau_SelectAllChiTietHoKhauByIdHoKhau]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChiTietHoKhau_SelectAllChiTietHoKhauByIdHoKhau]
GO
create procedure [dbo].[ChiTietHoKhau_SelectAllChiTietHoKhauByIdHoKhau]
@hoKhauId int=null
as
begin
select * 
from ChiTietHoKhau as c
where c.idHoKhau = @hoKhauId and c.active = 1;
end
go

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TienAn_SelectTienAnByCongDanId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TienAn_SelectTienAnByCongDanId]
GO
create procedure [dbo].[TienAn_SelectTienAnByCongDanId]
@idCongDan int=null
as
begin
select * 
from TienAn as c
where c.idCongDan = @idCongDan and c.active = 1;
end
go

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TomTatBanThan_SelectTomTatBanThanByCongDanId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TomTatBanThan_SelectTomTatBanThanByCongDanId]
GO
create procedure [dbo].[TomTatBanThan_SelectTomTatBanThanByCongDanId]
@idCongDan int=null
as
begin
select * 
from TomTatBanThan as c
where c.idCongDan = @idCongDan and c.active = 1;
end
go


if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_SelectByName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_SelectByName]
GO 
CREATE PROCEDURE [dbo].[CongDan_SelectByName]
@hoTen nvarchar(50)

 AS 
 SELECT * FROM CongDan WHERE [hoTen]=@hoTen
GO 

----
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_SelectByCmnd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_SelectByCmnd]
GO 
CREATE PROCEDURE [dbo].[CongDan_SelectByCmnd]
@cmnd int

 AS 
 SELECT * FROM CongDan WHERE [cmnd]=@cmnd
GO 
----
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChiTietHoKhau_DeactiveByCongDanIdAndHoKhauId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChiTietHoKhau_DeactiveByCongDanIdAndHoKhauId]
GO 
CREATE PROCEDURE [dbo].[ChiTietHoKhau_DeactiveByCongDanIdAndHoKhauId]
@hoKhauId int=null,
@congDanId int = null
as
begin
update ChiTietHoKhau 
set active = 0
where idHoKhau = @hoKhauId and idCDThanhVien = @congDanId and active = 1;
end
go

