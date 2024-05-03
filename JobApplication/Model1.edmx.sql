
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/03/2024 23:23:31
-- Generated from EDMX file: D:\Đại học stuff\New folder\WinForm-JobApp\JobApplication\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [JobAppDF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PostApplyForm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApplyForms] DROP CONSTRAINT [FK_PostApplyForm];
GO
IF OBJECT_ID(N'[dbo].[FK_JobSeekerApplyForm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApplyForms] DROP CONSTRAINT [FK_JobSeekerApplyForm];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanyEmployer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Employer] DROP CONSTRAINT [FK_CompanyEmployer];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployerPost]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts] DROP CONSTRAINT [FK_EmployerPost];
GO
IF OBJECT_ID(N'[dbo].[FK_PostImage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PostImageCatalogs] DROP CONSTRAINT [FK_PostImage];
GO
IF OBJECT_ID(N'[dbo].[FK_PostDesc]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PostDescCatalogs] DROP CONSTRAINT [FK_PostDesc];
GO
IF OBJECT_ID(N'[dbo].[FK_PostTag]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PostTagCatalogs] DROP CONSTRAINT [FK_PostTag];
GO
IF OBJECT_ID(N'[dbo].[FK_JobSeeker_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_JobSeeker] DROP CONSTRAINT [FK_JobSeeker_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Employer_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Employer] DROP CONSTRAINT [FK_Employer_inherits_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Posts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Posts];
GO
IF OBJECT_ID(N'[dbo].[ApplyForms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ApplyForms];
GO
IF OBJECT_ID(N'[dbo].[Companies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Companies];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[PostDescCatalogs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PostDescCatalogs];
GO
IF OBJECT_ID(N'[dbo].[PostImageCatalogs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PostImageCatalogs];
GO
IF OBJECT_ID(N'[dbo].[PostTagCatalogs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PostTagCatalogs];
GO
IF OBJECT_ID(N'[dbo].[Users_JobSeeker]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_JobSeeker];
GO
IF OBJECT_ID(N'[dbo].[Users_Employer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_Employer];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Posts'
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

-- Creating table 'ApplyForms'
CREATE TABLE [dbo].[ApplyForms] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CVcontent] nvarchar(max)  NOT NULL,
    [CVname] nvarchar(max)  NOT NULL,
    [Coverletter] nvarchar(max)  NOT NULL,
    [Timesent] datetime  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [PostId] int  NOT NULL,
    [JobSeekerId] int  NOT NULL,
    [JobSeekerName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Companies'
CREATE TABLE [dbo].[Companies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Logo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Phonenumber] nvarchar(max)  NOT NULL,
    [Fullname] nvarchar(max)  NOT NULL,
    [Portraitimage] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PostDescCatalogs'
CREATE TABLE [dbo].[PostDescCatalogs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [JobDesc] nvarchar(max)  NOT NULL,
    [PostId] int  NOT NULL
);
GO

-- Creating table 'PostImageCatalogs'
CREATE TABLE [dbo].[PostImageCatalogs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Image] nvarchar(max)  NOT NULL,
    [PostId] int  NOT NULL
);
GO

-- Creating table 'PostTagCatalogs'
CREATE TABLE [dbo].[PostTagCatalogs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tag] nvarchar(max)  NOT NULL,
    [PostId] int  NOT NULL
);
GO

-- Creating table 'Users_JobSeeker'
CREATE TABLE [dbo].[Users_JobSeeker] (
    [Address] nvarchar(max)  NOT NULL,
    [Birthdate] datetime  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Users_Employer'
CREATE TABLE [dbo].[Users_Employer] (
    [CompanyId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Posts'
ALTER TABLE [dbo].[Posts]
ADD CONSTRAINT [PK_Posts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ApplyForms'
ALTER TABLE [dbo].[ApplyForms]
ADD CONSTRAINT [PK_ApplyForms]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [PK_Companies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PostDescCatalogs'
ALTER TABLE [dbo].[PostDescCatalogs]
ADD CONSTRAINT [PK_PostDescCatalogs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PostImageCatalogs'
ALTER TABLE [dbo].[PostImageCatalogs]
ADD CONSTRAINT [PK_PostImageCatalogs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PostTagCatalogs'
ALTER TABLE [dbo].[PostTagCatalogs]
ADD CONSTRAINT [PK_PostTagCatalogs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users_JobSeeker'
ALTER TABLE [dbo].[Users_JobSeeker]
ADD CONSTRAINT [PK_Users_JobSeeker]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users_Employer'
ALTER TABLE [dbo].[Users_Employer]
ADD CONSTRAINT [PK_Users_Employer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PostId] in table 'ApplyForms'
ALTER TABLE [dbo].[ApplyForms]
ADD CONSTRAINT [FK_PostApplyForm]
    FOREIGN KEY ([PostId])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PostApplyForm'
CREATE INDEX [IX_FK_PostApplyForm]
ON [dbo].[ApplyForms]
    ([PostId]);
GO

-- Creating foreign key on [JobSeekerId] in table 'ApplyForms'
ALTER TABLE [dbo].[ApplyForms]
ADD CONSTRAINT [FK_JobSeekerApplyForm]
    FOREIGN KEY ([JobSeekerId])
    REFERENCES [dbo].[Users_JobSeeker]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JobSeekerApplyForm'
CREATE INDEX [IX_FK_JobSeekerApplyForm]
ON [dbo].[ApplyForms]
    ([JobSeekerId]);
GO

-- Creating foreign key on [CompanyId] in table 'Users_Employer'
ALTER TABLE [dbo].[Users_Employer]
ADD CONSTRAINT [FK_CompanyEmployer]
    FOREIGN KEY ([CompanyId])
    REFERENCES [dbo].[Companies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyEmployer'
CREATE INDEX [IX_FK_CompanyEmployer]
ON [dbo].[Users_Employer]
    ([CompanyId]);
GO

-- Creating foreign key on [EmployerId] in table 'Posts'
ALTER TABLE [dbo].[Posts]
ADD CONSTRAINT [FK_EmployerPost]
    FOREIGN KEY ([EmployerId])
    REFERENCES [dbo].[Users_Employer]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployerPost'
CREATE INDEX [IX_FK_EmployerPost]
ON [dbo].[Posts]
    ([EmployerId]);
GO

-- Creating foreign key on [PostId] in table 'PostImageCatalogs'
ALTER TABLE [dbo].[PostImageCatalogs]
ADD CONSTRAINT [FK_PostImage]
    FOREIGN KEY ([PostId])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PostImage'
CREATE INDEX [IX_FK_PostImage]
ON [dbo].[PostImageCatalogs]
    ([PostId]);
GO

-- Creating foreign key on [PostId] in table 'PostDescCatalogs'
ALTER TABLE [dbo].[PostDescCatalogs]
ADD CONSTRAINT [FK_PostDesc]
    FOREIGN KEY ([PostId])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PostDesc'
CREATE INDEX [IX_FK_PostDesc]
ON [dbo].[PostDescCatalogs]
    ([PostId]);
GO

-- Creating foreign key on [PostId] in table 'PostTagCatalogs'
ALTER TABLE [dbo].[PostTagCatalogs]
ADD CONSTRAINT [FK_PostTag]
    FOREIGN KEY ([PostId])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PostTag'
CREATE INDEX [IX_FK_PostTag]
ON [dbo].[PostTagCatalogs]
    ([PostId]);
GO

-- Creating foreign key on [Id] in table 'Users_JobSeeker'
ALTER TABLE [dbo].[Users_JobSeeker]
ADD CONSTRAINT [FK_JobSeeker_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Users_Employer'
ALTER TABLE [dbo].[Users_Employer]
ADD CONSTRAINT [FK_Employer_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------