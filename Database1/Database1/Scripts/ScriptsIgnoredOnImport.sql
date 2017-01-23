
SELECT CustomerID, ContactName FROM Customers;
GO

SELECT * FROM Customers;
GO

SELECT COUNT(ContactName)FROM Customers WHERE Country = 'Germany';
GO

SELECT * FROM Customers WHERE Country = 'Brazil';
GO

SELECT * FROM Customers WHERE Country = 'Brazil' AND City = 'Sao Paulo' ;
GO
