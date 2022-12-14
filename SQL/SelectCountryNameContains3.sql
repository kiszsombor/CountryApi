USE [Transfer]
GO
/****** Object:  StoredProcedure [dbo].[SelectCountryNameContains]    Script Date: 2022. 10. 26. 13:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   proc [dbo].[SelectCountryNameContains]
	@ctyname varchar(50)
as
	if len(@ctyname) > 2
		select c.ctyid, c.ctyname, r.regname
		from Country c join Regio r on c.ctyregid = r.regid
		where c.ctyname LIKE (@ctyname + '%')
	else
		select c.ctyid, c.ctyname, r.regname
		from Country c join Regio r on c.ctyregid = r.regid