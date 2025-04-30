CREATE OR ALTER PROCEDURE PotionShop.GetAllStoreItems
AS

SELECT SI.StoreItemID, SI.ItemID, SI.StoreID, SI.Quantity, SI.UnitListPrice
FROM PotionShop.StoreItem SI;
GO
