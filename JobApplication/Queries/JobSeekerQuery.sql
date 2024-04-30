drop table JobSeeker;

create table JobSeeker (
	Username varchar(10), 
	Email varchar(100), 
	Password varchar(10), 
	Phonenumber varchar(20), 
	Fullname nvarchar(100), 
	Address nvarchar(100), 
	Birthdate DateTime,
	Portraitimage varbinary(max)
);

insert into JobSeeker (Username, Email, Password, Phonenumber, Fullname, Address, Birthdate, Portraitimage) 
values 
	('', '', '', '', '', '', '', '0x'),
	('', '', '', '', '', '', '', '0x'),
	('', '', '', '', '', '', '', '0x');

select * from JobSeeker;