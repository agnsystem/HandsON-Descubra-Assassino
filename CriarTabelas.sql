USE [dbHandsOn]
GO

/****** Object:  Table [dbo].[Arma]    Script Date: 04/01/2018 17:54:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Arma]') AND type in (N'U'))
DROP TABLE [dbo].[Arma]
GO

USE [dbHandsOn]
GO

/****** Object:  Table [dbo].[Arma]    Script Date: 04/01/2018 17:54:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Arma](
	[IdArma] [int] NULL,
	[Descricao] [nvarchar](50) NULL
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Local]    Script Date: 04/01/2018 17:54:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Local]') AND type in (N'U'))
DROP TABLE [dbo].[Local]
GO

USE [dbHandsOn]
GO

/****** Object:  Table [dbo].[Local]    Script Date: 04/01/2018 17:54:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Local](
	[IdLocal] [int] NULL,
	[Descricao] [nvarchar](50) NULL
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Suspeito]    Script Date: 04/01/2018 17:55:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Suspeito]') AND type in (N'U'))
DROP TABLE [dbo].[Suspeito]
GO

USE [dbHandsOn]
GO

/****** Object:  Table [dbo].[Suspeito]    Script Date: 04/01/2018 17:55:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Suspeito](
	[IdSuspeito] [int] NOT NULL,
	[Nome] [nvarchar](50) NULL
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador do Suspeito' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Suspeito', @level2type=N'COLUMN',@level2name=N'IdSuspeito'
GO

