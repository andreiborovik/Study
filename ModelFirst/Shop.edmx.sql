
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/05/2021 21:34:37
-- Generated from EDMX file: D:\Андреева\Oxagile\ModelFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UsersRoles_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersRoles] DROP CONSTRAINT [FK_UsersRoles_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_UsersRoles_Roles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersRoles] DROP CONSTRAINT [FK_UsersRoles_Roles];
GO
IF OBJECT_ID(N'[dbo].[FK_OrdersUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_OrdersUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductsOrders_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductsOrders] DROP CONSTRAINT [FK_ProductsOrders_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductsOrders_Orders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductsOrders] DROP CONSTRAINT [FK_ProductsOrders_Orders];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductsComments]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comments] DROP CONSTRAINT [FK_ProductsComments];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductsCategories]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_ProductsCategories];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Comments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comments];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[UsersRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsersRoles];
GO
IF OBJECT_ID(N'[dbo].[ProductsOrders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductsOrders];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [Firstname] nvarchar(20)  NOT NULL,
    [Lastname] nvarchar(20)  NOT NULL,
    [Phone] decimal(18,0)  NOT NULL,
    [Email] nvarchar(25)  NOT NULL,
    [Age] int  NOT NULL,
    [Birthday] datetime  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [RoleId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [CategoryId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Comments'
CREATE TABLE [dbo].[Comments] (
    [CommentId] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [Products_ProductId] int  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [OrderId] int IDENTITY(1,1) NOT NULL,
    [Users_UserId] int  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Price] decimal(18,0)  NOT NULL,
    [Categories_CategoryId] int  NOT NULL
);
GO

-- Creating table 'UsersRoles'
CREATE TABLE [dbo].[UsersRoles] (
    [Users_UserId] int  NOT NULL,
    [Roles_RoleId] int  NOT NULL
);
GO

-- Creating table 'ProductsOrders'
CREATE TABLE [dbo].[ProductsOrders] (
    [Products_ProductId] int  NOT NULL,
    [Orders_OrderId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [RoleId] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([RoleId] ASC);
GO

-- Creating primary key on [CategoryId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([CategoryId] ASC);
GO

-- Creating primary key on [CommentId] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [PK_Comments]
    PRIMARY KEY CLUSTERED ([CommentId] ASC);
GO

-- Creating primary key on [OrderId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([OrderId] ASC);
GO

-- Creating primary key on [ProductId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductId] ASC);
GO

-- Creating primary key on [Users_UserId], [Roles_RoleId] in table 'UsersRoles'
ALTER TABLE [dbo].[UsersRoles]
ADD CONSTRAINT [PK_UsersRoles]
    PRIMARY KEY CLUSTERED ([Users_UserId], [Roles_RoleId] ASC);
GO

-- Creating primary key on [Products_ProductId], [Orders_OrderId] in table 'ProductsOrders'
ALTER TABLE [dbo].[ProductsOrders]
ADD CONSTRAINT [PK_ProductsOrders]
    PRIMARY KEY CLUSTERED ([Products_ProductId], [Orders_OrderId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Users_UserId] in table 'UsersRoles'
ALTER TABLE [dbo].[UsersRoles]
ADD CONSTRAINT [FK_UsersRoles_Users]
    FOREIGN KEY ([Users_UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Roles_RoleId] in table 'UsersRoles'
ALTER TABLE [dbo].[UsersRoles]
ADD CONSTRAINT [FK_UsersRoles_Roles]
    FOREIGN KEY ([Roles_RoleId])
    REFERENCES [dbo].[Roles]
        ([RoleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersRoles_Roles'
CREATE INDEX [IX_FK_UsersRoles_Roles]
ON [dbo].[UsersRoles]
    ([Roles_RoleId]);
GO

-- Creating foreign key on [Users_UserId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_OrdersUsers]
    FOREIGN KEY ([Users_UserId])
    REFERENCES [dbo].[Users]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrdersUsers'
CREATE INDEX [IX_FK_OrdersUsers]
ON [dbo].[Orders]
    ([Users_UserId]);
GO

-- Creating foreign key on [Products_ProductId] in table 'ProductsOrders'
ALTER TABLE [dbo].[ProductsOrders]
ADD CONSTRAINT [FK_ProductsOrders_Products]
    FOREIGN KEY ([Products_ProductId])
    REFERENCES [dbo].[Products]
        ([ProductId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Orders_OrderId] in table 'ProductsOrders'
ALTER TABLE [dbo].[ProductsOrders]
ADD CONSTRAINT [FK_ProductsOrders_Orders]
    FOREIGN KEY ([Orders_OrderId])
    REFERENCES [dbo].[Orders]
        ([OrderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductsOrders_Orders'
CREATE INDEX [IX_FK_ProductsOrders_Orders]
ON [dbo].[ProductsOrders]
    ([Orders_OrderId]);
GO

-- Creating foreign key on [Products_ProductId] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [FK_ProductsComments]
    FOREIGN KEY ([Products_ProductId])
    REFERENCES [dbo].[Products]
        ([ProductId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductsComments'
CREATE INDEX [IX_FK_ProductsComments]
ON [dbo].[Comments]
    ([Products_ProductId]);
GO

-- Creating foreign key on [Categories_CategoryId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_ProductsCategories]
    FOREIGN KEY ([Categories_CategoryId])
    REFERENCES [dbo].[Categories]
        ([CategoryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductsCategories'
CREATE INDEX [IX_FK_ProductsCategories]
ON [dbo].[Products]
    ([Categories_CategoryId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------