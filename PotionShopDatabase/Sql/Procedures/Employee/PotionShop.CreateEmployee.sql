CREATE OR ALTER PROCEDURE PotionShop.CreateEmployee
	@StoreID INT,	--I think we need storeID. I am not sure though since its a foreign key
	@FirstName NVARCHAR(32),
	@LastName NVARCHAR(32),
	@EmployeeHours NVARCHAR(64),
	@Salary INT,
	@Position NVARCHAR(32),
	@GoldStars INT,
	@EmployeeID INT OUTPUT
AS

INSERT PotionShop.Employee(StoreID, FirstName, LastName, EmployeeHours, Salary, Position, GoldStars)
VALUES(@StoreID, @FirstName, @LastName, @EmployeeHours, @Salary, @Position, @GoldStars);

SET @EmployeeID = SCOPE_IDENTITY();
GO