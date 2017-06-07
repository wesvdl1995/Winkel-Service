
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/07/2017 14:05:26
-- Generated from EDMX file: C:\Users\Ashwin\Source\Repos\Winkel-Service\WinkelService\WinkelServiceLibrary\WinkelModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [WinkelDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AankoopRegelProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AankoopRegels] DROP CONSTRAINT [FK_AankoopRegelProduct];
GO
IF OBJECT_ID(N'[dbo].[FK_AankoopAankoopRegel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AankoopRegels] DROP CONSTRAINT [FK_AankoopAankoopRegel];
GO
IF OBJECT_ID(N'[dbo].[FK_KlantAankoop]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aankopen] DROP CONSTRAINT [FK_KlantAankoop];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Klanten]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Klanten];
GO
IF OBJECT_ID(N'[dbo].[Producten]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Producten];
GO
IF OBJECT_ID(N'[dbo].[Aankopen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aankopen];
GO
IF OBJECT_ID(N'[dbo].[AankoopRegels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AankoopRegels];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Klanten'
CREATE TABLE [dbo].[Klanten] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(20)  NOT NULL,
    [Password] nvarchar(20)  NOT NULL,
    [Saldo] float  NOT NULL
);
GO

-- Creating table 'Producten'
CREATE TABLE [dbo].[Producten] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Naam] nvarchar(20)  NOT NULL,
    [Prijs] float  NOT NULL,
    [Aantal] int  NOT NULL
);
GO

-- Creating table 'Aankopen'
CREATE TABLE [dbo].[Aankopen] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [KlantId] int  NOT NULL
);
GO

-- Creating table 'AankoopRegels'
CREATE TABLE [dbo].[AankoopRegels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Hoeveelheid] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [AankoopId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Klanten'
ALTER TABLE [dbo].[Klanten]
ADD CONSTRAINT [PK_Klanten]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Producten'
ALTER TABLE [dbo].[Producten]
ADD CONSTRAINT [PK_Producten]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Aankopen'
ALTER TABLE [dbo].[Aankopen]
ADD CONSTRAINT [PK_Aankopen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AankoopRegels'
ALTER TABLE [dbo].[AankoopRegels]
ADD CONSTRAINT [PK_AankoopRegels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProductId] in table 'AankoopRegels'
ALTER TABLE [dbo].[AankoopRegels]
ADD CONSTRAINT [FK_AankoopRegelProduct]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Producten]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AankoopRegelProduct'
CREATE INDEX [IX_FK_AankoopRegelProduct]
ON [dbo].[AankoopRegels]
    ([ProductId]);
GO

-- Creating foreign key on [AankoopId] in table 'AankoopRegels'
ALTER TABLE [dbo].[AankoopRegels]
ADD CONSTRAINT [FK_AankoopAankoopRegel]
    FOREIGN KEY ([AankoopId])
    REFERENCES [dbo].[Aankopen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AankoopAankoopRegel'
CREATE INDEX [IX_FK_AankoopAankoopRegel]
ON [dbo].[AankoopRegels]
    ([AankoopId]);
GO

-- Creating foreign key on [KlantId] in table 'Aankopen'
ALTER TABLE [dbo].[Aankopen]
ADD CONSTRAINT [FK_KlantAankoop]
    FOREIGN KEY ([KlantId])
    REFERENCES [dbo].[Klanten]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KlantAankoop'
CREATE INDEX [IX_FK_KlantAankoop]
ON [dbo].[Aankopen]
    ([KlantId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------