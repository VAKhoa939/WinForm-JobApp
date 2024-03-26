drop table SeekFormCatalog;

create table SeekFormCatalog (
	Seekname varchar(10),
	Formid int
);

insert into SeekFormCatalog (Seekname, Formid)
values
	('', ''),
	('', ''),
	('', '');

select * from SeekFormCatalog;