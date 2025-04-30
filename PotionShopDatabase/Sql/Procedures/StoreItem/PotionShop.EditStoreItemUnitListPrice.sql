CREATE OR ALTER PROCEDURE PotionShop.EditStoreItemUnitPrice
	@ItemID INT,
	@StoreID INT,
	@UnitListPrice Decimal(5,2)
AS
Begin
Merge PotionShop.StoreItem SI
Using (Select @ItemID as ItemID, @StoreID as StoreID) as Search on SI.ItemID = Search.ItemID And SI.StoreID = Search.StoreID
When Matched Then
Update
Set UnitListPrice = @UnitListPrice;
End