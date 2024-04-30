create database JobSeekerEntity
Go
drop table JobSeeker

Go
CREATE TABLE [dbo].[JobSeeker] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
);
GO


select * from dbo.JobSeeker
Use JobSeekerEntity
CREATE TABLE [dbo].[Posts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Salary] decimal(18,0)  NOT NULL,
    [Others] nvarchar(max)  NOT NULL,
    [Timeposted] datetime  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [EmployerId] int  NOT NULL
);
GO

declare @i int = 0
while @i < 5
begin
 set @i = @i +1
 insert into dbo.JobSeeker(Name,Email,PhoneNumber,Password)
 values ( N'Job Seeker ', N'a @gmail.com',N'1',N'12345')
end

declare @i int = 0
while @i < 5
begin
 set @i = @i +1
 insert into dbo.Posts(Name,Salary,Others,Timeposted,Status,EmployerId)
 values ( N'Post '+str(@i),180,N'1','2024-02-02','available',123)
end
select * from dbo.Posts