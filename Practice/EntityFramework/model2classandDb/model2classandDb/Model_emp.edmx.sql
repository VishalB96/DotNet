
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/12/2020 12:53:53
-- Generated from EDMX file: E:\VITA CDAC OOP\ASP_DotNet\GitRepo\DotNet\Practice\EntityFramework\model2classandDb\model2classandDb\Model_emp.edmx
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

IF OBJECT_ID(N'[dbo].[FK_DeptDemoEmpDemo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpDemoes] DROP CONSTRAINT [FK_DeptDemoEmpDemo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DeptDemoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeptDemoes];
GO
IF OBJECT_ID(N'[dbo].[EmpDemoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmpDemoes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DeptDemoes'
CREATE TABLE [dbo].[DeptDemoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EmpDemoes'
CREATE TABLE [dbo].[EmpDemoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Salary] nvarchar(max)  NOT NULL,
    [Position] nvarchar(max)  NOT NULL,
    [DeptDemoId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'DeptDemoes'
ALTER TABLE [dbo].[DeptDemoes]
ADD CONSTRAINT [PK_DeptDemoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmpDemoes'
ALTER TABLE [dbo].[EmpDemoes]
ADD CONSTRAINT [PK_EmpDemoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeptDemoId] in table 'EmpDemoes'
ALTER TABLE [dbo].[EmpDemoes]
ADD CONSTRAINT [FK_DeptDemoEmpDemo]
    FOREIGN KEY ([DeptDemoId])
    REFERENCES [dbo].[DeptDemoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeptDemoEmpDemo'
CREATE INDEX [IX_FK_DeptDemoEmpDemo]
ON [dbo].[EmpDemoes]
    ([DeptDemoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------