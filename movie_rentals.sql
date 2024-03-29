USE [master]
GO
/****** Object:  Database [movie_rentals]    Script Date: 7/10/2019 2:38:33 PM ******/
CREATE DATABASE [movie_rentals]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'movie_rentals', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\movie_rentals.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'movie_rentals_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\movie_rentals_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [movie_rentals] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [movie_rentals].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [movie_rentals] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [movie_rentals] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [movie_rentals] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [movie_rentals] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [movie_rentals] SET ARITHABORT OFF 
GO
ALTER DATABASE [movie_rentals] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [movie_rentals] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [movie_rentals] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [movie_rentals] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [movie_rentals] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [movie_rentals] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [movie_rentals] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [movie_rentals] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [movie_rentals] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [movie_rentals] SET  DISABLE_BROKER 
GO
ALTER DATABASE [movie_rentals] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [movie_rentals] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [movie_rentals] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [movie_rentals] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [movie_rentals] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [movie_rentals] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [movie_rentals] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [movie_rentals] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [movie_rentals] SET  MULTI_USER 
GO
ALTER DATABASE [movie_rentals] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [movie_rentals] SET DB_CHAINING OFF 
GO
ALTER DATABASE [movie_rentals] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [movie_rentals] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [movie_rentals] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [movie_rentals] SET QUERY_STORE = OFF
GO
USE [movie_rentals]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 7/10/2019 2:38:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[customerID] [int] IDENTITY(1,1) NOT NULL,
	[customerName] [nvarchar](50) NULL,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[Address] [ntext] NOT NULL,
	[phone] [int] NOT NULL,
 CONSTRAINT [PK_Customrs] PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 7/10/2019 2:38:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[movieID] [int] IDENTITY(1,1) NOT NULL,
	[ratings] [int] NOT NULL,
	[title] [nvarchar](50) NULL,
	[year] [nvarchar](4) NULL,
	[rentalCost] [nvarchar](15) NULL,
	[copies] [int] NOT NULL,
	[genre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_movie] PRIMARY KEY CLUSTERED 
(
	[movieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rentedmovies]    Script Date: 7/10/2019 2:38:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rentedmovies](
	[rentalID] [int] IDENTITY(1,1) NOT NULL,
	[movieID] [int] NOT NULL,
	[customerID] [int] NULL,
	[dateRented] [datetime] NULL,
	[dateReturned] [datetime] NULL,
 CONSTRAINT [PK_rented] PRIMARY KEY CLUSTERED 
(
	[rentalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [movie_rentals] SET  READ_WRITE 
GO
