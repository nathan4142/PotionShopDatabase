CREATE OR ALTER PROCEDURE PotionShop.EditStoreItemQuantity
	@ItemID INT,
	@StoreID INT,
	@NewQuantity INT
AS
Begin
Merge PotionShop.StoreItem SI
Using (Select @ItemID as ItemID, @StoreID as StoreID) as Search on SI.ItemID = Search.ItemID And SI.StoreID = Search.StoreID
When Matched Then
Update
Set Quantity = @NewQuantity;
End