SET IDENTITY_INSERT [dbo].[users] ON
INSERT INTO [dbo].[users] ([id], [username], [password], [role], [status], [date]) VALUES (2, N'test', N'admin123', N'Cashier', N'Approval', N'2023-12-11')
INSERT INTO [dbo].[users] ([id], [username], [password], [role], [status], [date]) VALUES (3, N'admin', N'admin123', N'Admin', N'Active', N'2023-12-11')
SET IDENTITY_INSERT [dbo].[users] OFF
