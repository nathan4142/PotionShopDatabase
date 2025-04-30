CREATE OR ALTER PROCEDURE PotionShop.DeleteStoreItem
	@StoreItemID INT
AS
Begin
Delete
From PotionShop.StoreItem
Where StoreItemID = @StoreItemID
End