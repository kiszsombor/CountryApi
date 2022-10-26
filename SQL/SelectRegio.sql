use Transfer;
go

create or alter proc SelectRegio
	@regid int
as
	declare 
		@regioExist int;

	set @regioExist = 0;
	select @regioExist = count(*) from Regio where regid = @regid;

	if @regioExist = 0 begin 
		raiserror('Region does not exist', 16, 1); 
		return; 
	end;

	select *
	from Regio
	where regid = @regid;