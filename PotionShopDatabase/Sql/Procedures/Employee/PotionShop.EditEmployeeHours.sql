CREATE PROCEDURE PotionShop.EditEmployeeHours
    @EmployeeID INT,
    @NewHours NVARCHAR(64)
AS
BEGIN
    UPDATE PotionShop.Employee
    SET EmployeeHours = @NewHours
    WHERE EmployeeID = @EmployeeID;
END;