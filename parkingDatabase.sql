USE [master]
GO
/****** Object:  Database [AdvanceProgrammingDB]    Script Date: 30/10/2020 9:21:16 AM ******/
CREATE DATABASE [AdvanceProgrammingDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AdvanceProgrammingDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AdvanceProgrammingDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AdvanceProgrammingDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AdvanceProgrammingDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AdvanceProgrammingDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AdvanceProgrammingDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AdvanceProgrammingDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET  MULTI_USER 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AdvanceProgrammingDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AdvanceProgrammingDB] SET QUERY_STORE = OFF
GO
USE [AdvanceProgrammingDB]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 30/10/2020 9:21:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[type] [varchar](50) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffInfo]    Script Date: 30/10/2020 9:21:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffInfo](
	[username] [varchar](50) NOT NULL,
	[fullname] [nvarchar](50) NULL,
	[gender] [nvarchar](10) NULL,
	[profilePic] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statistical]    Script Date: 30/10/2020 9:21:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statistical](
	[cardID] [varchar](30) NULL,
	[timeIn] [datetime] NULL,
	[timeOut] [datetime] NULL,
	[type] [varchar](30) NULL,
	[money] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentTable]    Script Date: 30/10/2020 9:21:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentTable](
	[cardID] [varchar](30) NULL,
	[time] [datetime] NULL,
	[image] [varchar](30) NULL,
	[status] [varchar](30) NULL,
	[type] [varchar](30) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[StaffInfo]  WITH CHECK ADD  CONSTRAINT [FK_StaffInfo_Staff] FOREIGN KEY([username])
REFERENCES [dbo].[Staff] ([username])
GO
ALTER TABLE [dbo].[StaffInfo] CHECK CONSTRAINT [FK_StaffInfo_Staff]
GO
USE [master]
GO
ALTER DATABASE [AdvanceProgrammingDB] SET  READ_WRITE 
GO
