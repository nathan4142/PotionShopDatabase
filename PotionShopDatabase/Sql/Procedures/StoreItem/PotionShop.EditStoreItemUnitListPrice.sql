CREATE OR ALTER PROCEDURE PotionShop.EditStoreItemUnitPrice
	@StoreItemID INT,
	@UnitListPrice Decimal(5,2)
AS
Begin
Update PotionShop.StoreItem
Set UnitListPrice = @UnitListPrice
Where StoreItemID = @StoreItemID
End