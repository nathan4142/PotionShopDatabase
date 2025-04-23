CREATE OR ALTER PROCEDURE PotionShop.CreateStore
	@Address NVARCHAR(64),
	@StateCode NVARCHAR(2),
	@ZipCode NVARCHAR(6),
	@StoreID INT OUTPUT
AS

INSERT PotionShop.Store([Address], StateCode, ZipCode)
VALUES(@Address, @StateCode, @ZipCode);

SET @StoreID = SCOPE_IDENTITY();
GO
