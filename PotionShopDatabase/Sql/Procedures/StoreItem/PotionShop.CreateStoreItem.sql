CREATE OR ALTER PROCEDURE PotionShop.CreateStoreItem
	@StoreID INT,
	@ItemID INT,
	@Quantity INT,
	@UnitListPrice DECIMAL(5,2),
	@StoreItemID INT OUTPUT
AS

INSERT PotionShop.StoreItem(ItemID, StoreID, Quantity, UnitListPrice)
VALUES(@ItemID, @StoreID, @Quantity, @UnitListPrice);

SET @StoreItemID = SCOPE_IDENTITY();
GO