
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/21/2022 10:57:51
-- Generated from EDMX file: C:\Users\Kirill\source\repos\SimpleClientApp\SimpleClientApp\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [C:\USERS\KIRILL\SOURCE\REPOS\SIMPLECLIENTAPP\SIMPLECLIENTAPP\CLENTDATABASE.MDF];
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

-- Creating table 'CustomersSet'
CREATE TABLE [dbo].[CustomersSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Contacts] nvarchar(max)  NOT NULL,
    [Sells] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'GoodsSet'
CREATE TABLE [dbo].[GoodsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'SellsSet'
CREATE TABLE [dbo].[SellsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomersID] int  NOT NULL,
    [GoodsID] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [Quantity] int  NOT NULL,
    [Total] decimal(18,0)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CustomersSet'
ALTER TABLE [dbo].[CustomersSet]
ADD CONSTRAINT [PK_CustomersSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GoodsSet'
ALTER TABLE [dbo].[GoodsSet]
ADD CONSTRAINT [PK_GoodsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SellsSet'
ALTER TABLE [dbo].[SellsSet]
ADD CONSTRAINT [PK_SellsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------