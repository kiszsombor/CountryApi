use Transfer;
go

create or alter proc DeleteRegio
@regid int
as
	declare 
		@regioExists int;

	set @regioExists = 0;
	select @regioExists = count(*) from Regio where regid = @regid;

	if @regioExists <= 0 
	begin 
		raiserror('Regio does not exist.', 16, 1); 
		return; 
	end;

	delete from Country where ctyregid = @regid;
	delete from Regio where regid = @regid;
	