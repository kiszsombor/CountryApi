use Transfer;
go

create or alter proc SelectCountry
@countryId char(2)
as
	declare 
		@countryExist int;

	set @countryExist = 0;
	select @countryExist = count(*) from Country where ctyid = @countryId;

	if @countryExist = 0 begin 
		raiserror('Country does not exist', 16, 1); 
		return; 
	end;

	select ctyid, ctyname, ctyregid
	from Country
	where ctyid = @countryId;