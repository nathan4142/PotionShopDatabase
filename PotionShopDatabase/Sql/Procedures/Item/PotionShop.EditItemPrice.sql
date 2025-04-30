CREATE OR ALTER PROCEDURE PotionShop.EditItemPrice
	@ItemID INT,
	@NewPrice Decimal(18,2)
AS
Begin
Update PotionShop.Item
Set Price = @NewPrice
Where ItemID = @ItemID
End
