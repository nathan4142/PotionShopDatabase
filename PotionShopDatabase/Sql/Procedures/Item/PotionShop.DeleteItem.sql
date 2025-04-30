CREATE OR ALTER PROCEDURE PotionShop.DeleteItem
	@ItemID INT
AS
Begin
Delete
From PotionShop.Item
Where ItemID = @ItemID
End
