USE [master]
GO

/****** Object:  Database [challenge1]    Script Date: 2/28/2016 10:21:46 PM ******/
CREATE DATABASE [challenge1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'challenge1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQL\DATA\challenge1.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'challenge1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQL\DATA\challenge1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [challenge1] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [challenge1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [challenge1] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [challenge1] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [challenge1] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [challenge1] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [challenge1] SET ARITHABORT OFF 
GO

ALTER DATABASE [challenge1] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [challenge1] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [challenge1] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [challenge1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [challenge1] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [challenge1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [challenge1] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [challenge1] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [challenge1] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [challenge1] SET  DISABLE_BROKER 
GO

ALTER DATABASE [challenge1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [challenge1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [challenge1] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [challenge1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [challenge1] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [challenge1] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [challenge1] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [challenge1] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [challenge1] SET  MULTI_USER 
GO

ALTER DATABASE [challenge1] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [challenge1] SET DB_CHAINING OFF 
GO

ALTER DATABASE [challenge1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [challenge1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [challenge1] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [challenge1] SET  READ_WRITE 
GO

