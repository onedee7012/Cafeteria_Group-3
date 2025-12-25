CREATE DATABASE Cafe
GO

USE Cafe
GO

CREATE TABLE Account
(
	FullName NVARCHAR(100) NOT NULL DEFAULT N'Staff',
	UserName NVARCHAR(100) PRIMARY KEY,
	DateofBirth NVARCHAR(100) NOT NULL,
	PassWord NVARCHAR(100) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0,
	Image NVARCHAR(300) NULL,
)
GO

INSERT INTO dbo.Account
	(FullName, UserName, DateofBirth, PassWord, Type, Image)
VALUES ('Boss', 'admin', '11/12/2005', 1, 1, NULL)
GO 

CREATE PROC USP_GetAccountByUserName
@username nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @username
END
GO

CREATE PROC USP_Login
@username nvarchar(100), @password nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @username AND PassWord = @password
END
GO

CREATE TABLE CoffeeTable
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'NotNamed',
	status NVARCHAR(100) NOT NULL DEFAULT N'Empty'  
)
GO

DECLARE @i INT = 0
WHILE @i <= 12
BEGIN 
	INSERT dbo.CoffeeTable (name) VALUES ( N'Table ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.CoffeeTable
GO