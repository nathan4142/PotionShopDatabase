CREATE OR ALTER PROCEDURE PotionShop.GetStoreInventoryValueByStore
	@StoreID INT
AS
BEGIN
	SELECT
		S.StoreID,
		S.[Address],
		S.StateCode,
		S.ZipCode,
		COALESCE(SUM(SI.Quantity * SI.UnitListPrice), 0) AS InventoryValue
	FROM PotionShop.StoreItem SI
		INNER JOIN PotionShop.Store S ON S.StoreID = SI.StoreID
	WHERE S.StoreID = @StoreID
	GROUP BY
		S.StoreID,
		S.[Address],
		S.StateCode,
		S.ZipCode;
END;
GO