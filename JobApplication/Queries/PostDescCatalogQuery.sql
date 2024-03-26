drop table PostDescCatalog;

create table PostDescCatalog  (
	Postid int,
	Jobdesc nvarchar(255)
);

insert into PostDescCatalog (Postid, Jobdesc)
values
	('', ''),
	('', ''),
	('', '');

select * from PostDescCatalog;