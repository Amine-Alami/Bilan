USE [master]
GO
/****** Object:  Database [Bilan_local]    Script Date: 11/10/2019 16:12:02 ******/
CREATE DATABASE [Bilan_local]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bilan_local', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Bilan_local.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Bilan_local_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Bilan_local_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Bilan_local] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bilan_local].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bilan_local] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bilan_local] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bilan_local] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bilan_local] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bilan_local] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bilan_local] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Bilan_local] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bilan_local] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bilan_local] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bilan_local] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bilan_local] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bilan_local] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bilan_local] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bilan_local] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bilan_local] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Bilan_local] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bilan_local] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bilan_local] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bilan_local] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bilan_local] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bilan_local] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bilan_local] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bilan_local] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Bilan_local] SET  MULTI_USER 
GO
ALTER DATABASE [Bilan_local] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bilan_local] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bilan_local] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bilan_local] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Bilan_local] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Bilan_local]
GO
/****** Object:  Table [dbo].[Buy]    Script Date: 11/10/2019 16:12:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Buy](
	[id] [varchar](50) NOT NULL,
	[product] [varchar](50) NOT NULL,
	[price] [float] NOT NULL,
	[date_pr] [varchar](50) NOT NULL,
 CONSTRAINT [pk_buy] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 11/10/2019 16:12:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[pseudo] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NULL,
 CONSTRAINT [pk_Supplier] PRIMARY KEY CLUSTERED 
(
	[pseudo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TakeMoney]    Script Date: 11/10/2019 16:12:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TakeMoney](
	[id] [varchar](50) NOT NULL,
	[pseudo] [varchar](50) NOT NULL,
	[amount] [float] NOT NULL,
	[date_Op] [varchar](50) NOT NULL,
 CONSTRAINT [pk_take] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Buy] ([id], [product], [price], [date_pr]) VALUES (N'CVU_5654', N'medicament', 40, N'10/10/2019')
INSERT [dbo].[Buy] ([id], [product], [price], [date_pr]) VALUES (N'GIL_6673', N'decathlon', 400, N'04/10/2019')
INSERT [dbo].[Buy] ([id], [product], [price], [date_pr]) VALUES (N'GKS_0884', N'shoes', 130, N'02/10/2019')
INSERT [dbo].[Buy] ([id], [product], [price], [date_pr]) VALUES (N'JBD_1205', N'panier', 90, N'02/10/2019')
INSERT [dbo].[Buy] ([id], [product], [price], [date_pr]) VALUES (N'KCE_2742', N'disk dur', 90, N'29/09/2019')
INSERT [dbo].[Buy] ([id], [product], [price], [date_pr]) VALUES (N'PHV_2699', N'Food', 60, N'04/10/2019')
INSERT [dbo].[Buy] ([id], [product], [price], [date_pr]) VALUES (N'PTP_6043', N'back pack', 160, N'20/09/2019')
INSERT [dbo].[Buy] ([id], [product], [price], [date_pr]) VALUES (N'SFY_6684', N'medicament', 140, N'03/10/2019')
INSERT [dbo].[Buy] ([id], [product], [price], [date_pr]) VALUES (N'TQO_4611', N'Bonet + Hat + others', 100, N'09/10/2019')
INSERT [dbo].[Buy] ([id], [product], [price], [date_pr]) VALUES (N'UEH_6453', N'shoes', 100, N'25/09/2019')
INSERT [dbo].[Buy] ([id], [product], [price], [date_pr]) VALUES (N'VAW_8789', N'piscine', 450, N'03/10/2019')
INSERT [dbo].[Buy] ([id], [product], [price], [date_pr]) VALUES (N'YFD_2437', N'bus', 140, N'30/09/2019')
INSERT [dbo].[Supplier] ([pseudo], [name], [last_name]) VALUES (N'Father', N'Abdelhamid', N'Laaroussi Alami')
INSERT [dbo].[Supplier] ([pseudo], [name], [last_name]) VALUES (N'Kh houcine', N'Houcine', N'Jassani')
INSERT [dbo].[Supplier] ([pseudo], [name], [last_name]) VALUES (N'Mi', N'Kelthoum', N'Amessou')
INSERT [dbo].[Supplier] ([pseudo], [name], [last_name]) VALUES (N'Mother', N'rachida', N'Jassani')
INSERT [dbo].[Supplier] ([pseudo], [name], [last_name]) VALUES (N'Kh said', N'Said', N'Jassani')
INSERT [dbo].[TakeMoney] ([id], [pseudo], [amount], [date_Op]) VALUES (N'HNC_7614', N'Mi', 500, N'18/09/2019')
INSERT [dbo].[TakeMoney] ([id], [pseudo], [amount], [date_Op]) VALUES (N'JRW_2687', N'Mother', 550, N'02/10/2019')
INSERT [dbo].[TakeMoney] ([id], [pseudo], [amount], [date_Op]) VALUES (N'KFG_5738', N'Kh said', 200, N'23/09/2019')
INSERT [dbo].[TakeMoney] ([id], [pseudo], [amount], [date_Op]) VALUES (N'MJB_8933', N'Father', 300, N'30/09/2019')
INSERT [dbo].[TakeMoney] ([id], [pseudo], [amount], [date_Op]) VALUES (N'REM_0640', N'Mi', 100, N'08/10/2019')
INSERT [dbo].[TakeMoney] ([id], [pseudo], [amount], [date_Op]) VALUES (N'RYS_5722', N'Kh said', 400, N'02/10/2019')
INSERT [dbo].[TakeMoney] ([id], [pseudo], [amount], [date_Op]) VALUES (N'YSB_6428', N'Kh houcine', 60, N'21/09/2019')
SET ANSI_PADDING ON

GO
/****** Object:  Index [un_name]    Script Date: 11/10/2019 16:12:02 ******/
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [un_name] UNIQUE NONCLUSTERED 
(
	[name] ASC,
	[last_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TakeMoney]  WITH CHECK ADD  CONSTRAINT [fk_sup] FOREIGN KEY([pseudo])
REFERENCES [dbo].[Supplier] ([pseudo])
GO
ALTER TABLE [dbo].[TakeMoney] CHECK CONSTRAINT [fk_sup]
GO
USE [master]
GO
ALTER DATABASE [Bilan_local] SET  READ_WRITE 
GO
