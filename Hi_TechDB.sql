USE [master]
GO
/****** Object:  Database [Hi_TechDB]    Script Date: 2020-12-17 9:27:34 AM ******/
CREATE DATABASE [Hi_TechDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hi_TechDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hi_TechDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hi_TechDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hi_TechDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hi_TechDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hi_TechDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hi_TechDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hi_TechDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hi_TechDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hi_TechDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hi_TechDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hi_TechDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hi_TechDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hi_TechDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hi_TechDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hi_TechDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hi_TechDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hi_TechDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hi_TechDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hi_TechDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hi_TechDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hi_TechDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hi_TechDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hi_TechDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hi_TechDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hi_TechDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hi_TechDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hi_TechDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hi_TechDB] SET RECOVERY FULL 
GO
ALTER DATABASE [Hi_TechDB] SET  MULTI_USER 
GO
ALTER DATABASE [Hi_TechDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hi_TechDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hi_TechDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hi_TechDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hi_TechDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hi_TechDB', N'ON'
GO
ALTER DATABASE [Hi_TechDB] SET QUERY_STORE = OFF
GO
USE [Hi_TechDB]
GO
/****** Object:  Table [dbo].[Author_Book]    Script Date: 2020-12-17 9:27:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author_Book](
	[AuthorID] [int] NOT NULL,
	[ISBN] [nvarchar](13) NOT NULL,
 CONSTRAINT [PK_Auther_Book] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 2020-12-17 9:27:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorID] [int] NOT NULL,
	[First_Name] [nvarchar](50) NULL,
	[Last_Name] [nvarchar](50) NULL,
	[Email] [nvarchar](150) NULL,
 CONSTRAINT [PK_Authers] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2020-12-17 9:27:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN] [nvarchar](13) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[UnitPrice] [int] NOT NULL,
	[YearPublished] [date] NULL,
	[CategoryID] [int] NULL,
	[PublisherID] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2020-12-17 9:27:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] NOT NULL,
	[Title] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2020-12-17 9:27:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Postal_Code] [nvarchar](10) NULL,
	[Phone_Number] [nvarchar](50) NOT NULL,
	[Fax_Number] [nvarchar](50) NOT NULL,
	[Credit_limit] [int] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2020-12-17 9:27:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL,
	[First_Name] [nvarchar](20) NOT NULL,
	[Last_Name] [nvarchar](20) NOT NULL,
	[Phone_Number] [nvarchar](50) NULL,
	[Email] [nvarchar](150) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 2020-12-17 9:27:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jobs](
	[JobID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
 CONSTRAINT [PK_Jobs] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2020-12-17 9:27:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[ISBN] [nvarchar](13) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[Order_Date] [date] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 2020-12-17 9:27:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PublisherID] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone_Number] [nvarchar](50) NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2020-12-17 9:27:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[First_Name] [nvarchar](20) NOT NULL,
	[Last_Name] [nvarchar](20) NOT NULL,
	[Phone_Number] [nvarchar](20) NULL,
	[Email] [nvarchar](150) NULL,
	[JobID] [int] NOT NULL,
	[EmployeeID] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Authors] ([AuthorID], [First_Name], [Last_Name], [Email]) VALUES (1, N'rea', N'wewq', N'qweq@')
INSERT [dbo].[Authors] ([AuthorID], [First_Name], [Last_Name], [Email]) VALUES (2, N'dds', N'sdsd', N'sdfsdfe')
INSERT [dbo].[Authors] ([AuthorID], [First_Name], [Last_Name], [Email]) VALUES (3, N'dsfee', N'eee', N'sdfsdfe@')
GO
INSERT [dbo].[Books] ([ISBN], [Title], [UnitPrice], [YearPublished], [CategoryID], [PublisherID]) VALUES (N'23414', N'trees', 100, CAST(N'2000-02-25' AS Date), 2, 1)
INSERT [dbo].[Books] ([ISBN], [Title], [UnitPrice], [YearPublished], [CategoryID], [PublisherID]) VALUES (N'3214324', N'python', 40, CAST(N'2020-11-24' AS Date), 1, 1)
INSERT [dbo].[Books] ([ISBN], [Title], [UnitPrice], [YearPublished], [CategoryID], [PublisherID]) VALUES (N'32423', N'res', 34, CAST(N'2020-08-11' AS Date), 2, 1)
GO
INSERT [dbo].[Categories] ([CategoryID], [Title]) VALUES (1, N'programing')
INSERT [dbo].[Categories] ([CategoryID], [Title]) VALUES (2, N'science')
INSERT [dbo].[Categories] ([CategoryID], [Title]) VALUES (3, N'geography')
INSERT [dbo].[Categories] ([CategoryID], [Title]) VALUES (4, N'languages')
INSERT [dbo].[Categories] ([CategoryID], [Title]) VALUES (6, N'jazz')
GO
INSERT [dbo].[Customers] ([CustomerID], [Name], [Street], [City], [Postal_Code], [Phone_Number], [Fax_Number], [Credit_limit]) VALUES (2, N'ghaz', N'aaa', N'sss', N'dass', N'2313', N'1231', 11)
INSERT [dbo].[Customers] ([CustomerID], [Name], [Street], [City], [Postal_Code], [Phone_Number], [Fax_Number], [Credit_limit]) VALUES (4, N'sda', N'asdw', N'weq', N'qwe', N'weq', N'weq', 231)
INSERT [dbo].[Customers] ([CustomerID], [Name], [Street], [City], [Postal_Code], [Phone_Number], [Fax_Number], [Credit_limit]) VALUES (5, N'sda', N'asdw', N'weq', N'qwe', N'weq', N'weq', 231)
INSERT [dbo].[Customers] ([CustomerID], [Name], [Street], [City], [Postal_Code], [Phone_Number], [Fax_Number], [Credit_limit]) VALUES (6, N'we', N'qwe', N'qwee', N'221e', N'e2e22', N'222', 1)
INSERT [dbo].[Customers] ([CustomerID], [Name], [Street], [City], [Postal_Code], [Phone_Number], [Fax_Number], [Credit_limit]) VALUES (7, N'ritta', N'aaa', N'sss', N'dass', N'2313', N'1231', 11)
GO
INSERT [dbo].[Employees] ([EmployeeID], [First_Name], [Last_Name], [Phone_Number], [Email]) VALUES (1, N'ghazar', N'ghazarian', N'4388869755', N'ghazar55@gmail.com')
INSERT [dbo].[Employees] ([EmployeeID], [First_Name], [Last_Name], [Phone_Number], [Email]) VALUES (3, N'fgf', N'', N'', N'')
INSERT [dbo].[Employees] ([EmployeeID], [First_Name], [Last_Name], [Phone_Number], [Email]) VALUES (6, N'mirna', N'dsfdsf', N'3435tt', N'dfsfsdf')
INSERT [dbo].[Employees] ([EmployeeID], [First_Name], [Last_Name], [Phone_Number], [Email]) VALUES (7, N'omar', N'sdfsdff', N'34234324', N'dfgfdg')
INSERT [dbo].[Employees] ([EmployeeID], [First_Name], [Last_Name], [Phone_Number], [Email]) VALUES (23, N'gru', N'dsfef', N'324324', N'dsfer@ghgf')
GO
SET IDENTITY_INSERT [dbo].[Jobs] ON 

INSERT [dbo].[Jobs] ([JobID], [Title]) VALUES (1, N'MIS Manager')
INSERT [dbo].[Jobs] ([JobID], [Title]) VALUES (2, N'Sales Manager')
INSERT [dbo].[Jobs] ([JobID], [Title]) VALUES (3, N'Inventory Manager')
INSERT [dbo].[Jobs] ([JobID], [Title]) VALUES (4, N'Order Clerk')
SET IDENTITY_INSERT [dbo].[Jobs] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [ISBN], [CustomerID], [UserID], [Order_Date], [Quantity]) VALUES (8, N'3214324', 6, 1, CAST(N'2021-08-18' AS Date), 80)
INSERT [dbo].[Orders] ([OrderID], [ISBN], [CustomerID], [UserID], [Order_Date], [Quantity]) VALUES (9, N'3214324', 5, 2, CAST(N'1994-12-30' AS Date), 58)
INSERT [dbo].[Orders] ([OrderID], [ISBN], [CustomerID], [UserID], [Order_Date], [Quantity]) VALUES (10, N'23414', 5, 2, CAST(N'1994-12-30' AS Date), 58)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
INSERT [dbo].[Publishers] ([PublisherID], [Name], [Phone_Number]) VALUES (1, N'ghaz', N'444444')
INSERT [dbo].[Publishers] ([PublisherID], [Name], [Phone_Number]) VALUES (3, N'rafi', N'34231232')
INSERT [dbo].[Publishers] ([PublisherID], [Name], [Phone_Number]) VALUES (5, N'ffff', N'333333')
GO
INSERT [dbo].[Users] ([UserID], [Password], [First_Name], [Last_Name], [Phone_Number], [Email], [JobID], [EmployeeID]) VALUES (1, N'ghazar', N'ghazar', N'ghazarian', N'4388869755', N'ghazar55@gmail.com', 1, 1)
INSERT [dbo].[Users] ([UserID], [Password], [First_Name], [Last_Name], [Phone_Number], [Email], [JobID], [EmployeeID]) VALUES (2, N'mirna', N'mirna', N'ghazarian', N'324234', N'mirna@gmail.com', 1, 6)
INSERT [dbo].[Users] ([UserID], [Password], [First_Name], [Last_Name], [Phone_Number], [Email], [JobID], [EmployeeID]) VALUES (3, N'jean', N'jean', N'gh', N'324234', N'jean@sdfdsf', 3, 23)
INSERT [dbo].[Users] ([UserID], [Password], [First_Name], [Last_Name], [Phone_Number], [Email], [JobID], [EmployeeID]) VALUES (4, N'mark', N'mark', N'ser', N'23213213123', N'mark@gmail.com', 4, 3)
INSERT [dbo].[Users] ([UserID], [Password], [First_Name], [Last_Name], [Phone_Number], [Email], [JobID], [EmployeeID]) VALUES (5, N'fff', N'ffrf', N'sefw', N'1234567891', N'ffff@gmail.com', 4, 7)
GO
/****** Object:  Index [IX_Users]    Script Date: 2020-12-17 9:27:34 AM ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [IX_Users] UNIQUE NONCLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Author_Book]  WITH CHECK ADD  CONSTRAINT [FK_Author_Book_Authors] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Authors] ([AuthorID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Author_Book] CHECK CONSTRAINT [FK_Author_Book_Authors]
GO
ALTER TABLE [dbo].[Author_Book]  WITH CHECK ADD  CONSTRAINT [FK_Author_Book_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Author_Book] CHECK CONSTRAINT [FK_Author_Book_Books]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Categories]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Publishers] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publishers] ([PublisherID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publishers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Books]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Employees]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Jobs] FOREIGN KEY([JobID])
REFERENCES [dbo].[Jobs] ([JobID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Jobs]
GO
USE [master]
GO
ALTER DATABASE [Hi_TechDB] SET  READ_WRITE 
GO
