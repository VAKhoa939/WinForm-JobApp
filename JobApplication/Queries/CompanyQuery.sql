drop table Company;

create table Company (
	Name nvarchar(30),
	Logo Image,
);

insert into Company (Name, Logo) 
values 
	('', ''),
	('', ''),
	('', '');

select * from Company;