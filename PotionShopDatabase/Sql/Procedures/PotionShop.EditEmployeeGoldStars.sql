CREATE OR ALTER PROCEDURE PotionShop.EditEmployeeGoldStars
	@FirstName NVARCHAR(32),
	@LastName NVARCHAR(32),
	@StoreID INT,
	@NewGoldStars INT
AS
Begin
Merge PotionShop.Employee E
Using (Select @FirstName as FirstName, @LastName as LastName, @StoreID as StoreID) as Search on E.FirstName = Search.FirstName And E.LastName = Search.LastName And E.StoreID = Search.StoreID
When Matched Then
Update
Set GoldStars = @NewGoldStars;
End