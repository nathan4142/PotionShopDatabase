﻿CREATE OR ALTER PROCEDURE PotionShop.EditStoreItemUnitListPrice
	@StoreItemID INT,
	@NewUnitListPrice Decimal(5,2)
AS
Begin
Update PotionShop.StoreItem
Set UnitListPrice = @NewUnitListPrice
Where StoreItemID = @StoreItemID
End