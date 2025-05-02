IF OBJECT_ID(N'PotionShop.OrderStoreItem') IS NULL
BEGIN
	CREATE TABLE PotionShop.OrderStoreItem
	(
		OrderID INT NOT NULL,
		StoreItemID INT NOT NULL,
		ItemQuantity INT NOT NULL,

		CONSTRAINT PK_PotionShop_OrderItem_OrderID_StoreItemID PRIMARY KEY CLUSTERED
		(
			OrderID ASC,
			StoreItemID ASC
		),

		CONSTRAINT [FK_PotionShop_OrderStoreItem_PotionShop_Order] FOREIGN KEY(OrderID)
			REFERENCES PotionShop.[Order](OrderID),

		CONSTRAINT [FK_PotionShop_OrderStoreItem_PotionShop_StoreItem] FOREIGN KEY(StoreItemID)
			REFERENCES PotionShop.StoreItem(StoreItemID) ON DELETE CASCADE --If StoreItemID is delete in the storeitem table, will automatically delete any rows referencing it

	);
END;

/****************************
 * Foreign Keys Constraints
 ****************************/

 -- OrderID FK
 IF NOT EXISTS
 (
	SELECT *
	FROM sys.foreign_keys fk
	WHERE fk.parent_object_id = OBJECT_ID(N'PotionShop.OrderStoreItem')
		AND fk.referenced_object_id = OBJECT_ID(N'PotionShop.[Order]')
		AND fk.[name] = N'FK_PotionShop_OrderStoreItem_PotionShop_Order'
 )
 BEGIN
	ALTER TABLE PotionShop.OrderStoreItem
	ADD CONSTRAINT [FK_PotionShop_OrderStoreItem_PotionShop_Order] FOREIGN KEY
	(
		OrderID
	)
	REFERENCES PotionShop.[Order]
	(
		OrderID
	);
END;


 -- StoreItemID FK
 IF NOT EXISTS
 (
	SELECT *
	FROM sys.foreign_keys fk
	WHERE fk.parent_object_id = OBJECT_ID(N'PotionShop.OrderStoreItem')
		AND fk.referenced_object_id = OBJECT_ID(N'PotionShop.StoreItem')
		AND fk.[name] = N'FK_PotionShop_OrderStoreItem_PotionShop_StoreItem'
 )
 BEGIN
	ALTER TABLE PotionShop.OrderStoreItem
	ADD CONSTRAINT [FK_PotionShop_OrderStoreItem_PotionShop_StoreItem] FOREIGN KEY
	(
		StoreItemID
	)
	REFERENCES PotionShop.StoreItem
	(
		StoreItemID
	);
END;

