DROP TABLE IF EXISTS PotionShop.Store

IF OBJECT_ID(N'PotionShop.Store') IS NULL
BEGIN
	CREATE TABLE PotionShop.Store
	(
		StoreID INT NOT NULL IDENTITY(1, 1),
		[Address] NVARCHAR(64) NOT NULL,
		StateCode NVARCHAR(2) NOT NULL,
		ZipCode NVARCHAR(6) NOT NULL,

		CONSTRAINT PK_PotionShop_Store_StoreID PRIMARY KEY CLUSTERED
		(
			StoreID ASC
		)
	);
END;

INSERT PotionShop.Store([Address], StateCode, ZipCode)
VALUES
	 (N'Wichita', N'KS', N'67215'),
 (N'Battle Creek', N'MI', N'49018'),
 (N'Tampa', N'FL', N'33661'),
 (N'Chicago', N'IL', N'60691'),
 (N'Columbia', N'SC', N'29220'),
 (N'Boston', N'MA', N'02216'),
 (N'Austin', N'TX', N'78710'),
 (N'Fresno', N'CA', N'93762'),
 (N'Brooklyn', N'NY', N'11220'),
 (N'Phoenix', N'AZ', N'85025'),
 (N'West Palm Beach', N'FL', N'33421'),
 (N'Phoenix', N'AZ', N'85099'),
 (N'Gainesville', N'FL', N'32610'),
 (N'Reston', N'VA', N'20195'),
 (N'Los Angeles', N'CA', N'90076'),
 (N'Glendale', N'AZ', N'85305'),
 (N'San Bernardino', N'CA', N'92410'),
 (N'Littleton', N'CO', N'80127'),
 (N'Kansas City', N'MO', N'64144'),
 (N'Huntsville', N'AL', N'35810'),
 (N'Phoenix', N'AZ', N'85067'),
 (N'Salinas', N'CA', N'93907'),
 (N'Daytona Beach', N'FL', N'32123'),
 (N'Charlotte', N'NC', N'28284'),
 (N'Charleston', N'WV', N'25362')
 