use Transfer
go
create or alter proc SelectCountryNameContains
	@ctyname varchar(50)
as
	if len(@ctyname) < 3
	begin
		raiserror('Country name should contain at least 3 character.', 16, 1);
		return;
	end;

	select c.ctyid, c.ctyname, r.regname
	from Country c join Regio r on c.ctyregid = r.regid
	where c.ctyname LIKE (@ctyname + '%')