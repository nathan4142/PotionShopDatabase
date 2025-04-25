CREATE OR ALTER PROCEDURE PotionShop.GetAllEmployees
AS

SELECT E.EmployeeID, E.StoreID, E.FirstName, E.LastName, E.EmployeeHours, E.Salary, E.Position, E.GoldStars
FROM PotionShop.Employee E;
GO
