IF OBJECT_ID(N'PotionShop.StoreItem') IS NULL
BEGIN
	CREATE TABLE PotionShop.StoreItem
	(
		StoreItemID INT NOT NULL IDENTITY(1, 1),
		ItemID INT NOT NULL,
		StoreID INT NOT NULL,
		Quantity INT NOT NULL DEFAULT(0), --Dont know if we need default
		UnitListPrice INT NOT NULL,

		CONSTRAINT PK_PotionShop_StoreItem_StoreItemID PRIMARY KEY CLUSTERED
		(
			StoreItemID ASC
		),

		CONSTRAINT [FK_PotionShop_StoreItem_PotionShop_Item] FOREIGN KEY(ItemID) --Might want to change its name but idk
		REFERENCES PotionShop.Store(ItemID),

		CONSTRAINT [FK_PotionShop_StoreItem_PotionShop_Store] FOREIGN KEY(StoreID)
		REFERENCES PotionShop.Store(StoreID)

		
	);
END;

/****************************
 * Unique Constraints
 ****************************/

 /*
 I Dont even know if we need to have a unique constraint on ItemID and StoreID. It might make things weird. Ill comment it out and when we
 test it and we see that it needs a unique constraint we can easily add it back
 */
 IF NOT EXISTS
	(
		SELECT *
		FROM sys.key_constraints kc
		WHERE kc.parent_object_id = OBJECT_ID(N'PotionShop.StoreItem')
			AND kc.[name] = N'UK_PotionShop_StoreItem_ItemID_StoreID'
	)
BEGIN
	ALTER TABLE PotionShop.StoreItem
	ADD CONSTRAINT [UK_PotionShop_StoreItem_ItemID_StoreID] UNIQUE NONCLUSTERED
	(
		ItemID,
		StoreID
	)
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
         AND fk.[name] = N'FK_PotionShop_StoreItem_PotionShop_Item'	      --The name
	)
BEGIN
	ALTER TABLE PotionShop.StoreItem		--This table
	ADD CONSTRAINT [FK_PotionShop_StoreItem_PotionShop_Item] FOREIGN KEY	--This table
	(
		StoreID
	)
	REFERENCES PotionShop.Store			--TABLE IT REFERENCES
	(
		StoreID
	);
END;