CREATE OR ALTER PROCEDURE PotionShop.CreateOrderItem
	@OrderID INT,
	@StoreItemID INT,
	@ItemQuantity INT
AS
BEGIN
	INSERT INTO PotionShop.OrderItem(OrderID, StoreItemID, ItemQuantity)
	VALUES(@OrderID, @StoreItemID, @ItemQuantity);
END;
GO