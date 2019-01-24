
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/21/2018 12:31:12
-- Generated from EDMX file: D:\VisualStudio练习代码\WebEFTest0806\Model\DbModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HT_News];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[News]', 'U') IS NOT NULL
    DROP TABLE [dbo].[News];
GO
IF OBJECT_ID(N'[dbo].[UserInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserInfo];
GO
IF OBJECT_ID(N'[dbo].[UserMSG]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserMSG];
GO
IF OBJECT_ID(N'[HT_NewsModelStoreContainer].[NewsComments]', 'U') IS NOT NULL
    DROP TABLE [HT_NewsModelStoreContainer].[NewsComments];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserInfo'
CREATE TABLE [dbo].[UserInfo] (
    [UserName] nvarchar(50)  NULL,
    [UserLoginName] nvarchar(50)  NOT NULL,
    [IsVip] int  NULL,
    [IsOnLine] int  NULL,
    [CrDate] datetime  NULL,
    [CrUserName] nvarchar(50)  NULL,
    [CrUserRealName] nvarchar(50)  NULL,
    [MoDate] datetime  NULL,
    [MoUserRealName] nvarchar(50)  NULL,
    [MoUserName] nvarchar(50)  NULL,
    [Age] int  NULL,
    [UserPsd] nvarchar(50)  NULL,
    [IsUseful] int  NULL,
    [UserRealName] nvarchar(50)  NULL,
    [UserMail] nvarchar(50)  NULL,
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'UserMSG'
CREATE TABLE [dbo].[UserMSG] (
    [userid] int IDENTITY(1,1) NOT NULL,
    [password] nvarchar(2000)  NULL,
    [zt] nvarchar(50)  NULL,
    [username] nvarchar(50)  NULL,
    [workcode] nvarchar(50)  NULL,
    [Email] nvarchar(50)  NULL,
    [phoneNumber] nvarchar(50)  NULL,
    [address] nvarchar(100)  NULL,
    [departmentid] nvarchar(50)  NULL,
    [company] nvarchar(50)  NULL,
    [login] nvarchar(50)  NULL
);
GO

-- Creating table 'News'
CREATE TABLE [dbo].[News] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NULL,
    [NewsMsg] nvarchar(max)  NULL,
    [SubTime] nvarchar(50)  NULL,
    [Author] nvarchar(50)  NULL,
    [ImagePath] nvarchar(50)  NULL
);
GO

-- Creating table 'NewsComments'
CREATE TABLE [dbo].[NewsComments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NewsId] nvarchar(50)  NULL,
    [Msg] nvarchar(max)  NULL,
    [CrDateTime] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserInfo'
ALTER TABLE [dbo].[UserInfo]
ADD CONSTRAINT [PK_UserInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [userid] in table 'UserMSG'
ALTER TABLE [dbo].[UserMSG]
ADD CONSTRAINT [PK_UserMSG]
    PRIMARY KEY CLUSTERED ([userid] ASC);
GO

-- Creating primary key on [Id] in table 'News'
ALTER TABLE [dbo].[News]
ADD CONSTRAINT [PK_News]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NewsComments'
ALTER TABLE [dbo].[NewsComments]
ADD CONSTRAINT [PK_NewsComments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------