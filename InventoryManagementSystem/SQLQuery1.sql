SELECT TOP (1000) [id]
      ,[username]
      ,[password]
      ,[role]
      ,[status]
      ,[date]
  FROM [inventory_management].[dbo].[users]
INSERT INTO users (username,password,role,status,date)Values('admin','admin123','Admin','active','2025-06-20')