IF OBJECT_ID(N'PotionShop.Item') IS NULL
BEGIN
	CREATE TABLE PotionShop.Item
	(
		ItemID INT NOT NULL IDENTITY(1,1),
		PotionTypeID INT NOT NULL,
		Price DECIMAL(5, 2) NOT NULL,
		[Name] NVARCHAR(32) NOT NULL
		
		


		CONSTRAINT [PK_PotionShop_Item_ItemID] PRIMARY KEY CLUSTERED
		(
			ItemID ASC
		),
		
		CONSTRAINT FK_PotionShop_Item_PotionShop_PotionType FOREIGN KEY(PotionTypeID)
		REFERENCES PotionShop.PotionType(PotionTypeID)
		
	);
END;

/****************************
 * Unique Constraints
 ****************************/

 IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'PotionShop.Item')
         AND kc.[name] = N'UK_PotionShop_Item_Name'
   )
BEGIN
   ALTER TABLE PotionShop.Item
   ADD CONSTRAINT [UK_PotionShop_Item_Name] UNIQUE NONCLUSTERED
   (
      [Name]
   )
END;


/*
/****************************
 * Foreign Keys Constraints
 ****************************/
IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'PotionShop.Item')
         AND fk.referenced_object_id = OBJECT_ID(N'PotionShop.PotionType')
         AND fk.[name] = N'FK_PotionShop_Item_PotionShop_PotionType'
   )
BEGIN
   ALTER TABLE PotionShop.Item
   ADD CONSTRAINT [FK_PotionShop_Item_PotionShop_PotionType] FOREIGN KEY
   (
      PotionTypeID
   )
   REFERENCES PotionShop.PotionType
   (
      PotionTypeID
   );
END;

*/


