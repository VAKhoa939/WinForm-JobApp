drop table ComEmpCatalog;

create table ComEmpCatalog (
	Comname nvarchar(30),
	Empname nvarchar(10)
);

insert into ComEmpCatalog (Comname, Empname)
values
	('', ''),
	('', ''),
	('', '');

select * from ComEmpCatalog;