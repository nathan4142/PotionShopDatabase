CREATE OR ALTER PROCEDURE PotionShop.CreateOrderStoreItem
	@OrderID INT,
	@StoreItemID INT,
	@ItemQuantity INT
AS
BEGIN
	INSERT INTO PotionShop.OrderStoreItem(OrderID, StoreItemID, ItemQuantity)
	VALUES(@OrderID, @StoreItemID, @ItemQuantity);
END;
GO