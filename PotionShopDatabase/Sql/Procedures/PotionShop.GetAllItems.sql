CREATE OR ALTER PROCEDURE PotionShop.GetAllItems
AS

SELECT I.ItemID, I.[Name], I.Price, I.PotionTypeID
FROM PotionShop.Item I;
GO
