USE [Transfer]
GO
/****** Object:  StoredProcedure [dbo].[DeleteRegio]    Script Date: 2022. 10. 21. 10:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   proc [dbo].[DeleteRegio]
@regid int
as
	declare 
		@regioUsed int,
		@regioExists int;

	set @regioExists = 0;
	set @regioUsed = 0;

	select @regioExists = count(*) from Regio where regid = @regid;

	if @regioExists <= 0 
	begin 
		raiserror('Regio does not exist.', 16, 1); 
		return; 
	end;

	select @regioUsed = count(*) from Country where ctyregid = @regid;

	if @regioUsed > 0 
	begin 
		raiserror('Regio in used by another country table.', 16, 1); 
		return; 
	end;

	delete from Regio where regid = @regid;
	