IF OBJECT_ID(N'PotionShop.Item') IS NULL
BEGIN
	CREATE TABLE PotionShop.Item
	(
		ItemID INT NOT NULL IDENTITY(1,1),
		[Name] NVARCHAR(32) NOT NULL,
		Price DECIMAL(5, 2) NOT NULL,
		PotionTypeID INT NOT NULL


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




INSERT PotionShop.Item(PotionTypeID, Price, [Name])
VALUES
 (4, 537.06, N'Invisi-Fizz'),
 (1, 434.3, N'Gigglegoo'),
 (1, 48.98, N'Bouncing Banana Potion'),
 (6, 437.95, N'Spicy Yawn Syrup'),
 (2, 413.46, N'Featherfall Fizz'),
 (3, 931.85, N'Reverse Gravity Elixir'),
 (1, 764.57, N'Neon Noodle Nectar'),
 (1, 404.92, N'Bubble Beard Tonic'),
 (4, 409.37, N'Instant Itch Elixir'),
 (2, 966.08, N'Sneeze Sparkle Serum'),
 (1, 794.76, N'Quantum Pickle Potion'),
 (1, 290.77, N'Llama Lure Extract'),
 (3, 480.64, N'Teleportini'),
 (2, 808.66, N'Mood Ring Mixture'),
 (1, 154.88, N'Snail Speed Serum'),
 (2, 846.06, N'Backwards Talk Tonic'),
 (1, 701.74, N'Disco Fever Formula'),
 (4, 821.52, N'Uncontrollable Jazz Hands Juice'),
 (5, 135.15, N'Marshmallow Muscle Mix'),
 (1, 102.22, N'Flying Fish Formula'),
 (4, 377.32, N'Meow Morph Potion'),
 (1, 752.55, N'Upside-Down Umbrella Elixir'),
 (3, 63.68, N'Hiccup Honey'),
 (5, 240.68, N'Glow-in-the-Dark Glaze'),
 (5, 522.39, N'Random Accent Elixir'),
 (1, 621.05, N'Gnome Giggle Gel'),
 (4, 888.0, N'Inflat-o-Tonic'),
 (5, 439.35, N'Ghostly Goosebumps Gel'),
 (1, 399.58, N'Pirate Parrot Potion'),
 (4, 752.01, N'Chili Cheese Concoction'),
 (1, 381.99, N'Crocodile Karaoke Concentrate'),
 (4, 92.23, N'Popcorn Explosion Elixir'),
 (5, 481.21, N'Burp-o-Blast Serum'),
 (3, 763.11, N'Anti-Gravity Goop'),
 (6, 819.35, N'Time Travel Tonic (Unstable)'),
 (6, 783.42, N'Rainbow Rumble Syrup'),
 (6, 625.14, N'Chameleon Change Tonic'),
 (1, 444.43, N'Sock Magnet Solution'),
 (1, 389.8, N'Instant Confetti Spray'),
 (5, 143.38, N'Mustache Maker Elixir'),
 (1, 875.7, N'Shrinking Violet Solution'),
 (2, 363.56, N'Cactus Hug Cream'),
 (5, 395.86, N'Electric Eel Extract'),
 (1, 83.85, N'Worm Wiggle Water'),
 (3, 466.68, N'Confused Compass Concoction'),
 (3, 783.93, N'Doodlebug Drops'),
 (6, 777.02, N'Rubber Chicken Elixir'),
 (3, 902.19, N'Banana Peel Potion'),
 (1, 426.56, N'Flamingo Flamenco Fluid'),
 (4, 734.79, N'Unicorn Snore Smoothie')