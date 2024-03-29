USE [master]
GO
/****** Object:  Database [Technology]    Script Date: 12/11/2019 5:16:16 PM ******/
CREATE DATABASE [Technology]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Technology', FILENAME = N'D:\Programi\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Technology.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Technology_log', FILENAME = N'D:\Programi\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Technology_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Technology] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Technology].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Technology] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Technology] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Technology] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Technology] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Technology] SET ARITHABORT OFF 
GO
ALTER DATABASE [Technology] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Technology] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Technology] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Technology] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Technology] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Technology] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Technology] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Technology] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Technology] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Technology] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Technology] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Technology] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Technology] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Technology] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Technology] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Technology] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Technology] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Technology] SET RECOVERY FULL 
GO
ALTER DATABASE [Technology] SET  MULTI_USER 
GO
ALTER DATABASE [Technology] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Technology] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Technology] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Technology] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Technology] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Technology', N'ON'
GO
ALTER DATABASE [Technology] SET QUERY_STORE = OFF
GO
USE [Technology]
GO
/****** Object:  Table [dbo].[Proizvod]    Script Date: 12/11/2019 5:16:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proizvod](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [nvarchar](50) NOT NULL,
	[opis] [nvarchar](50) NOT NULL,
	[kategorija] [nvarchar](50) NOT NULL,
	[proizvodjac] [nvarchar](50) NOT NULL,
	[dobavljac] [nvarchar](50) NOT NULL,
	[cena] [float] NOT NULL,
 CONSTRAINT [PK_Proizvod] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Proizvod] ON 

INSERT [dbo].[Proizvod] ([id], [naziv], [opis], [kategorija], [proizvodjac], [dobavljac], [cena]) VALUES (1, N'NZXT H500i', N'kaljeno staklo', N'kuciste', N'NZXT', N'Gigatron', 14000)
INSERT [dbo].[Proizvod] ([id], [naziv], [opis], [kategorija], [proizvodjac], [dobavljac], [cena]) VALUES (2, N'Ryzen 5 3600', N'7nm', N'procesor', N'AMD', N'Emmi', 27000)
INSERT [dbo].[Proizvod] ([id], [naziv], [opis], [kategorija], [proizvodjac], [dobavljac], [cena]) VALUES (3, N'GTX 1660Ti', N'6GB', N'graficka karta', N'Gigabyte', N'Emmi', 44000)
INSERT [dbo].[Proizvod] ([id], [naziv], [opis], [kategorija], [proizvodjac], [dobavljac], [cena]) VALUES (4, N'i7-9700', N'14nm', N'procesor', N'INTEL', N'Gigatron', 52000)
SET IDENTITY_INSERT [dbo].[Proizvod] OFF
USE [master]
GO
ALTER DATABASE [Technology] SET  READ_WRITE 
GO
