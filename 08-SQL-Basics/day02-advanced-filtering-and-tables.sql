SELECT MIN(Price) AS MinPrice
FROM Products
WHERE Category = 'Electronics';

SELECT MIN(Price) AS SmallestPrice, Id
FROM Products
GROUP BY Id;

SELECT Max(Price) AS MaxPrice
FROM Products;

SELECT COUNT(Category) AS CategoryCount
FROM Products;

SELECT COUNT(DISTINCT Category) AS DistinctCategoryCount
FROM Products;

SELECT COUNT(*) AS [Number of records]
FROM Products;

SELECT AVG(Price) AS AveragePrice
FROM Products;

SELECT * FROM Products
WHERE Title LIKE '%op%';

SELECT * FROM Products
WHERE Category In ('Electronics', 'Books');

UPDATE Products 
SET Price = 1500
WHERE Id = 3;

SELECT * FROM Products;

SELECT * FROM Products
WHERE Price BETWEEN 1500 AND 2500;