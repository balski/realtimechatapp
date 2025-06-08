--Level1
SELECT COUNT(*) AS NumberOfCustomers
FROM Customers
WHERE Country = 'Germany';

--Level2
SELECT COUNT(*) AS [Count(CustomerID)], Country
FROM Customers
GROUP BY Country
HAVING COUNT(*) >= 5
ORDER BY COUNT(*) DESC;

--Level3
SELECT 
    Customers.CustomerName,
    COUNT(Orders.OrderID) AS OrderCount,
    FORMAT(MIN(Orders.OrderDate), 'yyyy-mm-dd') AS FirstOrder,
    FORMAT(MAX(Orders.OrderDate), 'yyyy-mm-dd') AS LastOrder
FROM 
    Customers, Orders
WHERE 
    Customers.CustomerID = Orders.CustomerID
GROUP BY 
    Customers.CustomerName
HAVING 
    COUNT(Orders.OrderID) >= 5
ORDER BY 
    MAX(Orders.OrderDate) DESC;