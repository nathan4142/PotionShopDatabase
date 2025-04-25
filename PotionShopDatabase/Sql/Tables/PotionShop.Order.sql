IF OBJECT_ID(N'PotionShop.[Order]') IS NULL
BEGIN
	CREATE TABLE PotionShop.[Order]
	(
		OrderID INT NOT NULL IDENTITY(1,1),
		StoreID INT NOT NULL,
		OrderedOn DATETIME NOT NULL,

		CONSTRAINT PK_PotionShop_Order_OrderID PRIMARY KEY CLUSTERED
		(
			OrderID ASC
		),

		CONSTRAINT [FK_PotionShop_Order_PotionShop_Store] FOREIGN KEY(StoreID)
		REFERENCES PotionShop.Store(StoreID)

	);
END;

/****************************
 * Foreign Keys Constraints
 ****************************/

--StoreID FK
 IF NOT EXISTS
	(
		SELECT *
		FROM sys.foreign_keys fk
		WHERE fk.parent_object_id = OBJECT_ID(N'PotionShop.[Order]')     --This table
         AND fk.referenced_object_id = OBJECT_ID(N'PotionShop.Store')	  --Table it references
         AND fk.[name] = N'FK_PotionShop_Order_PotionShop_Store'	      --The name
	)
BEGIN
	ALTER TABLE PotionShop.[Order]		--This table
	ADD CONSTRAINT [FK_PotionShop_Order_PotionShop_Store] FOREIGN KEY	--This table
	(
		StoreID
	)
	REFERENCES PotionShop.Store			--TABLE IT REFERENCES
	(
		StoreID
	);
END;
