USE [Transfer]
GO
/****** Object:  StoredProcedure [dbo].[CreateRegio]    Script Date: 2022. 10. 21. 10:27:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   proc [dbo].[CreateRegio]
@regid int,
@regname varchar(50)
as
	insert into Regio(regname)
		values (@regname);