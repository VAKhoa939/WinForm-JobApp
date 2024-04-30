drop table Company;

create table Company (
	Name nvarchar(30),
	Logo varbinary(max)
);

insert into Company (Name, Logo) 
values 
	('', '0x'),
	('', '0x'),
	('', '0x');

select * from Company;