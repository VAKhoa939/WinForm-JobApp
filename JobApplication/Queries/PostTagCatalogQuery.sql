drop table PostTagCatalog;

create table PostTagCatalog  (
	Postid int,
	Tag varchar(20)
);

insert into PostTagCatalog (Postid, Tag)
values
	('', ''),
	('', ''),
	('', '');

select * from PostTagCatalog;