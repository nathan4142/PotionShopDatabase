CREATE OR ALTER PROCEDURE PotionShop.EditEmployeePosition
	@EmployeeID INT,
	@NewPosition NVARCHAR(32)
AS
Begin
Update PotionShop.Employee
Set Position = @NewPosition
Where EmployeeID = @EmployeeID
End