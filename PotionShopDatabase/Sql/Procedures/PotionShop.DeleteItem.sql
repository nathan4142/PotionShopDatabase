CREATE OR ALTER PROCEDURE PotionShop.DeleteItem
	@PotionName NVARCHAR(100)
AS
Begin
Merge PotionShop.Item I
Using (Select @PotionName as [Name]) as E on I.[Name] = E.[Name]
When Matched Then
Delete;
End
