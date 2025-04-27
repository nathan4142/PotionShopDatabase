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