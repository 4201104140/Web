
USE [QLBH]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 26/05/2018 3:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] NULL,
	[Phone] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[CustomerName] [nvarchar](255) NULL,
	[isVender] [bit] NULL,
	[isCustomer] [bit] NULL,
	[WriteDate] [nvarchar](255) NULL,
	[EditDate] [nvarchar](255) NULL,
	[WriterId] [int] NULL,
	[EditorId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 26/05/2018 3:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] NULL,
	[Phone] [nvarchar](255) NULL,
	[EmployeeName] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[WriteDate] [nvarchar](255) NULL,
	[EditDate] [nvarchar](255) NULL,
	[EditorId] [int] NULL,
	[WriterId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OAuth]    Script Date: 26/05/2018 3:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OAuth](
	[Id] [varchar](255) NOT NULL,
	[Email] [varchar](255) NULL,
	[Token] [varchar](255) NULL,
	[Photo] [varchar](255) NULL,
	[Name] [nvarchar](255) NULL,
 CONSTRAINT [PK_OAuth] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 26/05/2018 3:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] NOT NULL,
	[ProductName] [nvarchar](255) NULL,
	[Price] [bigint] NULL,
	[Barcode] [varchar](255) NULL,
	[Qty] [int] NULL,
	[ProductGroupId] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[ProductGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductGroup]    Script Date: 26/05/2018 3:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductGroup](
	[ProductGroupId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[ProductGroupName] [nvarchar](255) NULL,
	[Remark] [nvarchar](255) NULL,
 CONSTRAINT [PK_ProductGroup_1] PRIMARY KEY CLUSTERED 
(
	[ProductGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 26/05/2018 3:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[SaleId] [int] NOT NULL,
	[CustomerId] [int] NULL,
	[EmployeeId] [int] NULL,
	[SaleDate] [datetime] NULL,
	[Status] [int] NULL,
	[Note] [nvarchar](255) NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleItem]    Script Date: 26/05/2018 3:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleItem](
	[SaleItemId] [int] NOT NULL,
	[SaleId] [int] NULL,
	[ProductId] [int] NULL,
	[Qty] [int] NULL,
 CONSTRAINT [PK_SaleItem] PRIMARY KEY CLUSTERED 
(
	[SaleItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 26/05/2018 3:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Username] [varchar](255) NOT NULL,
	[Password] [varchar](255) NULL,
	[LastLogin] [datetime] NULL,
	[Email] [varchar](255) NULL,
	[EmployeeId] [int] NULL,
	[Token] [varchar](255) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customer] ([CustomerId], [Phone], [Email], [CustomerName], [isVender], [isCustomer], [WriteDate], [EditDate], [WriterId], [EditorId]) VALUES (2, N'123456789', N'Tien@gmail.com', N'Trần Quang Tiến', 1, 1, N'', N'', 0, 0)
GO
INSERT [dbo].[Customer] ([CustomerId], [Phone], [Email], [CustomerName], [isVender], [isCustomer], [WriteDate], [EditDate], [WriterId], [EditorId]) VALUES (1, N'01674404746', N'nguyenhoangduy1997@gmail.com', N'Nguyen Hoang Duy', 1, 1, N'', N'', 0, 0)
GO
INSERT [dbo].[Customer] ([CustomerId], [Phone], [Email], [CustomerName], [isVender], [isCustomer], [WriteDate], [EditDate], [WriterId], [EditorId]) VALUES (3, N'qqq', N'qq', N'qqqq', 0, 1, N'', N'', 0, 0)
GO
INSERT [dbo].[Employee] ([EmployeeId], [Phone], [EmployeeName], [Email], [Address], [WriteDate], [EditDate], [EditorId], [WriterId]) VALUES (1, N'01674404746', N'Nguyen Hoàng Duy', N'nguyenhoangduy1997@gmail.com', N'Q5', N'', N'', 0, 0)
GO
INSERT [dbo].[Employee] ([EmployeeId], [Phone], [EmployeeName], [Email], [Address], [WriteDate], [EditDate], [EditorId], [WriterId]) VALUES (3, N'123456789', N'Duy', N'asdasdl@gmail.com', N'Q8', N'', N'', 0, 0)
GO
INSERT [dbo].[OAuth] ([Id], [Email], [Token], [Photo], [Name]) VALUES (N'115393469596787670000', N'nguyenhoangduy1997@gmail.com', N'ya29.GlvHBbfTzTE33F-dQrOz7TDzMVnq3Kz70RdVuIqfc6DagFbP3_xmc9fNoO2igntFfzLnX4XFi3k0NxD-G85TvADUDWAU_rX2AIUtXXtiSvfhQGz6JP1DH2rYCmtK', N'https://lh3.googleusercontent.com/-zNi6M5Usdb8/AAAAAAAAAAI/AAAAAAAAAC0/wGrTpe3Q5C4/s96-c/photo.jpg', N'hoang duy Nguyen')
GO
INSERT [dbo].[Product] ([ProductId], [ProductName], [Price], [Barcode], [Qty], [ProductGroupId]) VALUES (1, N'GTX 1050', 3400000, N'8934588873058', 10, 0)
GO
INSERT [dbo].[Product] ([ProductId], [ProductName], [Price], [Barcode], [Qty], [ProductGroupId]) VALUES (2, N'GTX 1080Ti', 30000000, N'8934588873058', 10, 0)
GO
INSERT [dbo].[ProductGroup] ([ProductGroupId], [ProductId], [ProductGroupName], [Remark]) VALUES (1, 1, N'GTX1', N'')
GO
INSERT [dbo].[ProductGroup] ([ProductGroupId], [ProductId], [ProductGroupName], [Remark]) VALUES (2, 1, N'Linh Kiện Điện Tử', N'')
GO
INSERT [dbo].[Sale] ([SaleId], [CustomerId], [EmployeeId], [SaleDate], [Status], [Note]) VALUES (2, 1, 1, CAST(N'2018-05-24T00:00:00.000' AS DateTime), 1, N'')
GO
INSERT [dbo].[Sale] ([SaleId], [CustomerId], [EmployeeId], [SaleDate], [Status], [Note]) VALUES (3, 1, 1, CAST(N'2018-05-24T00:00:00.000' AS DateTime), 1, N'')
GO
INSERT [dbo].[SaleItem] ([SaleItemId], [SaleId], [ProductId], [Qty]) VALUES (7, 2, 1, 9)
GO
INSERT [dbo].[SaleItem] ([SaleItemId], [SaleId], [ProductId], [Qty]) VALUES (8, 2, 2, 1)
GO
INSERT [dbo].[SaleItem] ([SaleItemId], [SaleId], [ProductId], [Qty]) VALUES (9, 3, 1, 19)
GO
INSERT [dbo].[SaleItem] ([SaleItemId], [SaleId], [ProductId], [Qty]) VALUES (10, 3, 2, 5)
GO
INSERT [dbo].[User] ([Username], [Password], [LastLogin], [Email], [EmployeeId], [Token]) VALUES (N'admin', N'21232f297a57a5a743894a0e4a801fc3', CAST(N'2018-05-25T12:11:15.000' AS DateTime), N'nguyenhoangduy1997@gmail.com', 1, N'jmgi4ge1xdwnuvlinbk0g4zm')
GO
