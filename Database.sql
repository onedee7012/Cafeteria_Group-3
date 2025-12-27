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

CREATE TABLE Menu
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'NotNamed'
)
GO

CREATE TABLE Beverage
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'NotNamed',
	idMenu INT NOT NULL,
	price INT NOT NULL DEFAULT 0,
	image NVARCHAR(300) NULL,

	FOREIGN KEY (idMenu) REFERENCES dbo.Menu(id)
)
GO

INSERT INTO dbo.Menu (name)
VALUES ("Coffee"), ("Tea"), ("Frappuccino"), ("Others")
GO 

INSERT INTO dbo.Beverage (name, idMenu, price, image)
VALUES ('Matcha latte', 4, 39000, NULL)
GO
INSERT INTO dbo.Beverage (name, idMenu, price, image)
VALUES ('Capuccino', 1, 39000, NULL)
GO
INSERT INTO dbo.Beverage (name, idMenu, price, image)
VALUES ('Peach tea', 2, 39000, NULL)
GO
INSERT INTO dbo.Beverage (name, idMenu, price, image)
VALUES ('Strawberry yoghurt', 3, 49000, NULL)
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

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckin DATE NOT NULL DEFAULT GETDATE(),
	DateCheckout DATETIME,
	staff NVARCHAR(100) NOT NULL DEFAULT N'Notnamed',
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0,
	idMember INT NULL DEFAULT 0,
	nameMember NVARCHAR(100) NOT NULL DEFAULT N'Notnamed',
	discount INT,
	totalPrice FLOAT,
	point FLOAT NOT NULL DEFAULT 0,

	FOREIGN KEY (idTable) REFERENCES dbo.CoffeeTable(id)
)
GO

CREATE TABLE BillInfor
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idBeverage	INT NOT NULL,
	quantity INT NOT NULL DEFAULT 0,

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idBeverage) REFERENCES dbo.Beverage(id)
)
GO

CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill 
			(DateCheckin, DateCheckout, staff, idTable, status, idMember, nameMember, discount)
	VALUES (GETDATE(), NULL, N'Notnamed', @idTable, 0, 0, 0, 0)
	SELECT SCOPE_IDENTITY();
END
GO


CREATE PROC USP_InsertBillInfor
@idBill INT, @idBeverage INT, @count INT
AS
BEGIN
	DECLARE @isExistBillInfor INT
	DECLARE @beverageCount INT = 1

	SELECT @isExistBillInfor = id, @beverageCount = dbo.BillInfor.quantity FROM dbo.BillInfor 
	WHERE idBill = @idBill AND idBeverage = @idBeverage

	IF (@isExistBillInfor > 0)
	BEGIN
		DECLARE @newCount INT = @beverageCount + @count
		
		IF (@newCount > 0)
			UPDATE dbo.BillInfor SET quantity = @beverageCount + @count WHERE idBeverage = @idBeverage
		ELSE
			DELETE dbo.BillInfor WHERE idBill = @idBill AND idBeverage = @idBeverage
	END

	ELSE
	BEGIN
		INSERT dbo.BillInfor (idBill, idBeverage, quantity)
		VALUES (@idBill, @idBeverage, @count)
	END
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = id FROM inserted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	DECLARE @count int = 0
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0

	IF (@count = 0)
		UPDATE dbo.CoffeeTable SET status = N'Empty' WHERE id = @idTable
END
GO

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfor FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT idBill = idBill FROM inserted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0
	UPDATE dbo.CoffeeTable SET status = N'Full' WHERE id = @idTable
END
GO 

CREATE TABLE Ingredient
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	supplier NVARCHAR(100) NOT NULL,
	quantity INT NOT NULL,
	usedquantity INT NOT NULL,
	leftquantity INT NOT NULL,
	dateIn NVARCHAR(100) NOT NULL,
	dateOut NVARCHAR(100) NOT NULL,
)
GO

CREATE TABLE Membership
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	dateofbirth NVARCHAR(100) NOT NULL,
	phonenumber NVARCHAR(100) NOT NULL,
	totalpoint FLOAT NOT NULL DEFAULT 0,
)
GO

CREATE PROC USP_GetListBillByDateTime
@checkin datetime, @checkout datetime
AS 
BEGIN
	SELECT dbo.Bill.idTable, dbo.Bill.id, dbo.CoffeeTable.name, DateCheckin, DateCheckout, discount, dbo.Bill.totalPrice, dbo.Bill.idMember, dbo.Bill.nameMember, dbo.Bill.staff
	FROM dbo.Bill, dbo.CoffeeTable
	WHERE DateCheckin >= @checkin AND DateCheckout <= @checkout AND dbo.Bill.status = 1 AND dbo.CoffeeTable.id = dbo.Bill.idTable
END
GO

CREATE PROC USP_GetListBillByDateAndPage
@checkin date, @checkout date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows

	;WITH BillShow AS (SELECT dbo.Bill.id, dbo.CoffeeTable.name, dbo.Bill.totalPrice, DateCheckin, DateCheckout, discount, staff
	FROM dbo.Bill, dbo.CoffeeTable
	WHERE DateCheckin >= @checkin AND DateCheckout <= @checkout AND dbo.Bill.status = 1 AND dbo.CoffeeTable.id = dbo.Bill.idTable)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN (SELECT TOP (@exceptRows) id FROM BillShow)
END
GO

CREATE PROC USP_GetNumberBillByDate
@checkin date, @checkout date
AS
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill, dbo.CoffeeTable
	WHERE DateCheckin >= @checkin AND DateCheckout <= @checkout AND dbo.Bill.status = 1 AND dbo.CoffeeTable.id = dbo.Bill.idTable 
END
GO

CREATE PROC USP_GetListBill
@checkin date, @checkout date
AS 
BEGIN
	SELECT DateCheckin, DateCheckout, dbo.BillInfor.idBill, dbo.BillInfor.idBeverage, dbo.Beverage.name, dbo.BillInfor.quantity
	FROM dbo.Bill, dbo.BillInfor, dbo.Beverage
	WHERE DateCheckin >= @checkin AND DateCheckout <= @checkout AND dbo.Bill.status = 1 AND dbo.Beverage.id = dbo.BillInfor.idBeverage AND dbo.Bill.id = dbo.BillInfor.idBill 
END
GO

CREATE PROC USP_UpdateAccount
@username nvarchar(100), @fullname nvarchar(100), @password nvarchar(100), @newpassword nvarchar(100), @image nvarchar(300)
AS
BEGIN
	DECLARE @isRightPassword INT

	SELECT @isRightPassword = COUNT(*) FROM dbo.Account WHERE UserName = @username AND PassWord = @password

	IF (@isRightPassword = 1)
	BEGIN
		IF (@newpassword = NULL OR @newpassword = '')
		BEGIN
			UPDATE dbo.Account SET FullName = @fullname, Image = @image WHERE UserName = @username
		END
		ELSE
			UPDATE dbo.Account SET FullName = @fullname, Image = @image, PassWord = @newpassword WHERE UserName = @username
		END
END
GO