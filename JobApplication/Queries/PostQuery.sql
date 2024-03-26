drop table Post;

create table Post (
	Id int,
	Name nvarchar(100),
	Salary decimal, 
	Others nvarchar(100), 
	Timeposted DateTime
);

insert into Post (Id, Name, Salary, Others, Timeposted)
values
	('', '', '', '', ''),
	('', '', '', '', ''),
	('', '', '', '', '');

select * from Post;