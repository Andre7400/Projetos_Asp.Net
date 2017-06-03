
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2017 10:23:25
-- Generated from EDMX file: C:\Users\1600535\Source\Repos\Projetos_Asp.Net\ProjetoProva\ProjetoProva\Model\DadosBase.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DadosBase];
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

-- Creating table 'Medicos'
CREATE TABLE [dbo].[Medicos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Idade] decimal(18,0)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'Consultas'
CREATE TABLE [dbo].[Consultas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Preco] decimal(18,0)  NOT NULL,
    [MedicoId] int  NOT NULL,
    [Ativo] bit  NOT NULL,
    [DataConsulta] nvarchar(8)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Medicos'
ALTER TABLE [dbo].[Medicos]
ADD CONSTRAINT [PK_Medicos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Consultas'
ALTER TABLE [dbo].[Consultas]
ADD CONSTRAINT [PK_Consultas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MedicoId] in table 'Consultas'
ALTER TABLE [dbo].[Consultas]
ADD CONSTRAINT [FK_MedicoID]
    FOREIGN KEY ([MedicoId])
    REFERENCES [dbo].[Medicos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoID'
CREATE INDEX [IX_FK_MedicoID]
ON [dbo].[Consultas]
    ([MedicoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------