IF OBJECT_ID(N'PotionShop.Employee') IS NULL
BEGIN
	CREATE TABLE PotionShop.Employee
	(
		EmployeeID INT NOT NULL,
		StoreID INT NOT NULL,
		FirstName NVARCHAR(32) NOT NULL,
		LastName NVARCHAR(32) NOT NULL,
		EmployeeHours NVARCHAR(64) NOT NULL,
		Salary INT NOT NULL,
		Position NVARCHAR(32) NOT NULL,
		GoldStars INT NOT NULL DEFAULT(0),

		CONSTRAINT PK_PotionShop_Employee_EmployeeID PRIMARY KEY CLUSTERED
		(
			EmployeeID ASC
		),

		CONSTRAINT [FK_PotionShop_Employee_PotionShop_Store] FOREIGN KEY(StoreID)
		REFERENCES PotionShop.Store(StoreID)
	);
END;