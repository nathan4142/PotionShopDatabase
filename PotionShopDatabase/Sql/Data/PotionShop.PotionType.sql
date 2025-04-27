DECLARE @PotionTypeStaging TABLE
(
   PotionTypeID INT NOT NULL PRIMARY KEY,
   [Name] VARCHAR(16) NOT NULL UNIQUE
);

INSERT @PotionTypeStaging(PotionTypeID, [Name])
VALUES
   (1, 'Attack'),
   (2, 'Defence'),
   (3, 'Health'),
   (4, 'Evil'),
   (5, 'Explosion'),
   (6, 'Charm');

MERGE PotionShop.PotionType T
USING @PotionTypeStaging S ON S.PotionTypeID = T.PotionTypeID
WHEN MATCHED AND S.[Name] <> T.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT(PotionTypeID, [Name])
   VALUES(S.PotionTypeID, S.[Name]);
