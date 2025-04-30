CREATE OR ALTER PROCEDURE PotionShop.EditStoreItemQuantity
	@StoreItemID INT,
	@NewQuantity INT
AS
Begin
Update PotionShop.StoreItem
Set Quantity = @NewQuantity
Where StoreItemID = @StoreItemID
End