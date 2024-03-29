USE [master]
GO
/****** Object:  Database [PropagendaTFE2023]    Script Date: 03-05-23 12:56:00 ******/
CREATE DATABASE [PropagendaTFE2023]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PropagendaTFE2023', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PropagendaTFE2023.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PropagendaTFE2023_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PropagendaTFE2023_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PropagendaTFE2023] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PropagendaTFE2023].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PropagendaTFE2023] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET ARITHABORT OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PropagendaTFE2023] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PropagendaTFE2023] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PropagendaTFE2023] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PropagendaTFE2023] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PropagendaTFE2023] SET  MULTI_USER 
GO
ALTER DATABASE [PropagendaTFE2023] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PropagendaTFE2023] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PropagendaTFE2023] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PropagendaTFE2023] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PropagendaTFE2023] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PropagendaTFE2023] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PropagendaTFE2023] SET QUERY_STORE = ON
GO
ALTER DATABASE [PropagendaTFE2023] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PropagendaTFE2023]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 03-05-23 12:56:00 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[EventDate] [datetime2](7) NOT NULL,
	[VenueName] [nvarchar](max) NOT NULL,
	[VenueAddress] [nvarchar](max) NOT NULL,
	[TicketsAmount] [int] NOT NULL,
	[NbSoldTickets] [int] NOT NULL,
	[TicketPrice] [int] NOT NULL,
	[ApplicationUserId] [nvarchar](450) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsApproved] [bit] NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[IsPromoted] [bit] NOT NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Providers]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Providers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Bio] [nvarchar](max) NOT NULL,
	[Link] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsApproved] [bit] NOT NULL,
	[ApplicationUserId] [nvarchar](450) NULL,
	[IsPromoted] [bit] NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceReservations]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceReservations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RequestDate] [datetime2](7) NOT NULL,
	[DateService] [datetime2](7) NOT NULL,
	[IsAccepted] [bit] NOT NULL,
	[IsCompleted] [bit] NOT NULL,
	[ApplicationUserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_ServiceReservations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Price] [int] NOT NULL,
	[LocationArea] [nvarchar](max) NOT NULL,
	[LocationAddress] [nvarchar](max) NOT NULL,
	[isActive] [bit] NOT NULL,
	[isApproved] [bit] NOT NULL,
	[ServiceTypeId] [int] NOT NULL,
	[ProviderId] [int] NOT NULL,
	[IsPromoted] [bit] NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceServiceReservation]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceServiceReservation](
	[Id] [int] NOT NULL,
	[ServicesId] [int] NOT NULL,
	[ServiceReservationsId] [int] NOT NULL,
 CONSTRAINT [PK_ServiceServiceReservation] PRIMARY KEY CLUSTERED 
(
	[ServicesId] ASC,
	[ServiceReservationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceTypes]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Label] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ServiceTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketReservations]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketReservations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TotalNbTickets] [int] NOT NULL,
	[ApplicationUserId] [nvarchar](450) NOT NULL,
	[EventId] [int] NOT NULL,
 CONSTRAINT [PK_TicketReservations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 03-05-23 12:56:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketNumber] [int] NOT NULL,
	[EventId] [int] NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230401124308_FirstMigration', N'6.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230410170755_UpdateSSR', N'6.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230411171335_EventApproval', N'6.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230416182440_AddImageToEvent', N'6.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230428132942_AddISPromotedToEvent', N'6.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230429110432_IsPromotedForProviderAndService', N'6.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230429121116_AddImageToProvider', N'6.0.13')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8d012e04-e5c3-4ee0-baed-53d4778470a6', N'Provider', N'PROVIDER', N'45428461-7b8f-4d5c-90ad-89fda122e77a')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'cac43a6e-f7bb-4448-baaf-1add431ccbbf', N'Employee', N'EMPLOYEE', N'b2bbcefd-b3dd-42be-b9cf-df75c74bfeb2')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'cbc43a8e-f7bb-4445-baaf-1add431ffbbf', N'Administrator', N'ADMINISTRATOR', N'c5d3e11f-88c4-472d-a5d3-8ea4da6ec751')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'cbc43a9e-f7bb-4445-baaf-1add431ffbbf', N'Client', N'CLIENT', N'7a752714-499a-4b47-a1a0-c22cb9fb7927')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5b7617ff-7ae1-4850-a96a-8764c1ffa186', N'8d012e04-e5c3-4ee0-baed-53d4778470a6')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7a43a28a-12ba-4e66-932c-971af572513d', N'8d012e04-e5c3-4ee0-baed-53d4778470a6')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd473a682-4a6a-4157-bd54-bb291140aac0', N'8d012e04-e5c3-4ee0-baed-53d4778470a6')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'047a1feb-b527-43af-8194-f1e3c92b7607', N'cac43a6e-f7bb-4448-baaf-1add431ccbbf')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'279fc88b-0a5e-4bec-b074-eee865a0c9ae', N'cbc43a8e-f7bb-4445-baaf-1add431ffbbf')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5b7617ff-7ae1-4850-a96a-8764c1ffa186', N'cbc43a9e-f7bb-4445-baaf-1add431ffbbf')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6fda28e1-0e46-4eaa-8f68-2789d956a6a5', N'cbc43a9e-f7bb-4445-baaf-1add431ffbbf')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7a43a28a-12ba-4e66-932c-971af572513d', N'cbc43a9e-f7bb-4445-baaf-1add431ffbbf')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd473a682-4a6a-4157-bd54-bb291140aac0', N'cbc43a9e-f7bb-4445-baaf-1add431ffbbf')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ed742fb6-87ff-40a9-a30b-717211f5d456', N'cbc43a9e-f7bb-4445-baaf-1add431ffbbf')
GO
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Address], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'047a1feb-b527-43af-8194-f1e3c92b7607', N'System', N'Employee', N'rue de la paix 25', N'employee@localhost.com', N'EMPLOYEE@LOCALHOST.COM', N'employee@localhost.com', N'EMPLOYEE@LOCALHOST.COM', 1, N'AQAAAAEAACcQAAAAEMhxesB6ILM3PMO1VomNbHZcrIallUjj2MTP7LfoiYMThgl7UnTIfe3qSupcPdD3fQ==', N'2af37b5a-a607-4101-a06f-eda48c67ef71', N'97087462-484b-4af6-8b28-70d471f97803', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Address], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'279fc88b-0a5e-4bec-b074-eee865a0c9ae', N'System', N'Admin', N'rue de la paix 25', N'admin@localhost.com', N'ADMIN@LOCALHOST.COM', N'admin@localhost.com', N'ADMIN@LOCALHOST.COM', 1, N'AQAAAAEAACcQAAAAEAuN+YRWj2zA7Xa/Z5OunVbSpangk0+vw/dHZZAu8TyN6kyjq6Li6CPESDidKT8WKA==', N'8db21426-850e-449e-8863-c3a86432fe09', N'f7128203-7805-44a9-8506-efc5eb68d352', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Address], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5b7617ff-7ae1-4850-a96a-8764c1ffa186', N'Tsuki', N'Moon', N'Rue Coenraets, 72', N'tsukigrrrl', N'TSUKIGRRRL', N'tsukimoonmusic@gmail.com', N'TSUKIMOONMUSIC@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEBcvc45HYxg4lckzPDUvC90yhLV/Pt40Y3mchXWZGPJMz84ggJOxTY5QeQiCzLILDA==', N'OKGVNMSNCY3S6GM7SG6ZDIVT7HD4WJXT', N'a6199aac-38ce-40c7-a057-08face76a051', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Address], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'6fda28e1-0e46-4eaa-8f68-2789d956a6a5', N'Sandrine', N'Vanderveken', N'Rue Coenraets, 72 1060 Bruxelles', N'sandrinev', N'SANDRINEV', N'sandrinev@gmail.com', N'SANDRINEV@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEM2LvrHJoujqh/c+FsYtnc2sog/0WjprsGfwijZ6l6MN0W9LCS0lrgtEmQxkRJuAcw==', N'7LOCFQ4HLEBIV4Z4CXVW6QXVX7JVF3UZ', N'a6505ec5-c6d2-4a03-bfbb-1312d753b36a', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Address], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'7a43a28a-12ba-4e66-932c-971af572513d', N'Géraldine', N'Buxant', N'Rue Laverland, 13', N'geraldine', N'GERALDINE', N'myfavouritedentistisdead@hotmail.com', N'MYFAVOURITEDENTISTISDEAD@HOTMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDxds2erErrC6oerq4/4OYJT5rpwpphiTGhX9Ua0FLMMxuVqPKOrXx5TGM8pQrFKew==', N'PP3BZ26Z2H3IY7BGAVVX6LHRHZ5MDXNI', N'db23ab52-ba46-4225-85ac-edb9e5bb17de', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Address], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'd473a682-4a6a-4157-bd54-bb291140aac0', N'Stéphanie', N'Dubois', N'Rue du bois, 1 1480 Tubize', N'stephdubois', N'STEPHDUBOIS', N'stephdubois@gmail.com', N'STEPHDUBOIS@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAECyJrxkKCvGlLEssNVnMTULX6cniQr0FEfdW66jd6jH+VG/Y0knUCV7YRlycgKHLDw==', N'YABQN5KS3TRMQ5P2VDKVQSTTN5KTODRJ', N'e33db632-0ea4-42f3-817e-238b323dd4ce', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Address], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'ed742fb6-87ff-40a9-a30b-717211f5d456', N'System', N'Client', N'rue de la paix 25', N'client@localhost.com', N'CLIENT@LOCALHOST.COM', N'clien@localhost.com', N'CLIENT@LOCALHOST.COM', 1, N'AQAAAAEAACcQAAAAEGgiDBrNVKgK4IGRAq+qfOkPCZkCw/7C0vF08Evr0vJ+qufzrWGCI1yu/68nCqKDoQ==', N'91178d50-47ff-487d-8f7b-6491d3e9cbbc', N'22fff8e6-337a-4d3f-b594-a56986e967dc', NULL, 0, 0, NULL, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[Events] ON 

INSERT [dbo].[Events] ([Id], [Title], [Description], [EventDate], [VenueName], [VenueAddress], [TicketsAmount], [NbSoldTickets], [TicketPrice], [ApplicationUserId], [IsActive], [IsApproved], [Image], [IsPromoted]) VALUES (1, N'Dj Set', N'Soirée dj', CAST(N'2023-05-27T00:00:00.0000000' AS DateTime2), N'Le Fuse', N'Rue Haute, 50 1000 Bruxelles', 50, 0, 17, N'd473a682-4a6a-4157-bd54-bb291140aac0', 1, 1, N'concert-3.jpg', 0)
INSERT [dbo].[Events] ([Id], [Title], [Description], [EventDate], [VenueName], [VenueAddress], [TicketsAmount], [NbSoldTickets], [TicketPrice], [ApplicationUserId], [IsActive], [IsApproved], [Image], [IsPromoted]) VALUES (17, N'Trium Viral', N'Concert Acoustique', CAST(N'2023-11-10T00:00:00.0000000' AS DateTime2), N'Botanique', N'Rue Royale, 123 1030 Bruxelles', 150, 0, 18, N'7a43a28a-12ba-4e66-932c-971af572513d', 1, 1, N'event-1.jpg', 1)
INSERT [dbo].[Events] ([Id], [Title], [Description], [EventDate], [VenueName], [VenueAddress], [TicketsAmount], [NbSoldTickets], [TicketPrice], [ApplicationUserId], [IsActive], [IsApproved], [Image], [IsPromoted]) VALUES (18, N'Back to the 80''s', N'Blind Test', CAST(N'2023-11-10T00:00:00.0000000' AS DateTime2), N'Le Garage', N'Rue Marengo 27, 4000 Liège', 100, 0, 15, N'7a43a28a-12ba-4e66-932c-971af572513d', 1, 1, N'event-1.jpg', 1)
INSERT [dbo].[Events] ([Id], [Title], [Description], [EventDate], [VenueName], [VenueAddress], [TicketsAmount], [NbSoldTickets], [TicketPrice], [ApplicationUserId], [IsActive], [IsApproved], [Image], [IsPromoted]) VALUES (19, N'Electer', N'Dj Set', CAST(N'2023-12-22T00:00:00.0000000' AS DateTime2), N'Le Salon', N'Rue Ville Basse 19, 7830 Silly', 200, 0, 19, N'7a43a28a-12ba-4e66-932c-971af572513d', 1, 1, N'event-1.jpg', 1)
INSERT [dbo].[Events] ([Id], [Title], [Description], [EventDate], [VenueName], [VenueAddress], [TicketsAmount], [NbSoldTickets], [TicketPrice], [ApplicationUserId], [IsActive], [IsApproved], [Image], [IsPromoted]) VALUES (20, N'The world will be around', N'Electro Set', CAST(N'2023-11-15T00:00:00.0000000' AS DateTime2), N'Le Fuse', N'Rue Haute, 50 1000 Bruxelles', 1500, 0, 22, N'7a43a28a-12ba-4e66-932c-971af572513d', 1, 0, N'event-1.jpg', 0)
SET IDENTITY_INSERT [dbo].[Events] OFF
GO
SET IDENTITY_INSERT [dbo].[Providers] ON 

INSERT [dbo].[Providers] ([Id], [Name], [Bio], [Link], [IsActive], [IsApproved], [ApplicationUserId], [IsPromoted], [Image]) VALUES (1, N'Stephanie Dubois', N'Ils s''appellent Amadou Bagayoko et Mariam Doumbia. Ce sont deux artistes maliens aveugles qui chantent la joie de vivre, l''amour, et l''espoir d''un monde ...', N'http://www.music.com', 1, 1, N'd473a682-4a6a-4157-bd54-bb291140aac0', 1, N'concert-3.jpg')
INSERT [dbo].[Providers] ([Id], [Name], [Bio], [Link], [IsActive], [IsApproved], [ApplicationUserId], [IsPromoted], [Image]) VALUES (2, N'The Avengers', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.', N'http://www.music.com', 1, 1, N'd473a682-4a6a-4157-bd54-bb291140aac0', 0, N'https://www.mixcloud.com/geraldinebuxant/')
INSERT [dbo].[Providers] ([Id], [Name], [Bio], [Link], [IsActive], [IsApproved], [ApplicationUserId], [IsPromoted], [Image]) VALUES (3, N'Tsuki Moon', N'Tsuki Moon est un duo indie/folk/alternatif qui livre des chansons énergiques.', N'https://soundcloud.com/tsuki-moon', 1, 1, N'7a43a28a-12ba-4e66-932c-971af572513d', 1, N'concert-2.jpg')
INSERT [dbo].[Providers] ([Id], [Name], [Bio], [Link], [IsActive], [IsApproved], [ApplicationUserId], [IsPromoted], [Image]) VALUES (4, N'Tsuki Solo', N'Tsuki Moon is an indie/folk/alernative duo that delivers energic songs. ', N'https://soundcloud.com/tsuki-moon', 1, 1, N'5b7617ff-7ae1-4850-a96a-8764c1ffa186', 0, N'')
INSERT [dbo].[Providers] ([Id], [Name], [Bio], [Link], [IsActive], [IsApproved], [ApplicationUserId], [IsPromoted], [Image]) VALUES (5, N'Joseph Arthur', N'Joseph Arthur is an American singer-songwriter and artist from Akron, Ohio. He is best known for his solo material, and as a member of Fistful of Mercy and RNDM.', N'http://josepharthur.com/', 1, 1, N'7a43a28a-12ba-4e66-932c-971af572513d', 0, N'')
INSERT [dbo].[Providers] ([Id], [Name], [Bio], [Link], [IsActive], [IsApproved], [ApplicationUserId], [IsPromoted], [Image]) VALUES (6, N'Joseph Arthur', N'Joseph Arthur is an American singer-songwriter and artist from Akron, Ohio. He is best known for his solo material, and as a member of Fistful of Mercy and RNDM.', N'http://josepharthur.com/', 0, 1, N'7a43a28a-12ba-4e66-932c-971af572513d', 0, N'')
INSERT [dbo].[Providers] ([Id], [Name], [Bio], [Link], [IsActive], [IsApproved], [ApplicationUserId], [IsPromoted], [Image]) VALUES (7, N'Abdelkader Benali', N'Abdelkader Benali is an American singer-songwriter and artist from Akron, Ohio. He is best known for his solo material, and as a member of Fistful of Mercy and RNDM.', N'http://josepharthur.com/', 1, 1, N'7a43a28a-12ba-4e66-932c-971af572513d', 0, N'')
INSERT [dbo].[Providers] ([Id], [Name], [Bio], [Link], [IsActive], [IsApproved], [ApplicationUserId], [IsPromoted], [Image]) VALUES (8, N'Animal Lecteur', N'Slammeuse avide de lecture', N'https://soundcloud.com/tsuki-moon', 1, 1, N'7a43a28a-12ba-4e66-932c-971af572513d', 0, N'concert-3.jpg')
SET IDENTITY_INSERT [dbo].[Providers] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceReservations] ON 

INSERT [dbo].[ServiceReservations] ([Id], [RequestDate], [DateService], [IsAccepted], [IsCompleted], [ApplicationUserId]) VALUES (1, CAST(N'2023-04-18T15:59:16.0331456' AS DateTime2), CAST(N'2023-04-18T00:00:00.0000000' AS DateTime2), 0, 0, N'279fc88b-0a5e-4bec-b074-eee865a0c9ae')
INSERT [dbo].[ServiceReservations] ([Id], [RequestDate], [DateService], [IsAccepted], [IsCompleted], [ApplicationUserId]) VALUES (2, CAST(N'2023-04-18T16:22:43.3175184' AS DateTime2), CAST(N'2023-04-18T00:00:00.0000000' AS DateTime2), 0, 0, N'5b7617ff-7ae1-4850-a96a-8764c1ffa186')
SET IDENTITY_INSERT [dbo].[ServiceReservations] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([Id], [Title], [Description], [Image], [Price], [LocationArea], [LocationAddress], [isActive], [isApproved], [ServiceTypeId], [ProviderId], [IsPromoted]) VALUES (1, N'DJ Set ', N'DJ Set de fou', N'service.jpg', 18, N'Brussels', N'Rue de la poste, 1', 1, 1, 1, 1, 1)
INSERT [dbo].[Services] ([Id], [Title], [Description], [Image], [Price], [LocationArea], [LocationAddress], [isActive], [isApproved], [ServiceTypeId], [ProviderId], [IsPromoted]) VALUES (8, N'Guidelines EP Release', N'Concert Electro Hip Hop', N'https://www.mixcloud.com/geraldinebuxant/', 22, N'Brussels', N'Botanique Rue Royale, 123 1030 Bruxelles', 0, 1, 1, 3, 0)
INSERT [dbo].[Services] ([Id], [Title], [Description], [Image], [Price], [LocationArea], [LocationAddress], [isActive], [isApproved], [ServiceTypeId], [ProviderId], [IsPromoted]) VALUES (9, N'Guidelines EP Release', N'Concert Electro Hip Hop', N'https://www.mixcloud.com/geraldinebuxant/', 23, N'Brussels', N'Botanique Rue Royale, 123 1030 Bruxelles', 0, 1, 1, 3, 0)
INSERT [dbo].[Services] ([Id], [Title], [Description], [Image], [Price], [LocationArea], [LocationAddress], [isActive], [isApproved], [ServiceTypeId], [ProviderId], [IsPromoted]) VALUES (10, N'The world will be around', N'Electro Hip-Hop Set', N'service.jpg', 18, N'Brussels', N'Botanique Rue Royale, 123 1030 Bruxelles', 1, 1, 1, 3, 1)
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceTypes] ON 

INSERT [dbo].[ServiceTypes] ([Id], [Label], [Image]) VALUES (1, N'Concert', N'https://www.mixcloud.com/geraldinebuxant/')
INSERT [dbo].[ServiceTypes] ([Id], [Label], [Image]) VALUES (2, N'Securité', N'https://www.entoutesecurite.fr/ref/agent-de-securite-concert.html')
INSERT [dbo].[ServiceTypes] ([Id], [Label], [Image]) VALUES (3, N'Technique', N'urlpardefaut')
SET IDENTITY_INSERT [dbo].[ServiceTypes] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 03-05-23 12:56:01 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 03-05-23 12:56:01 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Events_ApplicationUserId]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [IX_Events_ApplicationUserId] ON [dbo].[Events]
(
	[ApplicationUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Providers_ApplicationUserId]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [IX_Providers_ApplicationUserId] ON [dbo].[Providers]
(
	[ApplicationUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ServiceReservations_ApplicationUserId]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [IX_ServiceReservations_ApplicationUserId] ON [dbo].[ServiceReservations]
(
	[ApplicationUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Services_ProviderId]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [IX_Services_ProviderId] ON [dbo].[Services]
(
	[ProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Services_ServiceTypeId]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [IX_Services_ServiceTypeId] ON [dbo].[Services]
(
	[ServiceTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ServiceServiceReservation_ServiceReservationsId]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [IX_ServiceServiceReservation_ServiceReservationsId] ON [dbo].[ServiceServiceReservation]
(
	[ServiceReservationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_TicketReservations_ApplicationUserId]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [IX_TicketReservations_ApplicationUserId] ON [dbo].[TicketReservations]
(
	[ApplicationUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TicketReservations_EventId]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [IX_TicketReservations_EventId] ON [dbo].[TicketReservations]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Tickets_EventId]    Script Date: 03-05-23 12:56:01 ******/
CREATE NONCLUSTERED INDEX [IX_Tickets_EventId] ON [dbo].[Tickets]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Events] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Events] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsApproved]
GO
ALTER TABLE [dbo].[Events] ADD  DEFAULT (N'') FOR [Image]
GO
ALTER TABLE [dbo].[Events] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsPromoted]
GO
ALTER TABLE [dbo].[Providers] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsPromoted]
GO
ALTER TABLE [dbo].[Providers] ADD  DEFAULT (N'') FOR [Image]
GO
ALTER TABLE [dbo].[Services] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsPromoted]
GO
ALTER TABLE [dbo].[ServiceServiceReservation] ADD  DEFAULT ((0)) FOR [ServiceReservationsId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_AspNetUsers_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_AspNetUsers_ApplicationUserId]
GO
ALTER TABLE [dbo].[Providers]  WITH CHECK ADD  CONSTRAINT [FK_Providers_AspNetUsers_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Providers] CHECK CONSTRAINT [FK_Providers_AspNetUsers_ApplicationUserId]
GO
ALTER TABLE [dbo].[ServiceReservations]  WITH CHECK ADD  CONSTRAINT [FK_ServiceReservations_AspNetUsers_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ServiceReservations] CHECK CONSTRAINT [FK_ServiceReservations_AspNetUsers_ApplicationUserId]
GO
ALTER TABLE [dbo].[Services]  WITH CHECK ADD  CONSTRAINT [FK_Services_Providers_ProviderId] FOREIGN KEY([ProviderId])
REFERENCES [dbo].[Providers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Services] CHECK CONSTRAINT [FK_Services_Providers_ProviderId]
GO
ALTER TABLE [dbo].[Services]  WITH CHECK ADD  CONSTRAINT [FK_Services_ServiceTypes_ServiceTypeId] FOREIGN KEY([ServiceTypeId])
REFERENCES [dbo].[ServiceTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Services] CHECK CONSTRAINT [FK_Services_ServiceTypes_ServiceTypeId]
GO
ALTER TABLE [dbo].[ServiceServiceReservation]  WITH CHECK ADD  CONSTRAINT [FK_ServiceServiceReservation_ServiceReservations_ServiceReservationsId] FOREIGN KEY([ServiceReservationsId])
REFERENCES [dbo].[ServiceReservations] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ServiceServiceReservation] CHECK CONSTRAINT [FK_ServiceServiceReservation_ServiceReservations_ServiceReservationsId]
GO
ALTER TABLE [dbo].[ServiceServiceReservation]  WITH CHECK ADD  CONSTRAINT [FK_ServiceServiceReservation_Services_ServicesId] FOREIGN KEY([ServicesId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ServiceServiceReservation] CHECK CONSTRAINT [FK_ServiceServiceReservation_Services_ServicesId]
GO
ALTER TABLE [dbo].[TicketReservations]  WITH CHECK ADD  CONSTRAINT [FK_TicketReservations_AspNetUsers_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TicketReservations] CHECK CONSTRAINT [FK_TicketReservations_AspNetUsers_ApplicationUserId]
GO
ALTER TABLE [dbo].[TicketReservations]  WITH CHECK ADD  CONSTRAINT [FK_TicketReservations_Events_EventId] FOREIGN KEY([EventId])
REFERENCES [dbo].[Events] ([Id])
GO
ALTER TABLE [dbo].[TicketReservations] CHECK CONSTRAINT [FK_TicketReservations_Events_EventId]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Events_EventId] FOREIGN KEY([EventId])
REFERENCES [dbo].[Events] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Events_EventId]
GO
USE [master]
GO
ALTER DATABASE [PropagendaTFE2023] SET  READ_WRITE 
GO
