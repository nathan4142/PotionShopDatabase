CREATE OR ALTER PROCEDURE PotionShop.GetMonthlyRankOfStoresByProfit
	@FirstDate DATE,
	@SecondDate DATE
AS
BEGIN
	
	WITH MonthlyStoreProfitsCTE([Year], [Month], StoreID, [Address], StateCode, ZipCode, Sales) AS
	(
		SELECT
			YEAR(O.OrderedOn),
			MONTH(O.OrderedOn),
			S.StoreID,
			S.[Address],
			S.StateCode,
			S.ZipCode,
			SUM(SI.UnitListPrice * OI.ItemQuantity)
		FROM PotionShop.OrderStoreItem OI
			INNER JOIN PotionShop.[Order] O ON O.OrderID = OI.OrderID
			INNER JOIN PotionShop.StoreItem SI ON SI.StoreItemID = OI.StoreItemID
			INNER JOIN PotionShop.Store S ON S.StoreID = O.StoreID
		WHERE O.OrderedOn BETWEEN @FirstDate AND @SecondDate
		GROUP BY
			YEAR(O.OrderedOn),
			MONTH(O.OrderedOn),
			S.StoreID,
			S.[Address],
			S.StateCode,
			S.ZipCode
	)
	SELECT
		MSP.[Year],
		MSP.[Month],
		MSP.StoreID,
		MSP.[Address],
		MSP.StateCode,
		MSP.ZipCode,
		MSP.Sales,
		RANK() OVER (PARTITION BY MSP.[Year], MSP.[Month] ORDER BY MSP.Sales DESC) AS [Rank]
	FROM MonthlyStoreProfitsCTE MSP
	ORDER BY MSP.[Year], MSP.[Month], [Rank];
END;