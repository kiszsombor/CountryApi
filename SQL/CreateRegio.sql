use Transfer;
go

create or alter proc CreateRegio
@regid int,
@regname varchar(50)
as
	insert into Regio(regid, regname)
		values (@regid, @regname);