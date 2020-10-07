if Exists(SELECT * FROM sysdatabases WHERE name = 'VoucherHoundDB')
DROP DATABASE VoucherHoundDB
GO

CREATE DATABASE VoucherHoundDB
ON PRIMARY
(
name = 'VoucherHoundDB',
filename = 'C:\You_Source_Training\Full_Stack_Project\VoucherHoundDB.mdf',
size = 10MB,
maxsize = 1GB,
Filegrowth = 5%
)
LOG ON
(
name = 'base_log_1',
filename = 'C:\You_Source_Training\Full_Stack_Project\base_log_1.mdf',
size = 1MB,
maxsize = 10MB,
filegrowth = 1%
)
GO

USE VoucherHoundDB
GO

CREATE TABLE Merchants
(
MerchantID	SMALLINT IDENTITY(2002,2) PRIMARY KEY,
CompanyName	VARCHAR(50) NOT NULL,
Country		VARCHAR(20) NOT NULL
)

CREATE TABLE Products
(
ProductID SMALLINT IDENTITY(1001,1) PRIMARY KEY,
MerchantID SMALLINT FOREIGN KEY REFERENCES Merchants(MerchantID),
ProductName VARCHAR(30) NOT NULL,
Quantity INT NOT NULL
)

CREATE TABLE Customers
(
CustomerID	SMALLINT IDENTITY(101,2) PRIMARY KEY,
FirstName	VARCHAR(30) NOT NULL,
LastName	VARCHAR(30) NOT NULL,
Age			SMALLINT NOT NULL,
Email		VARCHAR(40) NOT NULL,
PhoneNumber VARCHAR(15) NOT NULL
)

CREATE TABLE Orders
(
OrderID		SMALLINT IDENTITY(3002,3) PRIMARY KEY,
ProductID	SMALLINT FOREIGN KEY REFERENCES Products(ProductID),
CustomerID	SMALLINT FOREIGN KEY REFERENCES Customers(CustomerID),
SenderEmail	VARCHAR(30) NOT NULL,
RecipientEmail	VARCHAR(40) NOT NULL
)

/*	Insert Dummy Data	*/

INSERT INTO Customers(FirstName, LastName, Age, Email, PhoneNumber) 
VALUES('Gorbleas','Gands', 25 ,'james@gmail.com','098987132') 
GO

INSERT INTO Customers(FirstName, LastName, Age, Email, PhoneNumber) 
VALUES('Sarah','Supbs', 18 ,'sarah@outlook.co.za','0938933212') 
GO

INSERT INTO Customers(FirstName, LastName, Age, Email, PhoneNumber) 
VALUES('Stephen','Grambes', 45 ,'thegrambs@grambs.co.za','09739128') 
GO

INSERT INTO Customers(FirstName, LastName, Age, Email, PhoneNumber) 
VALUES('Horace','Peters', 75 ,'Horace@pete.co','00987213') 
GO

INSERT INTO Customers(FirstName, LastName, Age, Email, PhoneNumber) 
VALUES('Zooms','Zoomie', 67 ,'porebe@gmail.com','097523432') 
GO

INSERT INTO Merchants(CompanyName, Country)
VALUES('VodaGO','South-Africa')
GO

INSERT INTO Merchants(CompanyName, Country)
VALUES('OnlineVouchers','Sweden')
GO

INSERT INTO Merchants(CompanyName, Country)
VALUES('ZoneVouchers','Thailand')
GO

USE VoucherHoundDB
GO

INSERT INTO Products(MerchantID, ProductName, Quantity)
VALUES (2002, 'VodagoForSure', 18)

INSERT INTO Products(MerchantID, ProductName, Quantity)
VALUES (2002, 'VodaCome', 14)

INSERT INTO Products(MerchantID, ProductName, Quantity)
VALUES (2002, 'VodaSum16', 22)

INSERT INTO Products(MerchantID, ProductName, Quantity)
VALUES (2004, 'OV16', 8)

INSERT INTO Products(MerchantID, ProductName, Quantity)
VALUES (2004, 'OV102', 118)

INSERT INTO Products(MerchantID, ProductName, Quantity)
VALUES (2006, 'ZoneBeijing', 14)

INSERT INTO Products(MerchantID, ProductName, Quantity)
VALUES (2006, 'ZoneVoucherToGO', 17)

INSERT INTO Products(MerchantID, ProductName, Quantity)
VALUES (2006, 'ZoneToGo', 28)

/*	Stored Procedures	*/

