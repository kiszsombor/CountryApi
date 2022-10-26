use Transfer;
go

create or alter proc DeleteCountry
@ctyid char(2)
as
	declare 
		@countryExists int;

	set @countryExists = 0;
	select @countryExists = count(*) from Country where ctyid = @ctyid;

	if @countryExists <= 0 
	begin 
		raiserror('Country does not exist.', 16, 1); 
		return; 
	end;

	delete from Country where ctyid = @ctyid;