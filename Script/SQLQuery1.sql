appsUSE [master]
GO
/****** Object:  Database [OnlineTutor]    Script Date: 8/28/2018 5:13:31 PM ******/
CREATE DATABASE [OnlineTutor]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OnlineTutor', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\OnlineTutor.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OnlineTutor_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\OnlineTutor_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OnlineTutor] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OnlineTutor].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OnlineTutor] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OnlineTutor] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OnlineTutor] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OnlineTutor] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OnlineTutor] SET ARITHABORT OFF 
GO
ALTER DATABASE [OnlineTutor] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OnlineTutor] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OnlineTutor] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OnlineTutor] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OnlineTutor] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OnlineTutor] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OnlineTutor] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OnlineTutor] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OnlineTutor] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OnlineTutor] SET  ENABLE_BROKER 
GO
ALTER DATABASE [OnlineTutor] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OnlineTutor] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OnlineTutor] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OnlineTutor] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OnlineTutor] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OnlineTutor] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [OnlineTutor] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OnlineTutor] SET RECOVERY FULL 
GO
ALTER DATABASE [OnlineTutor] SET  MULTI_USER 
GO
ALTER DATABASE [OnlineTutor] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OnlineTutor] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OnlineTutor] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OnlineTutor] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [OnlineTutor] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'OnlineTutor', N'ON'
GO
USE [OnlineTutor]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/28/2018 5:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 8/28/2018 5:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[ParentId] [int] NULL,
	[ProgramListId] [int] NOT NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[CreatorUserId] [bigint] NULL,
	[LastModificationTime] [datetime2](7) NULL,
	[LastModifierUserId] [bigint] NULL,
	[CategoryOrder] [int] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CBTContent]    Script Date: 8/28/2018 5:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CBTContent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AllowMultipleChoice] [bit] NOT NULL,
	[CBTContentOrder] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Code] [nvarchar](max) NULL,
	[Comment] [nvarchar](max) NULL,
	[ContentTypeId] [int] NOT NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[CreatorUserId] [bigint] NULL,
	[Description] [nvarchar](max) NULL,
	[IncludeComment] [bit] NOT NULL,
	[LastModificationTime] [datetime2](7) NULL,
	[LastModifierUserId] [bigint] NULL,
	[OnlyNumericValue] [bit] NOT NULL,
	[PrecedingCBTContentId] [int] NULL,
	[Required] [bit] NOT NULL,
	[FileName] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
 CONSTRAINT [PK_CBTContent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CBTContentOption]    Script Date: 8/28/2018 5:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CBTContentOption](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CBTContentId] [int] NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[CreatorUserId] [bigint] NULL,
	[DataType] [nvarchar](max) NULL,
	[LastModificationTime] [datetime2](7) NULL,
	[LastModifierUserId] [bigint] NULL,
	[OptionValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_CBTContentOption] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContentType]    Script Date: 8/28/2018 5:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContentType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContentName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[CreatorUserId] [bigint] NULL,
	[LastModificationTime] [datetime2](7) NULL,
	[LastModifierUserId] [bigint] NULL,
 CONSTRAINT [PK_ContentType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramList]    Script Date: 8/28/2018 5:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Feedback] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[ProgramCount] [int] NOT NULL,
	[ProgramLastDate] [datetime2](7) NOT NULL,
	[ProgramTypeId] [int] NOT NULL,
	[Status] [nvarchar](max) NULL,
	[UniqueId] [nvarchar](max) NULL,
	[UserTypeId] [int] NOT NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[CreatorUserId] [bigint] NULL,
	[LastModificationTime] [datetime2](7) NULL,
	[LastModifierUserId] [bigint] NULL,
 CONSTRAINT [PK_ProgramList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramType]    Script Date: 8/28/2018 5:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[CreatorUserId] [bigint] NULL,
	[LastModificationTime] [datetime2](7) NULL,
	[LastModifierUserId] [bigint] NULL,
 CONSTRAINT [PK_ProgramType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 8/28/2018 5:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[CreatorUserId] [bigint] NULL,
	[LastModificationTime] [datetime2](7) NULL,
	[LastModifierUserId] [bigint] NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 8/28/2018 5:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastLoginDate] [datetime2](7) NOT NULL,
	[Password] [nvarchar](max) NULL,
	[PwdChangeDays] [int] NOT NULL,
	[PwdChangeWarningDays] [int] NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[CreatorUserId] [bigint] NULL,
	[LastModificationTime] [datetime2](7) NULL,
	[LastModifierUserId] [bigint] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 8/28/2018 5:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[CreatorUserId] [bigint] NULL,
	[LastModificationTime] [datetime2](7) NULL,
	[LastModifierUserId] [bigint] NULL,
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 8/28/2018 5:13:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[CreatorUserId] [bigint] NULL,
	[LastModificationTime] [datetime2](7) NULL,
	[LastModifierUserId] [bigint] NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170622100648_Initial', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170622103741_Initial1', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170622114851_Initial_6222017', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170626092522_Initial_06262016', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170627054504_Initial_6272017', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170627055414_Initial_62720171', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170628051259_INITIAL_62817', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170628061618_INITIAL_628171', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170628072628_INITIAL_6281712', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170628090257_INITIAL_6281713', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170628092018_INITIAL_6281714', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170629110927_Initail_4582', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170629111146_Initail_45821', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170630110517_Initial_6302017', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170630110933_Initial_63020171', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170717055328_initial71717', N'1.1.1')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170721110326_Initial_7212017', N'1.1.1')
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [ParentId], [ProgramListId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [CategoryOrder]) VALUES (1, N'FIRST SECTION', N'PROGRAM TESTING', NULL, 1012, CAST(N'2017-06-28T10:59:33.7091487' AS DateTime2), NULL, CAST(N'2017-07-24T11:59:41.0052844' AS DateTime2), NULL, 0)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [ParentId], [ProgramListId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [CategoryOrder]) VALUES (3, N'SECOND SECTION', N'PROGRAM TESTING', 1, 1019, CAST(N'2017-06-28T11:19:11.1479012' AS DateTime2), NULL, CAST(N'2017-06-28T11:21:03.7343781' AS DateTime2), NULL, 0)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [ParentId], [ProgramListId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [CategoryOrder]) VALUES (5, N'FOURTH SECTION', N'FOURTH', NULL, 1012, CAST(N'2017-06-30T16:36:06.2814352' AS DateTime2), NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [ParentId], [ProgramListId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [CategoryOrder]) VALUES (6, N'GENERAL QUESTION', N'GENERAL', NULL, 1020, CAST(N'2017-07-03T09:23:27.4137431' AS DateTime2), NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [ParentId], [ProgramListId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [CategoryOrder]) VALUES (7, N'BASIC', N'BASIC', NULL, 1021, CAST(N'2017-07-17T09:34:46.3136592' AS DateTime2), NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [ParentId], [ProgramListId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [CategoryOrder]) VALUES (8, N'MID-LEVEL', N'MID-LEVEL', NULL, 1021, CAST(N'2017-07-17T09:35:07.2128568' AS DateTime2), NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [ParentId], [ProgramListId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [CategoryOrder]) VALUES (9, N'ADVANCED', N'ADVANCED', NULL, 1021, CAST(N'2017-07-17T09:35:19.9556012' AS DateTime2), NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [ParentId], [ProgramListId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [CategoryOrder]) VALUES (10, N'Electrical Work Specialties', N'Electrical Work Specialties', NULL, 1021, CAST(N'2017-07-17T11:04:19.5203360' AS DateTime2), NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [ParentId], [ProgramListId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [CategoryOrder]) VALUES (11, N'Inside Wiremen', N'Inside Wiremen', NULL, 1021, CAST(N'2017-07-17T11:04:36.9607730' AS DateTime2), NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [ParentId], [ProgramListId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [CategoryOrder]) VALUES (12, N'Outside Linemen', N'Outside Linemen', NULL, 1021, CAST(N'2017-07-17T11:04:51.5907752' AS DateTime2), NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [ParentId], [ProgramListId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [CategoryOrder]) VALUES (13, N'Residential Wiremen', N'Residential Wiremen', NULL, 1021, CAST(N'2017-07-17T11:05:12.3446120' AS DateTime2), NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [ParentId], [ProgramListId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [CategoryOrder]) VALUES (14, N'Telecommunications Installer-Technicians', N'Telecommunications Installer-Technicians', NULL, 1021, CAST(N'2017-07-17T11:16:31.3252162' AS DateTime2), NULL, NULL, NULL, 0)
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [Description], [ParentId], [ProgramListId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId], [CategoryOrder]) VALUES (15, N'Abilities Checklist', N'Abilities Checklist', NULL, 1021, CAST(N'2017-07-17T11:16:45.0057851' AS DateTime2), NULL, NULL, NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[CBTContent] ON 
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (1, 0, 0, 1, N'C100', NULL, 1, CAST(N'2017-06-28T13:12:42.8567158' AS DateTime2), NULL, N'THIS IS TEST QUESTION FOR SURVEY PURPOSE. UPDATED', 0, CAST(N'2017-07-03T12:27:52.2457666' AS DateTime2), NULL, 0, NULL, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (24, 1, 0, 1, N'CR9999', NULL, 3, CAST(N'2017-06-29T17:10:41.0849738' AS DateTime2), NULL, N'<p>THIS S NEW TEST</p>
', 1, CAST(N'2017-07-20T15:30:01.4692266' AS DateTime2), NULL, 0, 1, 1, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (27, 0, 0, 1, N'RD100', NULL, 2, CAST(N'2017-06-30T09:52:30.1490458' AS DateTime2), NULL, N'<p>THIS IS FIRST QUESTION OF TYPE MULTIPLE TEXTBOX</p>
', 1, CAST(N'2017-07-20T15:30:10.2110570' AS DateTime2), NULL, 0, 24, 1, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (28, 1, 0, 1, N'RD200', NULL, 3, CAST(N'2017-06-30T09:53:50.1576098' AS DateTime2), NULL, N'THIS IS SECOND EXAMPLE FOR THE MULTIPLE CHOICE', 1, NULL, NULL, 0, 27, 1, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (29, 0, 0, 1, N'RD300', NULL, 4, CAST(N'2017-06-30T09:55:00.2117047' AS DateTime2), NULL, N'THIS IS FIRST QUESTION OF TYPE DROPDOWN', 1, NULL, NULL, 0, 28, 1, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (31, 0, 0, 5, N'CR150', NULL, 1, CAST(N'2017-06-30T16:36:36.3481362' AS DateTime2), NULL, N'<p>THIS IS SINGLE TEXT BOX TYPE QUESTION</p>
', 0, CAST(N'2017-07-20T15:31:05.3898595' AS DateTime2), NULL, 0, NULL, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (32, 0, 0, 5, N'CR160', NULL, 3, CAST(N'2017-06-30T16:38:10.5505714' AS DateTime2), NULL, N'<p>THIS IS RADIO BUTTON TYPE QUESTION</p>
', 0, CAST(N'2017-07-20T15:31:18.2111221' AS DateTime2), NULL, 0, 31, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (34, 1, 0, 6, N'S100', NULL, 3, CAST(N'2017-07-03T09:24:56.6545118' AS DateTime2), NULL, N'How do you find the cleanliness of Washroom?', 0, NULL, NULL, 0, NULL, 1, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (35, 1, 0, 6, N'S200', NULL, 3, CAST(N'2017-07-03T09:26:03.2210843' AS DateTime2), NULL, N'How do you find different areas of office like floor and common Area?', 0, NULL, NULL, 0, 34, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (36, 1, 0, 6, N'S300', NULL, 3, CAST(N'2017-07-03T09:26:58.7643970' AS DateTime2), NULL, N'What is the condition of tea/coffee area?', 0, NULL, NULL, 0, 35, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (37, 1, 0, 6, N'S400', NULL, 3, CAST(N'2017-07-03T09:28:01.6437587' AS DateTime2), NULL, N'How do you find your working desk?', 0, NULL, NULL, 0, 36, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (38, 1, 0, 6, N'S500', NULL, 3, CAST(N'2017-07-03T09:28:57.3962117' AS DateTime2), NULL, N'<p><strong>What is the condition of your floor&#39;s Basins?</strong></p>
', 0, CAST(N'2017-07-20T11:04:12.4051710' AS DateTime2), NULL, 0, 37, 1, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (39, 0, 0, 6, N'S600', NULL, 1, CAST(N'2017-07-03T09:29:51.1625475' AS DateTime2), NULL, N'Please specify the area/part of your concern for Cleanliness', 0, CAST(N'2017-07-03T09:31:51.9036532' AS DateTime2), NULL, 0, 38, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (41, 0, 0, 7, N'1', NULL, 1, CAST(N'2017-07-17T11:02:36.8703050' AS DateTime2), NULL, N'<p>The National Electrical Contractors Association (NECA) and the International Brotherhood of Electrical Workers (IBEW) jointly sponsor apprenticeship training programs that offer you the opportunity to earn wages and benefits while you learn the skills needed for a trade that can be both challenging and rewarding. You will have the chance to use your mind, as well as your physical skills, to complete work in a variety of settings with the constant opportunity to learn something new. This brochure is intended to help you make an informed decision about whether or not you would like to pursue an electrical apprenticeship. It will explain how the application process works. It has three parts: LEARNING ABOUT ELECTRICAL WORK&mdash; provides information about the work done in electrical work specialties and the abilities those specialties require. It contains an abilities checklist you can complete to determine whether or not electrical work suits you. APPLYING FOR APPRENTICESHIP &mdash; provides information about the qualification requirements and application process. It contains a reminder list to help you with the testing process. PREPARING FOR THE TEST&mdash;provides sample questions and answers from the NJATC Aptitude Test Battery, which is a part of the application process.</p>
', 0, CAST(N'2017-07-20T15:31:35.9335030' AS DateTime2), NULL, 0, NULL, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (42, 0, 0, 10, N'2', NULL, 1, CAST(N'2017-07-17T11:06:20.4005274' AS DateTime2), NULL, N'What is it like to work in the electrical industry?

There are four primary specialties in electrical work:

    INSIDE WIREMEN — primarily perform electrical construction work in commercial and industrial settings.
    OUTSIDE LINEMEN — primarily perform electrical work for transmissions and distribution of electrical energy.
    RESIDENTIAL WIREMEN — primarily perform electrical construction work in residential settings.
    TELECOMMUNICATIONS INSTALLER-TECHNICIANS — primarily perform electrical installations for voice, data, video, sound, and other telecommunications areas.

By far, Inside Wiremen is the largest of the four electrical work specialties. Nationally, the Inside Wiremen position has over 200,000 Journeymen and Apprentices who are members of the IBEW. Just as important, though fewer in number, are the Outside Linemen, Residential Wiremen, and Telecommunications Installer-Technicians.

Training programs vary in length for the four electrical work specialties. Inside Wiremen apprenticeship programs are five years; Outside Linemen apprenticeship programs are three and a half years; Residential Wiremen and Telecommunications Installer-Technicians apprenticeship programs are three years.

The following pages provide additional information about each of the four specialties. An abilities checklist, designed to help you determine how well suited you are for electrical work, appears at the end of this section. ', 0, CAST(N'2017-07-17T11:06:36.7069758' AS DateTime2), NULL, 0, 41, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (43, 0, 0, 12, N'3', NULL, 1, CAST(N'2017-07-17T11:14:08.6240299' AS DateTime2), NULL, N'While Inside Wiremen install conduit, electrical wiring, fixtures, and electrical apparatus, Outside Linemen are often observed climbing poles or in bucket trucks, installing or repairing electrical power lines outdoors. Major duties of the Outside Linemen include:

    Planning and Initiating Projects
    Establishing OSHA and Customer Safety Requirements
    Setting Towers and Poles and Constructing Other Devices to Support Transmission/Distribution Cables
    Establishing Work Positions for Maintaining and Repairing Overhead Distribution or Transmission Lines
    Stringing New Wire or Maintaining Old Wire
    Installing and Maintaining Insulators
    Installing and Maintaining Transformers and Other Equipment

In performing these duties, Outside Linemen use climbing tools, hand tools, and heavy equipment on a daily basis.
Like Inside Wiremen, Outside Linemen also need to develop a great deal of technical knowledge during their apprenticeship. A recent job analysis identified 77 knowledge areas that are important for successful performance.

A few of the more important ones are knowledge of:

    How to Work With Energized Circuits
    How to Perform an Emergency Rescue
    First Aid
    Connections to Be Made For Various Transformers
    What Makes a Wooden Pole Unsafe to Climb
    Delta and Wye Transformer Connections
    Specific Job Safety Rules
    Appropriate Hand Signals to Use with Ground Crew or Equipment Operators
    The Proper Knot to Tie in Different Circumstances
    Blueprints, Including Symbols Used

Some of the most important skills to be learned are:

    Skill at Working on High Voltage Lines While Wearing Protective Equipment Such As Rubber Gloves
    Skill at Performing CPR
    Skill at Rigging Equipment
    Skill at Tying Knots
    Skill at Operating a Bucket Truck
    Skill at Splicing High Voltage Cable
    Skill at Splicing Aluminum or Copper Cable
    Skill at Driving a Truck
 ', 0, CAST(N'2017-07-17T11:14:18.6450621' AS DateTime2), NULL, 0, 42, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (44, 0, 0, 13, N'4', NULL, 1, CAST(N'2017-07-17T11:15:01.5395488' AS DateTime2), NULL, N'Residential Wiremen work solely in residential settings (single and multi-family dwellings). Major duties for Residential Wiremen include:

    Planning and Initiating Projects
    Establishing Temporary Power during Construction
    Establishing Grounding Systems
    Installing Underground Systems (Slab/Foundation)
    Rough-In (Frame Stage)
    Installing Wire and Cable
    Trim Out
    Performing “Hot” Checks
    Troubleshooting and Repairing Electrical Systems

In performing these duties, Residential Wiremen must use many different kinds of tools, ranging from simple ones and two-hand tools (such as screwdrivers and cable cutters) to power-assisted tools like electric drills and screw guns. They occasionally operate heavy equipment such as trenchers.

Over the course of the three-year Residential Wiremen apprenticeship program, apprentices must become competent in many technical areas. A recent job analysis identified 85 specific areas of knowledge that are important for Residential Wiremen job performance.

A few of the most important ones are knowledge of:

    The National Electrical Code
    How to Work With Energized Circuits
    Blueprints, Including Symbols Used
    Electrical Schematic Diagrams
    State and Local Electrical Codes
    The Principles of Grounding
    First Aid
    Hazardous Materials
    Specific Job Safety Rules
    Proper Wire/Cable to Use in Different Circumstances

Some of the most important skills to be learned are:

    Skill at Performing CPR
    Skill at Reading a Wire Table to Determine Conductor Size Required
    Skill at Terminating Aluminum or Copper Cable
    Skill at Splicing Twisted Pair Cable
    Skill at Terminating Twisted Pair Cable
    Skill at Terminating Coaxial Cable', 0, CAST(N'2017-07-17T11:15:55.9677177' AS DateTime2), NULL, 0, 43, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (45, 0, 0, 14, N'5', NULL, 1, CAST(N'2017-07-17T11:17:21.7040110' AS DateTime2), NULL, N'Telecommunications Installer-Technicians install circuits and equipment for telephones, computer networks, video distribution systems, security and access control systems, and other low voltage systems. Major duties for Telecommunications Installer-Technicians include:

    Planning and Initiating Projects
    Installing Underground Voice or Data Circuit Feeders to Entrance Facilities
    Providing or Connecting to the Grounding Electrode System
    Installing Pathways and Spaces for Installation of Low Voltage Wiring
    Installing and Terminating Wires and Cables
    Installing Local Area Network (LAN) Cabling Systems
    Installing Security and Access Control Systems
    Installing Communications and Sound Distribution Systems
    Testing and Repairing Video, Voice, and Data Systems

In performing these duties, Telecommunications Installer Technicians must use many different kinds of tools, ranging from simple ones and two-hand tools (such as screwdrivers and cable cutters) to power-assisted tools like electric drills and screw guns. They occasionally operate heavy equipment such as trenchers.

Over the course of the three-year Telecommunications Installer- Technicians apprenticeship program, apprentices must become competent in many technical areas. A recent job analysis identified 124 specific areas of knowledge that are important for Telecommunications Installer-Technicians’ job performance. A few of the most important ones are knowledge of:

    Color Codes (Proper Termination Sequence)
    Structured Wiring
    Cable Testing Requirements and Standards
    Local Area Networks (LAN)
    The Basics of Telephony
    Blueprints, Including Symbols Used
    Electronic Industries Association (EIA)/Telecommunications Industry Association (TIA) Standards
    The Principles of Grounding
    First Aid
    Hazardous Materials
    Proper Wire/Cable to Use in Different Circumstances

Some of the most important skills to be learned are:

    Skill at Terminating Twisted Pair Cable
    Skill at Terminating Fiber Optic Cable
    Skill at Troubleshooting Through Segmentation and Isolation
    Skill at Diagnosing the Source of Equipment Malfunctions
    Skill at Splicing Copper, Coaxial and Fiber Optic Cable
    Skill at Performing CPR

', 0, CAST(N'2017-07-17T11:17:45.3746971' AS DateTime2), NULL, 0, 44, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (46, 0, 0, 15, N'6', NULL, 1, CAST(N'2017-07-17T11:18:10.4349311' AS DateTime2), NULL, N'Electrical work can be challenging, complex, physically demanding, and very rewarding. We have found that applicants who have not worked on construction projects, received specific training, or who do not have friends or relatives in the industry are often unfamiliar with the wide range of tasks electrical workers perform, or the skills needed today to be a successful electrical worker. NJATC has prepared the following checklist to help prospective applicants measure their interest in day-today electrical work, and whether they will have the ability to succeed at the completion of their apprenticeship.

Thirty-five core abilities that are important for all four electrical worker specialties are listed on the following pages.

The boxes to the left provide space to indicate your interest, as well as your capability, to perform the ability. If you are interested in performing work that requires the ability, place a checkmark under the column labeled “Interest.” If you believe that you are capable of performing work that requires the ability, place a checkmark in the “Capability” column. In a few cases you might be unsure about your capability, especially if you have not worked with blueprints or technical documents. Consider your interest and capability based upon similar activities, such as automotive repair.

Interest Capability Ability to..

    add, subtract, multiply, divide, and use algebraic formulas
    read complex technical documents written in English
    develop alternative solutions to a problem and choose the best alternative
    communicate in writing with others
    read and understand graphs, charts, and diagrams
    plan and organize tasks to meet deadlines
    understand how an electrical or mechanical system works
    picture the way a construction project will appear before it is finished
    be self-motivated, responsible, and dependable without close supervision
    remain calm in an emergency situation
    communicate orally with others in English
    work smoothly with others as a team to complete a task
    maintain good relations with others in a work setting
    discriminate between colors
    understand verbal instructions and warnings given in English
    hear warning signals
    maintain balance and perform construction tasks while on a ladder
    coordinate body movements when using tools or equipment
    reach and stretch to position equipment and fixtures while maintaining balance
    bend or twist the body into unusual positions while working
    traverse irregular surfaces while maintaining balance
    perform physical tasks all day without becoming overly tired
    use hands to manipulate small wires and objects
    work with both hands
    operate two-handed power equipment
    regularly lift objects weighing up to 50 pounds
    on occasion, lift objects weighing above
    pounds carry objects weighing up to 50 pounds for short distances
    apply muscular force quickly to objects and equipment
    push or pull heavy objects into position
    climb ladders and poles up to 25 feet in height
    work at heights
    work in extreme hot and cold temperature conditions
    work in a noisy environment
    work at depths, such as in trenches, manholes or deep vertical shaft

A particular employer might not require every one of these abilities for every electrical worker, and the importance of each may vary by the type of electrical job or employer and the level of experience. Many electrical contractors are required by federal or state law to consider making reasonable accommodations for otherwise qualified employees with disabilities, and in some cases accommodations might be available. Our research has shown, however, that the listed abilities are significant on most job sites, and they are all usually needed in order to perform the essential functions of the job of an electrical worker. That is why all of these abilities, and others, are usually viewed by the NJATC as necessary to successful completion of any electrical apprenticeship program.

If you checked interest and/or capability in many of the abilities, you may be well suited for electrical work. If you checked relatively few abilities, or were unsure about checking them, you should take steps to learn more about electrical work. The fact that you do not have or cannot acquire a particular ability does not prevent you from applying for the apprenticeship programs, but it could present a problem during your training and/or on the job. Some preparatory steps you can take include:

    Look for books on electrical construction work in the library.
    Access the NJATC website at http://www.njatc.org. It provides detailed job descriptions for the four electrical work specialties, as well as other relevant information.
    Enroll in the NJATC’s online Tech Math course. To access the course, go to http://www.njatc.utk.edu.
    Ask the Training Director at the IBEW/NECA training center in your area whether he or she could refer you to someone in the electrical industry who can answer any questions you may have.

Learning more about the work done by electrical workers will help you determine how well suited you are for a career in electrical construction.', 0, CAST(N'2017-07-17T11:18:34.4803428' AS DateTime2), NULL, 0, 45, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (47, 0, 0, 6, N'S700', NULL, 2, CAST(N'2017-07-20T09:51:14.3655937' AS DateTime2), NULL, N'<p><strong>Please specify your details</strong></p>
', 0, CAST(N'2017-07-20T15:31:55.2153829' AS DateTime2), NULL, 0, 39, 1, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (48, 0, 0, 6, N'S800', NULL, 4, CAST(N'2017-07-20T09:52:45.1882961' AS DateTime2), NULL, N'<p>WHAT IS YOUR HIGHEST LEVEL OF EDUCATION</p>
', 0, CAST(N'2017-07-20T15:32:06.0724930' AS DateTime2), NULL, 0, 47, 0, NULL, NULL)
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (51, 0, 0, 1, N'RD400', NULL, 7, CAST(N'2017-07-21T17:01:56.4011743' AS DateTime2), NULL, N'<p>THIS IS TEST DOCUMENT UPLOADED FOR TESTING PURPOSE.</p>
', 0, CAST(N'2017-07-24T10:45:44.2000413' AS DateTime2), NULL, 0, 29, 0, N'334d1b95-fa71-4638-8881-3f7a881aacb8_index.jpg', N'D:\Projects\OnlineTutor\OnlineTutor\src\CBT.OnlineTutor.Web\wwwroot\UploadedFiles\334d1b95-fa71-4638-8881-3f7a881aacb8_index.jpg')
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (52, 0, 0, 1, N'RD500', NULL, 7, CAST(N'2017-07-21T17:15:49.3312031' AS DateTime2), NULL, N'<p>TET</p>
', 0, CAST(N'2017-07-24T11:15:24.7519614' AS DateTime2), NULL, 0, 51, 0, N'7e1902d0-1d6f-469d-bfbf-194c9486e4ae_index2.jpg', N'D:\Projects\OnlineTutor\OnlineTutor\src\CBT.OnlineTutor.Web\wwwroot\UploadedFiles\7e1902d0-1d6f-469d-bfbf-194c9486e4ae_index2.jpg')
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (53, 0, 0, 1, N'RD600', NULL, 7, CAST(N'2017-07-21T17:18:51.6680918' AS DateTime2), NULL, N'<p>TESSSS</p>
', 0, CAST(N'2017-07-24T10:46:30.4934513' AS DateTime2), NULL, 0, 52, 0, N'ffbaa50b-c79e-4c04-a2bf-c5d384467212_index1.jpg', N'D:\Projects\OnlineTutor\OnlineTutor\src\CBT.OnlineTutor.Web\wwwroot\UploadedFiles\ffbaa50b-c79e-4c04-a2bf-c5d384467212_index1.jpg')
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (54, 0, 0, 1, N'RD700', NULL, 6, CAST(N'2017-07-21T17:30:15.5058849' AS DateTime2), NULL, N'<p>THIS IS FIRST AUDIO SAMPLE.</p>
', 0, CAST(N'2017-07-24T09:48:25.3219391' AS DateTime2), NULL, 0, 53, 0, N'efed805d-a3f1-4084-b75d-0e1b586676aa_SampleAudio_0.4mb.mp3', N'D:\Projects\OnlineTutor\OnlineTutor\src\CBT.OnlineTutor.Web\wwwroot\UploadedFiles\efed805d-a3f1-4084-b75d-0e1b586676aa_SampleAudio_0.4mb.mp3')
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (55, 0, 0, 1, N'RD800', NULL, 5, CAST(N'2017-07-24T09:46:31.7621751' AS DateTime2), NULL, N'<p>THIS IS VIDEO SAMPLE FOR TEST PURPOSE.</p>
', 0, CAST(N'2017-07-24T12:31:44.5631943' AS DateTime2), NULL, 0, 54, 0, N'0c15ec8f-2cad-4306-94e1-99fb1cf51814_SampleVideo_1280x720_1mb.mp4', N'D:\Projects\OnlineTutor\OnlineTutor\src\CBT.OnlineTutor.Web\wwwroot\UploadedFiles\0c15ec8f-2cad-4306-94e1-99fb1cf51814_SampleVideo_1280x720_1mb.mp4')
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (56, 0, 0, 1, N'RD900', NULL, 5, CAST(N'2017-07-24T12:46:29.5885864' AS DateTime2), NULL, N'<p>LARGE VIDEO FILE SIZE TESTING FOR UPLOAD.</p>
', 0, NULL, NULL, 0, 55, 0, N'a2451c56-ab88-4a55-8b09-29c3fc18f887_SampleVideo_1280x720_5mb.mp4', N'D:\Projects\OnlineTutor\OnlineTutor\src\CBT.OnlineTutor.Web\wwwroot\UploadedFiles\a2451c56-ab88-4a55-8b09-29c3fc18f887_SampleVideo_1280x720_5mb.mp4')
GO
INSERT [dbo].[CBTContent] ([Id], [AllowMultipleChoice], [CBTContentOrder], [CategoryId], [Code], [Comment], [ContentTypeId], [CreationTime], [CreatorUserId], [Description], [IncludeComment], [LastModificationTime], [LastModifierUserId], [OnlyNumericValue], [PrecedingCBTContentId], [Required], [FileName], [Location]) VALUES (57, 0, 0, 6, N'S900', NULL, 1, CAST(N'2017-07-24T13:06:52.7372211' AS DateTime2), NULL, N'<p>WHAT IS YOUR AGE?</p>
', 0, NULL, NULL, 1, 48, 0, N'', N'')
GO
SET IDENTITY_INSERT [dbo].[CBTContent] OFF
GO
SET IDENTITY_INSERT [dbo].[CBTContentOption] ON 
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (4, 24, CAST(N'2017-06-29T17:10:44.7271869' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'TEST1')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (5, 24, CAST(N'2017-06-29T17:10:46.5582891' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'TEST2')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (9, 27, CAST(N'2017-06-30T09:52:30.1520380' AS DateTime2), NULL, N'DATETIME', NULL, NULL, N'DATE OF BIRTH')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (10, 27, CAST(N'2017-06-30T09:52:30.1520380' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'PLACE OF BIRTH')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (11, 27, CAST(N'2017-06-30T09:52:30.1520380' AS DateTime2), NULL, N'NUMERIC', NULL, NULL, N'AGE')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (12, 28, CAST(N'2017-06-30T09:53:50.1576098' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'APPLE')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (13, 28, CAST(N'2017-06-30T09:53:50.1576098' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'ORANGE')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (14, 29, CAST(N'2017-06-30T09:55:00.2117047' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'DROP1')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (15, 29, CAST(N'2017-06-30T09:55:00.2117047' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'DROP2')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (16, 29, CAST(N'2017-06-30T09:55:00.2117047' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'DROP3')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (17, 32, CAST(N'2017-06-30T16:38:10.5505714' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'VEG')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (18, 32, CAST(N'2017-06-30T16:38:10.5516004' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'NON-VEG')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (22, 34, CAST(N'2017-07-03T09:24:56.6575376' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Excellent')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (23, 34, CAST(N'2017-07-03T09:24:56.6575376' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Acceptable')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (24, 34, CAST(N'2017-07-03T09:24:56.6575376' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Concern Required')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (25, 35, CAST(N'2017-07-03T09:26:03.2210843' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Excellent')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (26, 35, CAST(N'2017-07-03T09:26:03.2210843' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Acceptable')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (27, 35, CAST(N'2017-07-03T09:26:03.2210843' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Concern Required')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (28, 36, CAST(N'2017-07-03T09:26:58.7643970' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Excellent')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (29, 36, CAST(N'2017-07-03T09:26:58.7643970' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Acceptable')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (30, 36, CAST(N'2017-07-03T09:26:58.7643970' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Concern Required')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (31, 37, CAST(N'2017-07-03T09:28:01.6437587' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Excellent')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (32, 37, CAST(N'2017-07-03T09:28:01.6437587' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Acceptable')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (33, 37, CAST(N'2017-07-03T09:28:01.6437587' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Concern Required')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (34, 38, CAST(N'2017-07-03T09:28:57.3962117' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Excellent')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (35, 38, CAST(N'2017-07-03T09:28:57.3962117' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Acceptable')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (36, 38, CAST(N'2017-07-03T09:28:57.3962117' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Concern Required')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (37, 47, CAST(N'2017-07-20T09:51:14.3690942' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'Name')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (38, 47, CAST(N'2017-07-20T09:51:14.3696175' AS DateTime2), NULL, N'NUMERIC', NULL, NULL, N'Age')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (39, 47, CAST(N'2017-07-20T09:51:14.3696175' AS DateTime2), NULL, N'DATETIME', NULL, NULL, N'Date of Join')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (40, 48, CAST(N'2017-07-20T09:52:45.1882961' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'PHD')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (41, 48, CAST(N'2017-07-20T09:52:45.1882961' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'POST GRADUATE')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (42, 48, CAST(N'2017-07-20T09:52:45.1882961' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'UNDER GRADUDATE')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (43, 48, CAST(N'2017-07-20T09:52:45.1882961' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'SECONDARY')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (44, 48, CAST(N'2017-07-20T09:52:45.1882961' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'PRIMARY')
GO
INSERT [dbo].[CBTContentOption] ([Id], [CBTContentId], [CreationTime], [CreatorUserId], [DataType], [LastModificationTime], [LastModifierUserId], [OptionValue]) VALUES (45, 48, CAST(N'2017-07-20T09:52:45.1882961' AS DateTime2), NULL, N'VARCHAR', NULL, NULL, N'OTHERS')
GO
SET IDENTITY_INSERT [dbo].[CBTContentOption] OFF
GO
SET IDENTITY_INSERT [dbo].[ContentType] ON 
GO
INSERT [dbo].[ContentType] ([Id], [ContentName], [Description], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (1, N'SINGLE TEXBOX', N'SINGLE TEXBOX', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[ContentType] ([Id], [ContentName], [Description], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (2, N'MULTIPLE TEXBOX', N'MULTIPLE TEXBOX', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[ContentType] ([Id], [ContentName], [Description], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (3, N'MULTIPLE CHOICE', N'MULTIPLE CHOICE', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[ContentType] ([Id], [ContentName], [Description], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (4, N'DROPDOWN', N'DROPDOWN', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[ContentType] ([Id], [ContentName], [Description], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (5, N'VIDEO', N'VIDEO', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[ContentType] ([Id], [ContentName], [Description], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (6, N'AUDIO', N'AUDIO', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[ContentType] ([Id], [ContentName], [Description], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (7, N'IMAGE FILE', N'IMAGE FILE', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[ContentType] ([Id], [ContentName], [Description], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (8, N'ANIMATION', N'ANIMATION', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[ContentType] ([Id], [ContentName], [Description], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (9, N'INSTRUCTION', N'INSTRUCTION', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ContentType] OFF
GO
SET IDENTITY_INSERT [dbo].[ProgramList] ON 
GO
INSERT [dbo].[ProgramList] ([Id], [Description], [Feedback], [Name], [ProgramCount], [ProgramLastDate], [ProgramTypeId], [Status], [UniqueId], [UserTypeId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (1012, N'JAVRA', NULL, N'JAVRA', 0, CAST(N'2017-06-30T00:00:00.0000000' AS DateTime2), 1, N'CANCELED', N'PR200', 4, CAST(N'2017-06-27T15:10:51.8121949' AS DateTime2), NULL, CAST(N'2017-07-24T11:59:47.3203937' AS DateTime2), NULL)
GO
INSERT [dbo].[ProgramList] ([Id], [Description], [Feedback], [Name], [ProgramCount], [ProgramLastDate], [ProgramTypeId], [Status], [UniqueId], [UserTypeId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (1018, N'JAVRA COMPANY', NULL, N'MAINTENANCE SURVEY', 0, CAST(N'2017-06-30T00:00:00.0000000' AS DateTime2), 1, N'COMPLETED', N'PR300', 1, CAST(N'2017-06-27T16:40:53.8850200' AS DateTime2), NULL, CAST(N'2017-06-28T16:46:54.1344313' AS DateTime2), NULL)
GO
INSERT [dbo].[ProgramList] ([Id], [Description], [Feedback], [Name], [ProgramCount], [ProgramLastDate], [ProgramTypeId], [Status], [UniqueId], [UserTypeId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (1019, N'TRAINING PROGRAM FOR NEW EMPLOYEE', NULL, N'ORIENTATION PROGRAM', 0, CAST(N'2017-06-28T00:00:00.0000000' AS DateTime2), 1, N'NEW', N'PR400', 3, CAST(N'2017-06-28T09:28:56.9352996' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[ProgramList] ([Id], [Description], [Feedback], [Name], [ProgramCount], [ProgramLastDate], [ProgramTypeId], [Status], [UniqueId], [UserTypeId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (1020, N'JAVRA MAINTENACE PROGRAM', NULL, N'SURVEY ON OFFICE CLEANLINESS', 0, CAST(N'2017-07-07T00:00:00.0000000' AS DateTime2), 2, N'NEW', N'JVR100', 3, CAST(N'2017-07-03T09:23:06.3647801' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[ProgramList] ([Id], [Description], [Feedback], [Name], [ProgramCount], [ProgramLastDate], [ProgramTypeId], [Status], [UniqueId], [UserTypeId], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (1021, N'Electrical Industry', NULL, N'Applying and Qualifying for Apprenticeship in the Electrical Industry', 0, CAST(N'2017-07-31T00:00:00.0000000' AS DateTime2), 1, N'NEW', N'Training Program-001', 3, CAST(N'2017-07-17T09:34:18.3829882' AS DateTime2), NULL, CAST(N'2017-07-17T09:54:38.8785925' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[ProgramList] OFF
GO
SET IDENTITY_INSERT [dbo].[ProgramType] ON 
GO
INSERT [dbo].[ProgramType] ([Id], [Description], [Name], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (1, N'Training', N'Training', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[ProgramType] ([Id], [Description], [Name], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (2, N'Survey', N'Survey', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ProgramType] OFF
GO
SET IDENTITY_INSERT [dbo].[UserType] ON 
GO
INSERT [dbo].[UserType] ([Id], [Description], [Name], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (1, N'Administration', N'Administration', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[UserType] ([Id], [Description], [Name], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (2, N'Account', N'Account', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[UserType] ([Id], [Description], [Name], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (3, N'Developer', N'Developer', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[UserType] ([Id], [Description], [Name], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (4, N'Maintenance', N'Maintenance', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
INSERT [dbo].[UserType] ([Id], [Description], [Name], [CreationTime], [CreatorUserId], [LastModificationTime], [LastModifierUserId]) VALUES (5, N'Support', N'Support', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[UserType] OFF
GO
/****** Object:  Index [IX_Category_ProgramListId]    Script Date: 8/28/2018 5:13:32 PM ******/
CREATE NONCLUSTERED INDEX [IX_Category_ProgramListId] ON [dbo].[Category]
(
	[ProgramListId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CBTContent_CategoryId]    Script Date: 8/28/2018 5:13:32 PM ******/
CREATE NONCLUSTERED INDEX [IX_CBTContent_CategoryId] ON [dbo].[CBTContent]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CBTContent_ContentTypeId]    Script Date: 8/28/2018 5:13:32 PM ******/
CREATE NONCLUSTERED INDEX [IX_CBTContent_ContentTypeId] ON [dbo].[CBTContent]
(
	[ContentTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CBTContentOption_CBTContentId]    Script Date: 8/28/2018 5:13:32 PM ******/
CREATE NONCLUSTERED INDEX [IX_CBTContentOption_CBTContentId] ON [dbo].[CBTContentOption]
(
	[CBTContentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProgramList_ProgramTypeId]    Script Date: 8/28/2018 5:13:32 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProgramList_ProgramTypeId] ON [dbo].[ProgramList]
(
	[ProgramTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProgramList_UserTypeId]    Script Date: 8/28/2018 5:13:32 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProgramList_UserTypeId] ON [dbo].[ProgramList]
(
	[UserTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserRole_RoleId]    Script Date: 8/28/2018 5:13:32 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserRole_RoleId] ON [dbo].[UserRole]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserRole_UserId]    Script Date: 8/28/2018 5:13:32 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserRole_UserId] ON [dbo].[UserRole]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Category] ADD  DEFAULT ('0001-01-01T00:00:00.000') FOR [CreationTime]
GO
ALTER TABLE [dbo].[Category] ADD  DEFAULT ((0)) FOR [CategoryOrder]
GO
ALTER TABLE [dbo].[ContentType] ADD  DEFAULT ('0001-01-01T00:00:00.000') FOR [CreationTime]
GO
ALTER TABLE [dbo].[ProgramList] ADD  DEFAULT ('0001-01-01T00:00:00.000') FOR [CreationTime]
GO
ALTER TABLE [dbo].[ProgramType] ADD  DEFAULT ('0001-01-01T00:00:00.000') FOR [CreationTime]
GO
ALTER TABLE [dbo].[Role] ADD  DEFAULT ('0001-01-01T00:00:00.000') FOR [CreationTime]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT ('0001-01-01T00:00:00.000') FOR [CreationTime]
GO
ALTER TABLE [dbo].[UserRole] ADD  DEFAULT ('0001-01-01T00:00:00.000') FOR [CreationTime]
GO
ALTER TABLE [dbo].[UserType] ADD  DEFAULT ('0001-01-01T00:00:00.000') FOR [CreationTime]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_ProgramList_ProgramListId] FOREIGN KEY([ProgramListId])
REFERENCES [dbo].[ProgramList] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_ProgramList_ProgramListId]
GO
ALTER TABLE [dbo].[CBTContent]  WITH CHECK ADD  CONSTRAINT [FK_CBTContent_Category_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CBTContent] CHECK CONSTRAINT [FK_CBTContent_Category_CategoryId]
GO
ALTER TABLE [dbo].[CBTContent]  WITH CHECK ADD  CONSTRAINT [FK_CBTContent_ContentType_ContentTypeId] FOREIGN KEY([ContentTypeId])
REFERENCES [dbo].[ContentType] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CBTContent] CHECK CONSTRAINT [FK_CBTContent_ContentType_ContentTypeId]
GO
ALTER TABLE [dbo].[CBTContentOption]  WITH CHECK ADD  CONSTRAINT [FK_CBTContentOption_CBTContent_CBTContentId] FOREIGN KEY([CBTContentId])
REFERENCES [dbo].[CBTContent] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CBTContentOption] CHECK CONSTRAINT [FK_CBTContentOption_CBTContent_CBTContentId]
GO
ALTER TABLE [dbo].[ProgramList]  WITH CHECK ADD  CONSTRAINT [FK_ProgramList_ProgramType_ProgramTypeId] FOREIGN KEY([ProgramTypeId])
REFERENCES [dbo].[ProgramType] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProgramList] CHECK CONSTRAINT [FK_ProgramList_ProgramType_ProgramTypeId]
GO
ALTER TABLE [dbo].[ProgramList]  WITH CHECK ADD  CONSTRAINT [FK_ProgramList_UserType_UserTypeId] FOREIGN KEY([UserTypeId])
REFERENCES [dbo].[UserType] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProgramList] CHECK CONSTRAINT [FK_ProgramList_UserType_UserTypeId]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_Role_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_Role_RoleId]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_User_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_User_UserId]
GO
USE [master]
GO
ALTER DATABASE [OnlineTutor] SET  READ_WRITE 
GO
