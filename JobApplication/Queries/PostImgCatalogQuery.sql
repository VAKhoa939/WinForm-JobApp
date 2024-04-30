drop table PostImgCatalog;

create table PostImgCatalog  (
	Postid int,
	Postimage varbinary(max)
);

insert into PostImgCatalog (Postid, Postimage)
values
	('', '0x'),
	('', '0x'),
	('', '0x');

select * from PostImgCatalog;