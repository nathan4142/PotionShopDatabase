CREATE OR ALTER PROCEDURE PotionShop.GetAllOrderStoreItems
AS

SELECT OSI.OrderID, OSI.StoreItemID, OSI.ItemQuantity
FROM PotionShop.OrderStoreItem OSI;
GO
