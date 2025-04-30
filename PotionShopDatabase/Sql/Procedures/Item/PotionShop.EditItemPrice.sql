CREATE OR ALTER PROCEDURE PotionShop.EditItemPrice
	@PotionName NVARCHAR(100),
	@NewPrice Decimal(18,2)
AS
Begin
Merge PotionShop.Item I
Using (Select @PotionName as [Name]) as E on I.[Name] = E.[Name]
When Matched Then
Update
set Price = @NewPrice;
End
