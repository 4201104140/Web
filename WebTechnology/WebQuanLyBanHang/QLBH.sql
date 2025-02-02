Create database [QLBH]
GO
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
	[ProductId] [nvarchar](6) NOT NULL,
	[ProductName] [nvarchar](255) NULL,
	[Images] [nvarchar](500) NULL,
	[ProductDescription] [nvarchar](500) NULL,
	[ProductDetail] [nvarchar](500) NULL,
	[ProductQuantity] [float] NOT NULL,
	[ProductPrice] [float] NULL,
	[Barcode] [varchar](50) NULL,
	[SaleOff] [float] null,
	[SaleOffDate] [datetime] null,
	[CategoryId] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductGroup]    Script Date: 26/05/2018 3:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [nvarchar](6) NOT NULL,
	[CategoryParentId] [nvarchar](6) NULL,
	[CategoryIcon] [nvarchar](20) NULL,
	[CategoryName] [nvarchar](250) NULL,
	[CategoryRemark] [nvarchar](250) NULL,
 CONSTRAINT [PK_Category_1] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 26/05/2018 3:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[SaleId] [nvarchar](6) NOT NULL,
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
	[SaleItemId] [nvarchar](6) NOT NULL,
	[SaleId] [nvarchar](6) NULL,
	[ProductId] [nvarchar](6) NULL,
	[ProductQuantity] [float] NULL,
	[ProductPrice] [float] 
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
INSERT INTO [dbo].[Product] ([ProductId], [ProductName], [Images], [ProductDescription], [ProductDetail], [ProductQuantity], [ProductPrice], [Barcode], [SaleOff], [SaleOffDate], [CategoryId]) VALUES (N'ba001', N'Bánh dừa nướng 180g', NULL, N'Bánh dừa nướng hiệu Thái BÌnh nổi tiếng Quảng Nam Đà Nẵng. Bao bì nylon , bên trong có 12 thẻ bánh nhỏ. Bánh dòn, ngọt thơm mùi cơm dừa, thích hợp dùng với trà và cà phê. Bánh được làm từ nguyên liệu tự nhiên không phụ phẩm như dừa, đường, nếp, vanilla nhập khẩu từ Pháp.', NULL, 20, 35000, N'1441703893695', 34, N'2019-12-20 00:00:00', N'ba')
INSERT INTO [dbo].[Product] ([ProductId], [ProductName], [Images], [ProductDescription], [ProductDetail], [ProductQuantity], [ProductPrice], [Barcode], [SaleOff], [SaleOffDate], [CategoryId]) VALUES (N'ba002', N'Bánh Trứng Tik-Tok Bơ Sữa (120g)', NULL, N'Lớp bánh trứng giòn tan, nồng nàn hương vị. Độ ngọt vừa phải dễ dàng kết hợp các loại trà, nước. Bao bì tiện lợi, đẹp mắt, thích hợp làm quà tặng ngày Tết. Nguyên liệu chọn lọc, dây chuyền sản xuất hiện đại', NULL, 20, 23000, N'8935225806439', 10, N'2019-12-20 00:00:00', N'ba')
GO
INSERT INTO [dbo].[Category] ([CategoryId], [CategoryParentId], [CategoryIcon], [CategoryName], [CategoryRemark]) VALUES (N'bk', NULL, NULL, N'Bánh kẹo', N'')
INSERT INTO [dbo].[Category] ([CategoryId], [CategoryParentId], [CategoryIcon], [CategoryName], [CategoryRemark]) VALUES (N'ba', N'bk', NULL, N'Bánh', N'')
INSERT INTO [dbo].[Category] ([CategoryId], [CategoryParentId], [CategoryIcon], [CategoryName], [CategoryRemark]) VALUES (N'ke', N'bk', NULL, N'Kẹo', N'')
INSERT INTO [dbo].[Category] ([CategoryId], [CategoryParentId], [CategoryIcon], [CategoryName], [CategoryRemark]) VALUES (N'sn', N'bk', NULL, N'Snack', N'')
INSERT INTO [dbo].[Category] ([CategoryId], [CategoryParentId], [CategoryIcon], [CategoryName], [CategoryRemark]) VALUES (N'so', N'bk', NULL, N'Socola', N'')
GO
INSERT [dbo].[Sale] ([SaleId], [CustomerId], [EmployeeId], [SaleDate], [Status], [Note]) VALUES (2, 1, 1, CAST(N'2018-05-24T00:00:00.000' AS DateTime), 1, N'')
GO
INSERT [dbo].[Sale] ([SaleId], [CustomerId], [EmployeeId], [SaleDate], [Status], [Note]) VALUES (3, 1, 1, CAST(N'2018-05-24T00:00:00.000' AS DateTime), 1, N'')
GO
INSERT [dbo].[SaleItem] ([SaleItemId], [SaleId], [ProductId], [ProductQuantity]) VALUES (7, 2, 1, 9)
GO
INSERT [dbo].[SaleItem] ([SaleItemId], [SaleId], [ProductId], [ProductQuantity]) VALUES (8, 2, 2, 1)
GO
INSERT [dbo].[SaleItem] ([SaleItemId], [SaleId], [ProductId], [ProductQuantity]) VALUES (9, 3, 1, 19)
GO
INSERT [dbo].[SaleItem] ([SaleItemId], [SaleId], [ProductId], [ProductQuantity]) VALUES (10, 3, 2, 5)
GO
INSERT [dbo].[User] ([Username], [Password], [LastLogin], [Email], [EmployeeId], [Token]) VALUES (N'admin', N'21232f297a57a5a743894a0e4a801fc3', CAST(N'2018-05-25T12:11:15.000' AS DateTime), N'nguyenhoangduy1997@gmail.com', 1, N'jmgi4ge1xdwnuvlinbk0g4zm')
GO
