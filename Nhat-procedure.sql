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


