USE [Shop]
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CategoryDescription], [CategoryIcon], [CategoryParentId]) VALUES (N'a100', N'Điện thoại/Laptop/Tablet', NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CategoryDescription], [CategoryIcon], [CategoryParentId]) VALUES (N'a101', N'Điện thoại', NULL, NULL, N'a100')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CategoryDescription], [CategoryIcon], [CategoryParentId]) VALUES (N'a102', N'Laptop', NULL, NULL, N'a100')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CategoryDescription], [CategoryIcon], [CategoryParentId]) VALUES (N'a103', N'Tablet', NULL, NULL, N'a100')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CategoryDescription], [CategoryIcon], [CategoryParentId]) VALUES (N'b100', N'Phụ kiện', NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CategoryDescription], [CategoryIcon], [CategoryParentId]) VALUES (N'b101', N'Loa', NULL, NULL, N'b100')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CategoryDescription], [CategoryIcon], [CategoryParentId]) VALUES (N'b102', N'Thẻ nhớ', NULL, NULL, N'b100')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CategoryDescription], [CategoryIcon], [CategoryParentId]) VALUES (N'b103', N'Camera', NULL, NULL, N'b100')
GO
