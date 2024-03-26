drop table ApplyForm;

create table ApplyForm (
	Seekformid int,
	Postformid int,
	Cv varbinary(max),
	Coverletter nvarchar(255),
	Status varchar(10), 
	Timesent DateTime
);

insert into ApplyForm (Seekformid, Postformid, Cv, Coverletter, Status, Timesent)
values
	('', '', '', '', '', ''),
	('', '', '', '', '', ''),
	('', '', '', '', '', '');

select * from ApplyForm;