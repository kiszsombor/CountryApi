use Transfer;
go

create or alter proc UpdateRegio
@regid int,
@regname varchar(50)
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
	
	update Regio 
	set regname = @regname
	where regid = @regid;	