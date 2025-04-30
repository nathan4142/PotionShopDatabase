CREATE OR ALTER PROCEDURE PotionShop.EditEmployeeSalary
	@EmployeeID INT,
	@NewSalary INT
AS
Begin
Update PotionShop.Employee
Set Salary = @NewSalary
Where EmployeeID = @EmployeeID
End