use Transfer;
go

create or alter proc CreateCountry
@ctyid char(2),
@ctyname varchar(50),
@ctyregid int
as
	declare 
		@regioExists int;
		set @regioExists = 0;
		select @regioExists = count(*) from Regio where regid = @ctyregid;
		if @regioExists <= 0 
		begin 
			raiserror('Regio does not exist.', 16, 1); 
			return; 
		end;

	insert into Country(ctyid, ctyname, ctyregid)
		values (@ctyid, @ctyname, @ctyregid);
