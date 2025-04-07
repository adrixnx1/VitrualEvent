/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
USE [master]
GO

/****** Object:  Database [VirtualEvent]    Script Date: 4/7/2025 6:01:43 PM ******/
CREATE DATABASE [VirtualEvent]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VirtualEvent', FILENAME = N'C:\Users\alant\VirtualEvent.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VirtualEvent_log', FILENAME = N'C:\Users\alant\VirtualEvent_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VirtualEvent].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [VirtualEvent] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [VirtualEvent] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [VirtualEvent] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [VirtualEvent] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [VirtualEvent] SET ARITHABORT OFF 
GO

ALTER DATABASE [VirtualEvent] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [VirtualEvent] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [VirtualEvent] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [VirtualEvent] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [VirtualEvent] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [VirtualEvent] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [VirtualEvent] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [VirtualEvent] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [VirtualEvent] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [VirtualEvent] SET  DISABLE_BROKER 
GO

ALTER DATABASE [VirtualEvent] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [VirtualEvent] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [VirtualEvent] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [VirtualEvent] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [VirtualEvent] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [VirtualEvent] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [VirtualEvent] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [VirtualEvent] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [VirtualEvent] SET  MULTI_USER 
GO

ALTER DATABASE [VirtualEvent] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [VirtualEvent] SET DB_CHAINING OFF 
GO

ALTER DATABASE [VirtualEvent] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [VirtualEvent] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [VirtualEvent] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [VirtualEvent] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [VirtualEvent] SET QUERY_STORE = OFF
GO

ALTER DATABASE [VirtualEvent] SET  READ_WRITE 
GO

