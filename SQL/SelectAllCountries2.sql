USE [Transfer]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllCountries]    Script Date: 2022. 10. 20. 15:46:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   proc [dbo].[SelectAllCountries]
as
	select c.ctyid, c.ctyname, c.ctyregid, r.regname
	from Country c
		join Regio r on r.regid = c.ctyregid;