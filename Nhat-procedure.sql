-- get CongAn by email
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CongAn_SelectByEmail]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[CongAn_SelectByEmail]
GO 
CREATE PROCEDURE [dbo].[CongAn_SelectByEmail]
@email  varchar(50)

 AS 
 SELECT * FROM CongAn WHERE [email]=@email
GO 
