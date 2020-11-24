
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/20/2020 21:58:58
-- Generated from EDMX file: E:\VITA CDAC OOP\ASP_DotNet\GitRepo\DotNet\Practice\MVC\AppPractice\Login\Models\ModelStudentLogin.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'StudentDemoes'
CREATE TABLE [dbo].[StudentDemoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Age] smallint  NOT NULL,
    [City] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StudentLogins'
CREATE TABLE [dbo].[StudentLogins] (
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [StudentDemo_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'StudentDemoes'
ALTER TABLE [dbo].[StudentDemoes]
ADD CONSTRAINT [PK_StudentDemoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Username] in table 'StudentLogins'
ALTER TABLE [dbo].[StudentLogins]
ADD CONSTRAINT [PK_StudentLogins]
    PRIMARY KEY CLUSTERED ([Username] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StudentDemo_Id] in table 'StudentLogins'
ALTER TABLE [dbo].[StudentLogins]
ADD CONSTRAINT [FK_StudentLoginStudentDemo]
    FOREIGN KEY ([StudentDemo_Id])
    REFERENCES [dbo].[StudentDemoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentLoginStudentDemo'
CREATE INDEX [IX_FK_StudentLoginStudentDemo]
ON [dbo].[StudentLogins]
    ([StudentDemo_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------