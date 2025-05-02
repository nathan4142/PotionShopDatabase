IF OBJECT_ID(N'PotionShop.StoreItem') IS NULL
BEGIN
	CREATE TABLE PotionShop.StoreItem
	(
		StoreItemID INT NOT NULL IDENTITY(1, 1),
		ItemID INT NOT NULL,
		StoreID INT NOT NULL,
		Quantity INT NOT NULL DEFAULT(0), --Dont know if we need default
		UnitListPrice DECIMAL(5,2) NOT NULL,

		CONSTRAINT PK_PotionShop_StoreItem_StoreItemID PRIMARY KEY CLUSTERED
		(
			StoreItemID ASC
		),

		CONSTRAINT [FK_PotionShop_StoreItem_PotionShop_Item] FOREIGN KEY(ItemID) --Might want to change its name but idk
		REFERENCES PotionShop.Item(ItemID) ON DELETE CASCADE, --If ItemID is delete in the item table, will automatically delete any rows referencing it

		CONSTRAINT [FK_PotionShop_StoreItem_PotionShop_Store] FOREIGN KEY(StoreID)
		REFERENCES PotionShop.Store(StoreID)

		
	);
END;

/****************************
 * Foreign Keys Constraints
 ****************************/

 --ItemID FK
 IF NOT EXISTS
	(
		SELECT *
		FROM sys.foreign_keys fk
		WHERE fk.parent_object_id = OBJECT_ID(N'PotionShop.StoreItem')     --This table
         AND fk.referenced_object_id = OBJECT_ID(N'PotionShop.Item')	  --Table it references
         AND fk.[name] = N'FK_PotionShop_StoreItem_PotionShop_Item'	      --The name
	)
BEGIN
	ALTER TABLE PotionShop.StoreItem		--This table
	ADD CONSTRAINT [FK_PotionShop_StoreItem_PotionShop_Item] FOREIGN KEY	--This table
	(
		ItemID
	)
	REFERENCES PotionShop.Item			--TABLE IT REFERENCES
	(
		ItemID
	);
END;

--StoreID FK
 IF NOT EXISTS
	(
		SELECT *
		FROM sys.foreign_keys fk
		WHERE fk.parent_object_id = OBJECT_ID(N'PotionShop.StoreItem')     --This table
         AND fk.referenced_object_id = OBJECT_ID(N'PotionShop.Store')	  --Table it references
         AND fk.[name] = N'FK_PotionShop_StoreItem_PotionShop_Store'	      --The name
	)
BEGIN
	ALTER TABLE PotionShop.StoreItem		--This table
	ADD CONSTRAINT [FK_PotionShop_StoreItem_PotionShop_Store] FOREIGN KEY	--This table
	(
		StoreID
	)
	REFERENCES PotionShop.Store			--TABLE IT REFERENCES
	(
		StoreID
	);
END;
