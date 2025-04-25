CREATE OR ALTER PROCEDURE PotionShop.CreateOrder
	@StoreID INT,
	@OrderedOn DATETIME2,
	@OrderID INT OUTPUT
AS

INSERT PotionShop.[Order](StoreID, OrderedOn)
VALUES(@StoreID, @OrderedOn);

SET @OrderID = SCOPE_IDENTITY();
GO