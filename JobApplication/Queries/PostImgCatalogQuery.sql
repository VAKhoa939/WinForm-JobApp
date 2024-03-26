drop table PostImgCatalog;

create table PostImgCatalog  (
	Postid int,
	Postimage Image
);

insert into PostImgCatalog (Postid, Postimage)
values
	('', ''),
	('', ''),
	('', '');

select * from PostImgCatalog;