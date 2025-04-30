CREATE PROCEDURE PotionShop.EditEmployeeGoldStars
    @EmployeeID INT,
    @NewGoldStars INT
AS
BEGIN
    UPDATE PotionShop.Employee
    SET GoldStars = @NewGoldStars
    WHERE EmployeeID = @EmployeeID;
END;