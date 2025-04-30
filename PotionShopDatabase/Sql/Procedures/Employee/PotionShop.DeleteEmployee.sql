CREATE OR ALTER PROCEDURE PotionShop.DeleteEmployee
	@EmployeeID INT
AS
Begin
Delete 
From PotionShop.Employee
Where EmployeeID = @EmployeeID
End