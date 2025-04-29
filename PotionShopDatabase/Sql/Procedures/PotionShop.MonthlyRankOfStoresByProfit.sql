CREATE OR ALTER PROCEDURE PotionShop.MonthlyRankOfStoresByProfit
AS
BEGIN
	
	WITH MonthlyStoreProfitsCTE(StoreID, OrderMonth, TotalProfit) AS
	(
		SELECT
			S.StoreID,
			MONTH(O.OrderedOn),
			SUM(SI.UnitListPrice * OI.ItemQuantity)
		FROM PotionShop.OrderItem OI
			INNER JOIN PotionShop.[Order] O ON O.OrderID = OI.OrderID
			INNER JOIN PotionShop.StoreItem SI ON SI.StoreItemID = OI.StoreItemID
			INNER JOIN PotionShop.Store S ON S.StoreID = O.StoreID
		GROUP BY S.StoreID, MONTH(O.OrderedOn)
	)
	SELECT
		MSP.StoreID,
		MSP.OrderMonth,
		MSP.TotalProfit,
		RANK() OVER (PARTITION BY MSP.OrderMonth ORDER BY TotalProfit DESC) AS StoreMonthlyRank
	FROM MonthlyStoreProfitsCTE MSP
	ORDER BY MSP.OrderMonth, StoreMonthlyRank;
END;