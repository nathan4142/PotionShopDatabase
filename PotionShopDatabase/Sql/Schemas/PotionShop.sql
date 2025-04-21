IF NOT EXISTS
	(
		SELECT * 
		FROM sys.schemas s
		WHERE s.[name] = N'PotionShop'
	)
BEGIN
	EXEC(N'CREATE SCHEMA [PotionShop] AUTHORIZATION [dbo]');
END;