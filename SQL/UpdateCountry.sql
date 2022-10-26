use Transfer;
go

create or alter proc UpdateCountry
@ctyid char(2),
@ctyname varchar(50),
@ctyregid int
as
	declare 
		@countryExist int, 
		@regioExists int;

	set @countryExist = 0;
	set @regioExists = 0;

	select @countryExist = count(*) from Country where ctyid = @ctyid;

	if @countryExist <= 0 
	begin 
		raiserror('Country does not exist.', 16, 1);
		return;
	end;

	select @regioExists = count(*) from Regio where regid = @ctyregid;

	if @regioExists <= 0 
	begin 
		raiserror('Regio does not exist.', 16, 1); 
		return; 
	end;
	
	update Country 
	set ctyid = @ctyid, ctyname = @ctyname, ctyregid = @ctyregid
	where ctyid = @ctyid;