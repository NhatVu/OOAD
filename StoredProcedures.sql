USE QuanLyHoKhau
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DanToc_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[DanToc_Insert]
GO 
CREATE PROCEDURE [dbo].[DanToc_Insert]
@tenDanToc  nvarchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 INSERT INTO DanToc([tenDanToc],[ghiChu],[active]) VALUES(@tenDanToc,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_Insert]
GO 
CREATE PROCEDURE [dbo].[CongDan_Insert]
@idDanToc  int=null,@hoTen  nvarchar=null,@ngaySinh  datetime=null,@gioiTinh  int=null,@queQuan  nvarchar=null,@quocTich  nvarchar=null,@idCDCha  int=null,@idCDMe  int=null,@noiDangKyKS  nvarchar=null,@ngayDangKyKS  datetime=null,@idNguoiLamDonKS  int=null,@idCDNguoiKyKS  int=null,@cmnd  int=null,@tonGiao  nvarchar=null,@ngheNghiep  nvarchar=null,@noiLamViec  nvarchar=null,@ngayCapCMND  datetime=null,@noiCap  nvarchar=null,@diaChiThuongTru  nvarchar=null,@trinhDoHocVan  nvarchar=null,@trinhDoChuyenMon  nvarchar=null,@trinhDoNgoaiNgu  nvarchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 INSERT INTO CongDan([idDanToc],[hoTen],[ngaySinh],[gioiTinh],[queQuan],[quocTich],[idCDCha],[idCDMe],[noiDangKyKS],[ngayDangKyKS],[idNguoiLamDonKS],[idCDNguoiKyKS],[cmnd],[tonGiao],[ngheNghiep],[noiLamViec],[ngayCapCMND],[noiCap],[diaChiThuongTru],[trinhDoHocVan],[trinhDoChuyenMon],[trinhDoNgoaiNgu],[ghiChu],[active]) VALUES(@idDanToc,@hoTen,@ngaySinh,@gioiTinh,@queQuan,@quocTich,@idCDCha,@idCDMe,@noiDangKyKS,@ngayDangKyKS,@idNguoiLamDonKS,@idCDNguoiKyKS,@cmnd,@tonGiao,@ngheNghiep,@noiLamViec,@ngayCapCMND,@noiCap,@diaChiThuongTru,@trinhDoHocVan,@trinhDoChuyenMon,@trinhDoNgoaiNgu,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongAn_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongAn_Insert]
GO 
CREATE PROCEDURE [dbo].[CongAn_Insert]
@id  int,@email  varchar=null,@username  varchar=null,@password  varchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 INSERT INTO CongAn([id],[email],[username],[password],[ghiChu],[active]) VALUES(@id,@email,@username,@password,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TomTatBanThan_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TomTatBanThan_Insert]
GO 
CREATE PROCEDURE [dbo].[TomTatBanThan_Insert]
@idCongDan  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@choO  nvarchar=null,@ngheNghiep  nvarchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 INSERT INTO TomTatBanThan([idCongDan],[ngayBatDau],[ngayKetThuc],[choO],[ngheNghiep],[ghiChu],[active]) VALUES(@idCongDan,@ngayBatDau,@ngayKetThuc,@choO,@ngheNghiep,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TienAn_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TienAn_Insert]
GO 
CREATE PROCEDURE [dbo].[TienAn_Insert]
@idCongDan  int=null,@toiDanh  nvarchar=null,@hinhPhat  nvarchar=null,@ngayThang  datetime=null,@noiTuyenAn  nvarchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 INSERT INTO TienAn([idCongDan],[toiDanh],[hinhPhat],[ngayThang],[noiTuyenAn],[ghiChu],[active]) VALUES(@idCongDan,@toiDanh,@hinhPhat,@ngayThang,@noiTuyenAn,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VaiTroSoHoKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[VaiTroSoHoKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[VaiTroSoHoKhau_Insert]
@tenVaiTro  nvarchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 INSERT INTO VaiTroSoHoKhau([tenVaiTro],[ghiChu],[active]) VALUES(@tenVaiTro,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HoKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[HoKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[HoKhau_Insert]
@idCDTruongCongAn  int=null,@noiCap  nvarchar=null,@ngayCap  datetime=null,@noiDangKyThuongTru  nvarchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 INSERT INTO HoKhau([idCDTruongCongAn],[noiCap],[ngayCap],[noiDangKyThuongTru],[ghiChu],[active]) VALUES(@idCDTruongCongAn,@noiCap,@ngayCap,@noiDangKyThuongTru,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChiTietHoKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChiTietHoKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[ChiTietHoKhau_Insert]
@idHoKhau  int=null,@idCDThanhVien  int=null,@idVaiTroSoHoKhau  int=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 INSERT INTO ChiTietHoKhau([idHoKhau],[idCDThanhVien],[idVaiTroSoHoKhau],[ghiChu],[active]) VALUES(@idHoKhau,@idCDThanhVien,@idVaiTroSoHoKhau,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamVang_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamVang_Insert]
GO 
CREATE PROCEDURE [dbo].[TamVang_Insert]
@idCongDan  int=null,@idTruongCongAn  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@lyDo  nvarchar=null,@diaChiDen  nvarchar=null,@ngayLamDon  datetime=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 INSERT INTO TamVang([idCongDan],[idTruongCongAn],[ngayBatDau],[ngayKetThuc],[lyDo],[diaChiDen],[ngayLamDon],[ghiChu],[active]) VALUES(@idCongDan,@idTruongCongAn,@ngayBatDau,@ngayKetThuc,@lyDo,@diaChiDen,@ngayLamDon,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChuyenKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChuyenKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[ChuyenKhau_Insert]
@idCongDan  int=null,@idHoKhauCu  int=null,@idHoKhauMoi  int=null,@lyDo  nvarchar=null,@idVaiTroSoHoKhau  int=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 INSERT INTO ChuyenKhau([idCongDan],[idHoKhauCu],[idHoKhauMoi],[lyDo],[idVaiTroSoHoKhau],[ghiChu],[active]) VALUES(@idCongDan,@idHoKhauCu,@idHoKhauMoi,@lyDo,@idVaiTroSoHoKhau,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamTru_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamTru_Insert]
GO 
CREATE PROCEDURE [dbo].[TamTru_Insert]
@idCongDan  int=null,@idTruongCongAn  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@lyDo  nvarchar=null,@diaChiDen  nvarchar=null,@ngayLamDon  datetime=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 INSERT INTO TamTru([idCongDan],[idTruongCongAn],[ngayBatDau],[ngayKetThuc],[lyDo],[diaChiDen],[ngayLamDon],[ghiChu],[active]) VALUES(@idCongDan,@idTruongCongAn,@ngayBatDau,@ngayKetThuc,@lyDo,@diaChiDen,@ngayLamDon,@ghiChu,@active)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LichSuHoKhau_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[LichSuHoKhau_Insert]
GO 
CREATE PROCEDURE [dbo].[LichSuHoKhau_Insert]
@originalId  int=null,@hoTenTruongCongAn  nvarchar=null,@hoTenThanhVien  nvarchar=null,@vaiTro  nvarchar=null,@thoiGianThayDoi  datetime=null
 AS 
 INSERT INTO LichSuHoKhau([originalId],[hoTenTruongCongAn],[hoTenThanhVien],[vaiTro],[thoiGianThayDoi]) VALUES(@originalId,@hoTenTruongCongAn,@hoTenThanhVien,@vaiTro,@thoiGianThayDoi)
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DanToc_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[DanToc_UpdateById]
GO 
CREATE PROCEDURE [dbo].[DanToc_UpdateById]
@id  int,@tenDanToc  nvarchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 UPDATE DanToc SET [tenDanToc]=@tenDanToc,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_UpdateById]
GO 
CREATE PROCEDURE [dbo].[CongDan_UpdateById]
@id  int,@idDanToc  int=null,@hoTen  nvarchar=null,@ngaySinh  datetime=null,@gioiTinh  int=null,@queQuan  nvarchar=null,@quocTich  nvarchar=null,@idCDCha  int=null,@idCDMe  int=null,@noiDangKyKS  nvarchar=null,@ngayDangKyKS  datetime=null,@idNguoiLamDonKS  int=null,@idCDNguoiKyKS  int=null,@cmnd  int=null,@tonGiao  nvarchar=null,@ngheNghiep  nvarchar=null,@noiLamViec  nvarchar=null,@ngayCapCMND  datetime=null,@noiCap  nvarchar=null,@diaChiThuongTru  nvarchar=null,@trinhDoHocVan  nvarchar=null,@trinhDoChuyenMon  nvarchar=null,@trinhDoNgoaiNgu  nvarchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 UPDATE CongDan SET [idDanToc]=@idDanToc,[hoTen]=@hoTen,[ngaySinh]=@ngaySinh,[gioiTinh]=@gioiTinh,[queQuan]=@queQuan,[quocTich]=@quocTich,[idCDCha]=@idCDCha,[idCDMe]=@idCDMe,[noiDangKyKS]=@noiDangKyKS,[ngayDangKyKS]=@ngayDangKyKS,[idNguoiLamDonKS]=@idNguoiLamDonKS,[idCDNguoiKyKS]=@idCDNguoiKyKS,[cmnd]=@cmnd,[tonGiao]=@tonGiao,[ngheNghiep]=@ngheNghiep,[noiLamViec]=@noiLamViec,[ngayCapCMND]=@ngayCapCMND,[noiCap]=@noiCap,[diaChiThuongTru]=@diaChiThuongTru,[trinhDoHocVan]=@trinhDoHocVan,[trinhDoChuyenMon]=@trinhDoChuyenMon,[trinhDoNgoaiNgu]=@trinhDoNgoaiNgu,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongAn_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongAn_UpdateById]
GO 
CREATE PROCEDURE [dbo].[CongAn_UpdateById]
@id  int,@email  varchar=null,@username  varchar=null,@password  varchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 UPDATE CongAn SET [id]=@id,[email]=@email,[username]=@username,[password]=@password,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TomTatBanThan_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TomTatBanThan_UpdateById]
GO 
CREATE PROCEDURE [dbo].[TomTatBanThan_UpdateById]
@id  int,@idCongDan  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@choO  nvarchar=null,@ngheNghiep  nvarchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 UPDATE TomTatBanThan SET [idCongDan]=@idCongDan,[ngayBatDau]=@ngayBatDau,[ngayKetThuc]=@ngayKetThuc,[choO]=@choO,[ngheNghiep]=@ngheNghiep,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TienAn_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TienAn_UpdateById]
GO 
CREATE PROCEDURE [dbo].[TienAn_UpdateById]
@id  int,@idCongDan  int=null,@toiDanh  nvarchar=null,@hinhPhat  nvarchar=null,@ngayThang  datetime=null,@noiTuyenAn  nvarchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 UPDATE TienAn SET [idCongDan]=@idCongDan,[toiDanh]=@toiDanh,[hinhPhat]=@hinhPhat,[ngayThang]=@ngayThang,[noiTuyenAn]=@noiTuyenAn,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VaiTroSoHoKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[VaiTroSoHoKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[VaiTroSoHoKhau_UpdateById]
@id  int,@tenVaiTro  nvarchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 UPDATE VaiTroSoHoKhau SET [tenVaiTro]=@tenVaiTro,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HoKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[HoKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[HoKhau_UpdateById]
@id  int,@idCDTruongCongAn  int=null,@noiCap  nvarchar=null,@ngayCap  datetime=null,@noiDangKyThuongTru  nvarchar=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 UPDATE HoKhau SET [idCDTruongCongAn]=@idCDTruongCongAn,[noiCap]=@noiCap,[ngayCap]=@ngayCap,[noiDangKyThuongTru]=@noiDangKyThuongTru,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChiTietHoKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChiTietHoKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[ChiTietHoKhau_UpdateById]
@id  int,@idHoKhau  int=null,@idCDThanhVien  int=null,@idVaiTroSoHoKhau  int=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 UPDATE ChiTietHoKhau SET [idHoKhau]=@idHoKhau,[idCDThanhVien]=@idCDThanhVien,[idVaiTroSoHoKhau]=@idVaiTroSoHoKhau,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamVang_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamVang_UpdateById]
GO 
CREATE PROCEDURE [dbo].[TamVang_UpdateById]
@id  int,@idCongDan  int=null,@idTruongCongAn  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@lyDo  nvarchar=null,@diaChiDen  nvarchar=null,@ngayLamDon  datetime=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 UPDATE TamVang SET [idCongDan]=@idCongDan,[idTruongCongAn]=@idTruongCongAn,[ngayBatDau]=@ngayBatDau,[ngayKetThuc]=@ngayKetThuc,[lyDo]=@lyDo,[diaChiDen]=@diaChiDen,[ngayLamDon]=@ngayLamDon,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChuyenKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[ChuyenKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[ChuyenKhau_UpdateById]
@id  int,@idCongDan  int=null,@idHoKhauCu  int=null,@idHoKhauMoi  int=null,@lyDo  nvarchar=null,@idVaiTroSoHoKhau  int=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 UPDATE ChuyenKhau SET [idCongDan]=@idCongDan,[idHoKhauCu]=@idHoKhauCu,[idHoKhauMoi]=@idHoKhauMoi,[lyDo]=@lyDo,[idVaiTroSoHoKhau]=@idVaiTroSoHoKhau,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TamTru_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[TamTru_UpdateById]
GO 
CREATE PROCEDURE [dbo].[TamTru_UpdateById]
@id  int,@idCongDan  int=null,@idTruongCongAn  int=null,@ngayBatDau  datetime=null,@ngayKetThuc  datetime=null,@lyDo  nvarchar=null,@diaChiDen  nvarchar=null,@ngayLamDon  datetime=null,@ghiChu  nvarchar=null,@active  int=null
 AS 
 UPDATE TamTru SET [idCongDan]=@idCongDan,[idTruongCongAn]=@idTruongCongAn,[ngayBatDau]=@ngayBatDau,[ngayKetThuc]=@ngayKetThuc,[lyDo]=@lyDo,[diaChiDen]=@diaChiDen,[ngayLamDon]=@ngayLamDon,[ghiChu]=@ghiChu,[active]=@active WHERE [id]=@id
GO 
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LichSuHoKhau_UpdateById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[LichSuHoKhau_UpdateById]
GO 
CREATE PROCEDURE [dbo].[LichSuHoKhau_UpdateById]
@id  int,@originalId  int=null,@hoTenTruongCongAn  nvarchar=null,@hoTenThanhVien  nvarchar=null,@vaiTro  nvarchar=null,@thoiGianThayDoi  datetime=null
 AS 
 UPDATE LichSuHoKhau SET [originalId]=@originalId,[hoTenTruongCongAn]=@hoTenTruongCongAn,[hoTenThanhVien]=@hoTenThanhVien,[vaiTro]=@vaiTro,[thoiGianThayDoi]=@thoiGianThayDoi WHERE [id]=@id
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
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_SelectByNghenghiep]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_SelectByNghenghiep]
GO 
CREATE PROCEDURE [dbo].[CongDan_SelectByNghenghiep]
@nghe  nvarchar(100)
 AS 
 SELECT * FROM CongDan WHERE [ngheNghiep]=@nghe 
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
