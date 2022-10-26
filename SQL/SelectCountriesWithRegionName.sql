use Transfer;
go

create or alter proc SelectCountriesWithRegionName
as
	select c.ctyid, c.ctyname, c.ctyregid, r.regname
	from Country c
		join Regio r on r.regid = c.ctyregid;