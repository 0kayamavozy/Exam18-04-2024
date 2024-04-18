USE [master]
GO
/****** Object:  Database [BeautyShop]    Script Date: 18.04.2024 14:56:35 ******/
CREATE DATABASE [BeautyShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BeautyShop', FILENAME = N'C:\Users\0_311_5\BeautyShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BeautyShop_log', FILENAME = N'C:\Users\0_311_5\BeautyShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BeautyShop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BeautyShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BeautyShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BeautyShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BeautyShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BeautyShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BeautyShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [BeautyShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BeautyShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BeautyShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BeautyShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BeautyShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BeautyShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BeautyShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BeautyShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BeautyShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BeautyShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BeautyShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BeautyShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BeautyShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BeautyShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BeautyShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BeautyShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BeautyShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BeautyShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BeautyShop] SET  MULTI_USER 
GO
ALTER DATABASE [BeautyShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BeautyShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BeautyShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BeautyShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BeautyShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BeautyShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BeautyShop] SET QUERY_STORE = OFF
GO
USE [BeautyShop]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 18.04.2024 14:56:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameSurnamePatronymic] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuestBook]    Script Date: 18.04.2024 14:56:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuestBook](
	[Comment] [nvarchar](max) NULL,
	[date] [date] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hairdress]    Script Date: 18.04.2024 14:56:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hairdress](
	[Name] [nvarchar](255) NULL,
	[Cost] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MakeUp]    Script Date: 18.04.2024 14:56:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MakeUp](
	[Name] [nvarchar](max) NULL,
	[Cost] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MyOrders]    Script Date: 18.04.2024 14:56:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MyOrders](
	[SurnameNamePatronymic] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Date] [date] NULL,
	[Master] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nails]    Script Date: 18.04.2024 14:56:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nails](
	[Name] [nvarchar](255) NULL,
	[Cost] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Solarium]    Script Date: 18.04.2024 14:56:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Solarium](
	[Name] [nvarchar](255) NULL,
	[Cost] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SPA]    Script Date: 18.04.2024 14:56:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SPA](
	[Name] [nvarchar](255) NULL,
	[Cost] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 18.04.2024 14:56:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workers](
	[Уникальный_код] [int] IDENTITY(1,1) NOT NULL,
	[Фамилия_Имя_Отчество] [nvarchar](max) NULL,
	[Номер_Телефона] [nvarchar](max) NULL,
	[Должность] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [BeautyShop] SET  READ_WRITE 
GO
