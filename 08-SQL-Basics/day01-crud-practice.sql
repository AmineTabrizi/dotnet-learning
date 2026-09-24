CREATE DATABASE StoreDb;
GO

USE StoreDb;
GO

CREATE TABLE Products (
    Id INT,
    Title VARCHAR(50),
    Category VARCHAR(50),
    Price INT,
    Stock INT
);
GO

INSERT INTO Products (Id, Title, Category, Price, Stock)
VALUES (1, 'Laptop', 'Electronics', 1000, 5);

INSERT INTO Products (Id, Title, Category, Price, Stock)
VALUES (2, 'Mouse', 'Electronics', 20, 15);

INSERT INTO Products (Id, Title, Category, Price, Stock)
VALUES (3, 'Book', 'Books', 30, 0);

INSERT INTO Products (Id, Title, Category, Price, Stock)
VALUES (4, 'Cup', NULL, 10, 8);
GO

SELECT * FROM Products;

SELECT DISTINCT Category FROM Products;

SELECT * FROM Products 
WHERE Price > 25 AND Category = 'Electronics';

SELECT * FROM Products 
WHERE Category IS NULL;

SELECT * FROM Products 
ORDER BY Price DESC;

UPDATE Products 
SET Price = 25 
WHERE Id = 2;

DELETE FROM Products 
WHERE Stock = 0;

SELECT * FROM Products;