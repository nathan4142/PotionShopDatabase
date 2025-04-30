CREATE OR ALTER PROCEDURE PotionShop.DeleteStoreItem
	@ItemID INT,
	@StoreID INT
AS
Begin
Merge PotionShop.StoreItem SI
Using (Select @ItemID as ItemID, @StoreID as StoreID) as Search on SI.ItemID = Search.ItemID And SI.StoreID = Search.StoreID
When Matched Then
Delete;
End