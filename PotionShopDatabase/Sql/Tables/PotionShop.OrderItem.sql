IF OBJECT_ID(N'PotionShop.OrderItem') IS NULL
BEGIN
	CREATE TABLE PotionShop.OrderItem
	(
		OrderID INT NOT NULL,
		StoreItemID INT NOT NULL,
		ItemQuantity INT NOT NULL DEFAULT(1),

		CONSTRAINT PK_PotionShop_OrderItem_OrderID_StoreItemID PRIMARY KEY CLUSTERED
		(
			OrderID ASC,
			StoreItemID ASC
		),

		CONSTRAINT [FK_PotionShop_OrderItem_PotionShop_Order] FOREIGN KEY(OrderID)
			REFERENCES PotionShop.[Order](OrderID),

		CONSTRAINT [FK_PotionShop_OrderItem_PotionShop_StoreItem] FOREIGN KEY(StoreItemID)
			REFERENCES PotionShop.StoreItem(StoreItemID)

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
	WHERE fk.parent_object_id = OBJECT_ID(N'PotionShop.OrderItem')
		AND fk.referenced_object_id = OBJECT_ID(N'PotionShop.[Order]')
		AND fk.[name] = N'FK_PotionShop_OrderItem_PotionShop_Order'
 )
 BEGIN
	ALTER TABLE PotionShop.OrderItem
	ADD CONSTRAINT [FK_PotionShop_OrderItem_PotionShop_Order] FOREIGN KEY
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
	WHERE fk.parent_object_id = OBJECT_ID(N'PotionShop.OrderItem')
		AND fk.referenced_object_id = OBJECT_ID(N'PotionShop.StoreItem')
		AND fk.[name] = N'FK_PotionShop_OrderItem_PotionShop_StoreItem'
 )
 BEGIN
	ALTER TABLE PotionShop.OrderItem
	ADD CONSTRAINT [FK_PotionShop_OrderItem_PotionShop_StoreItem] FOREIGN KEY
	(
		StoreItemID
	)
	REFERENCES PotionShop.StoreItem
	(
		StoreItemID
	);
END;