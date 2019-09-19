use master
go

CREATE DATABASE QLBH_T
GO

USE [QLBH_T]
GO

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[ProductId] [int] NOT NULL,
	[ProductName] [nvarchar](255) NOT NULL,
	[ProductPrice] [decimal](18,2) NOT NULL,
	[ProductQty] [float] NULL,
	CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED([ProductId] ASC)
)
GO

INSERT INTO [dbo].[Product] VALUES
(1,N'Nước suối',5.00,100.0),
(2,N'Coca Cola',8.00,100.0),
(3,N'Pepsi',8.00,100.0),
(4,N'7 Up',8.00,100.0)
GO