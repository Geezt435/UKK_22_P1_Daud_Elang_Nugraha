USE [master]
GO
/****** Object:  Database [db_22_P1_Daud_Elang_Nugraha]    Script Date: 5/25/2022 2:48:05 PM ******/
CREATE DATABASE [db_22_P1_Daud_Elang_Nugraha]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_perjalanan', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_perjalanan.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_perjalanan_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_perjalanan_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_22_P1_Daud_Elang_Nugraha].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET  MULTI_USER 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET DELAYED_DURABILITY = DISABLED 
GO
USE [db_22_P1_Daud_Elang_Nugraha]
GO
/****** Object:  Table [dbo].[tb_perjalanan]    Script Date: 5/25/2022 2:48:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_perjalanan](
	[id_perjalanan] [varchar](7) NOT NULL,
	[tanggal] [date] NULL,
	[waktu] [varchar](5) NULL,
	[lokasi] [varchar](50) NULL,
	[suhu] [decimal](3, 1) NULL,
 CONSTRAINT [PK_perjalanan] PRIMARY KEY CLUSTERED 
(
	[id_perjalanan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_user]    Script Date: 5/25/2022 2:48:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_user](
	[nik] [int] NOT NULL,
	[username] [varchar](20) NULL,
	[hak] [char](5) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[nik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tb_perjalanan] ([id_perjalanan], [tanggal], [waktu], [lokasi], [suhu]) VALUES (N'PRJ-001', CAST(N'2023-10-14' AS Date), N'20:00', N'Samarinda', CAST(35.5 AS Decimal(3, 1)))
INSERT [dbo].[tb_perjalanan] ([id_perjalanan], [tanggal], [waktu], [lokasi], [suhu]) VALUES (N'PRJ-002', CAST(N'2022-04-25' AS Date), N'24:00', N'Balikpapan', CAST(32.6 AS Decimal(3, 1)))
INSERT [dbo].[tb_perjalanan] ([id_perjalanan], [tanggal], [waktu], [lokasi], [suhu]) VALUES (N'PRJ-003', CAST(N'2022-04-25' AS Date), N'12:15', N'PT. Indofood', CAST(34.8 AS Decimal(3, 1)))
INSERT [dbo].[tb_perjalanan] ([id_perjalanan], [tanggal], [waktu], [lokasi], [suhu]) VALUES (N'PRJ-004', CAST(N'2003-03-03' AS Date), N'16:10', N'Samarinda', CAST(46.8 AS Decimal(3, 1)))
INSERT [dbo].[tb_perjalanan] ([id_perjalanan], [tanggal], [waktu], [lokasi], [suhu]) VALUES (N'PRJ-005', CAST(N'2022-04-26' AS Date), N'06:50', N'Semarang', CAST(36.5 AS Decimal(3, 1)))
INSERT [dbo].[tb_perjalanan] ([id_perjalanan], [tanggal], [waktu], [lokasi], [suhu]) VALUES (N'PRJ-006', CAST(N'2022-04-27' AS Date), N'16:45', N'Tenggarong', CAST(34.6 AS Decimal(3, 1)))
INSERT [dbo].[tb_perjalanan] ([id_perjalanan], [tanggal], [waktu], [lokasi], [suhu]) VALUES (N'PRJ-007', CAST(N'2022-04-27' AS Date), N'10:15', N'Jakarta', CAST(36.4 AS Decimal(3, 1)))
INSERT [dbo].[tb_perjalanan] ([id_perjalanan], [tanggal], [waktu], [lokasi], [suhu]) VALUES (N'PRJ-008', CAST(N'2024-06-22' AS Date), N'01:05', N'Jogyakarta', CAST(33.5 AS Decimal(3, 1)))
INSERT [dbo].[tb_perjalanan] ([id_perjalanan], [tanggal], [waktu], [lokasi], [suhu]) VALUES (N'PRJ-009', CAST(N'2022-05-09' AS Date), N'05:12', N'Samarinda', CAST(34.5 AS Decimal(3, 1)))
INSERT [dbo].[tb_perjalanan] ([id_perjalanan], [tanggal], [waktu], [lokasi], [suhu]) VALUES (N'PRJ-010', CAST(N'2022-05-12' AS Date), N'24:59', N'Samarinda', CAST(34.5 AS Decimal(3, 1)))
INSERT [dbo].[tb_perjalanan] ([id_perjalanan], [tanggal], [waktu], [lokasi], [suhu]) VALUES (N'PRJ-011', CAST(N'2022-05-12' AS Date), N'04:07', N'Balikpapan', CAST(35.5 AS Decimal(3, 1)))
INSERT [dbo].[tb_user] ([nik], [username], [hak]) VALUES (112233, N'Tester', N'membr')
INSERT [dbo].[tb_user] ([nik], [username], [hak]) VALUES (123123, N'GeeztJeez', N'admin')
INSERT [dbo].[tb_user] ([nik], [username], [hak]) VALUES (131313, N'Daud', N'admin')
INSERT [dbo].[tb_user] ([nik], [username], [hak]) VALUES (333333, N'Nugraha', N'admin')
INSERT [dbo].[tb_user] ([nik], [username], [hak]) VALUES (444422, N'Tester', N'membr')
INSERT [dbo].[tb_user] ([nik], [username], [hak]) VALUES (454545, N'Test45', N'membr')
INSERT [dbo].[tb_user] ([nik], [username], [hak]) VALUES (666666, N'Serpent', N'membr')
USE [master]
GO
ALTER DATABASE [db_22_P1_Daud_Elang_Nugraha] SET  READ_WRITE 
GO
