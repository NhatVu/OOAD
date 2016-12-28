if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_SelectByName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_SelectByName]
GO 
CREATE PROCEDURE [dbo].[CongDan_SelectByName]
@hoTen nvarchar(50)

 AS 
 SELECT * FROM CongDan WHERE [hoTen]=@hoTen
GO 

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongDan_SelectByCmnd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongDan_SelectByCmnd]
GO 
CREATE PROCEDURE [dbo].[CongDan_SelectByCmnd]
@cmnd int

 AS 
 SELECT * FROM CongDan WHERE [cmnd]=@cmnd
GO 

