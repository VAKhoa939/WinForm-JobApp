drop table Employer;

create table Employer (
	Username varchar(10),
	Email varchar(100),
	Password varchar(10), 
	Phonenumber varchar(20), 
	Fullname nvarchar(100),
);

insert into Employer (Username, Email, Password, Phonenumber, Fullname)
values
	('', '', '', '', ''),
	('', '', '', '', ''),
	('', '', '', '', '');

select * from Employer;