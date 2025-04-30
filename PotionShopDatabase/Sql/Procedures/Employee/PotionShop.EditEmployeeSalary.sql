CREATE OR ALTER PROCEDURE PotionShop.EditEmployeeSalary
	@FirstName NVARCHAR(32),
	@LastName NVARCHAR(32),
	@StoreID INT,
	@NewSalary INT
AS
Begin
Merge PotionShop.Employee E
Using (Select @FirstName as FirstName, @LastName as LastName, @StoreID as StoreID) as Search on E.StoreID = Search.StoreID And Search.FirstName = E.FirstName And Search.LastName = E.LastName
When Matched Then
Update
Set Salary = @NewSalary;
End