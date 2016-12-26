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
select c.hoTen, c.ngaySinh, c.gioiTinh, c.diaChiThuongTru, c.cmnd,
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
select c.hoTen, c.ngaySinh, c.gioiTinh, c.diaChiThuongTru, c.cmnd,
t.ngayBatDau, t.ngayKetThuc, t.ghiChu
from TamVang as t inner join CongDan as c
	on t.idCongDan = c.id
where t.active = 1 and c.active = 1
go
