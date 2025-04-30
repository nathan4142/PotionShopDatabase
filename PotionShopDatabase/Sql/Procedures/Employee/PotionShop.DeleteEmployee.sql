CREATE OR ALTER PROCEDURE PotionShop.DeleteEmployee
	@FirstName NVARCHAR(32),
	@LastName NVARCHAR(32),
	@StoreID INT
AS
Begin
Merge PotionShop.Employee E
Using (Select @FirstName as FirstName, @LastName as LastName, @StoreID as StoreID) as Search on E.FirstName = Search.FirstName And E.LastName = Search.LastName And E.StoreID = Search.StoreID
When Matched Then
Delete;
End