IF OBJECT_ID(N'PotionShop.Employee') IS NULL
BEGIN
	CREATE TABLE PotionShop.Employee
	(
		EmployeeID INT NOT NULL IDENTITY(1, 1),
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


/****************************
 * Foreign Keys Constraints
 ****************************/
 IF NOT EXISTS
	(
		SELECT *
		FROM sys.foreign_keys fk
		WHERE fk.parent_object_id = OBJECT_ID(N'PotionShop.Employee')     --This table
         AND fk.referenced_object_id = OBJECT_ID(N'PotionShop.Store')	  --Table it references
         AND fk.[name] = N'FK_PotionShop_Employee_PotionShop_Store'	      --The name
	)
BEGIN
	ALTER TABLE PotionShop.Employee		--This table
	ADD CONSTRAINT [FK_PotionShop_Employee_PotionShop_Store] FOREIGN KEY	--This table
	(
		StoreID
	)
	REFERENCES PotionShop.Store			--TABLE IT REFERENCES
	(
		StoreID
	);
END;
