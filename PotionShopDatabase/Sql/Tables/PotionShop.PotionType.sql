IF OBJECT_ID(N'PotionShop.PotionType') IS NULL
BEGIN
   CREATE TABLE PotionShop.PotionType
   (
      PotionTypeID INT NOT NULL,
      [Name] NVARCHAR(16) NOT NULL,

      CONSTRAINT PK_PotionShop_PotionType_PotionTypeID PRIMARY KEY CLUSTERED
      (
         PotionTypeID ASC
      )
   );
END;

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'PotionShop.PotionType')
         AND kc.[name] = N'UK_PotionShop_PotionType_Name'
   )
BEGIN
   ALTER TABLE PotionShop.PotionType
   ADD CONSTRAINT [UK_PotionShop_PotionType_Name] UNIQUE NONCLUSTERED
   (
      [Name] ASC
   )
END;


INSERT PotionShop.PotionType(PotionTypeID, [Name])
VALUES
   (1, 'Attack'),
   (2, 'Defence'),
   (3, 'Health'),
   (4, 'Evil'),
   (5, 'Explosion'),
   (6, 'Charm');