CREATE OR ALTER PROCEDURE PotionShop.GetAllOrders
AS

SELECT O.OrderID, O.StoreID, O.OrderedOn
FROM PotionShop.Orders O;
GO