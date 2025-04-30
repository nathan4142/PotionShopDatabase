CREATE OR ALTER PROCEDURE PotionShop.CreateStoreItem
	@StoreID INT,	--I think we need storeID. I am not sure though since its a foreign key
	@ItemID INT,
	@Quantity INT,
	@UnitListPrice DECIMAL(5,2),
	@StoreItemID INT OUTPUT
AS

INSERT PotionShop.StoreItem(ItemID, StoreID, Quantity, UnitListPrice)
VALUES(@ItemID, @StoreID, @Quantity, @UnitListPrice);

SET @StoreItemID = SCOPE_IDENTITY();
GO