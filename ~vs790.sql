CREATE DATABASE Emedicine;
USE Emedicine;
CREATE TABLE Users(ID INT IDENTITY(1,1) PRIMARY KEY, FirstName VARCHAR(100) ,LastName VARCHAR(100),Password VARCHAR(100),Email VARCHAR(100), Fund DECIMAL(18,2) ,Type VARCHAR(100), Status INT ,CreatedOn Datetime);

CREATE TABLE Medicines(ID INT IDENTITY(1,1) PRIMARY KEY ,Name VARCHAR(100), Manufacturer VARCHAR(100) ,UnitPrice DECIMAL(18,2),
Discount DECIMAL(18,2), Quantity INT ,ExpDate Datetime ,ImageURL VARCHAR(100) ,Status INT)

CREATE TABLE Cart(ID INT IDENTITY(1,1) PRIMARY KEY ,UserId INT ,MedicineID INT ,UnitPrice DECIMAL(18,2) ,Discount DECIMAL(18,2),
Quantity INT, TotalPrice DECIMAL(18,2))

CREATE TABLE Orders(ID INT IDENTITY(1,1) PRIMARY KEY ,UserId INT ,OrderNo VARCHAR(100) ,OrderTotal DECIMAL(18,2) ,OrderStatus VARCHAR(100))

CREATE TABLE OrderItems(ID INT IDENTITY(1,1) PRIMARY KEY ,OrderId INT ,MedicineID INT ,UnitPrice DECIMAL(18,2) ,Discount DECIMAL(18,2),
Quantity INT, TotalPrice DECIMAL(18,2))

SELECT * FROM Users;
SELECT * FROM Medicines;
SELECT * FROM Cart;
SELECT * FROM Orders;
SELECT * FROM OrderItems;