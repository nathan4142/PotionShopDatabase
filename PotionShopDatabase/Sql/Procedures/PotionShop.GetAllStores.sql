CREATE OR ALTER PROCEDURE PotionShop.GetAllStores
AS

SELECT S.StoreID, S.[Address], S.StateCode, S.ZipCode
FROM PotionShop.Store S;
GO
