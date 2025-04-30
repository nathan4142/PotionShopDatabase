CREATE OR ALTER PROCEDURE PotionShop.GetNumberOfPotionsByType
	@PotionTypeID INT
AS
BEGIN

SELECT
  S.StoreID,
  S.[Address],
  S.StateCode,
  S.ZipCode,
  COALESCE(SUM(SI.Quantity),0) AS PotionCount
FROM PotionShop.Store S
  LEFT JOIN PotionShop.StoreItem SI ON SI.StoreID = S.StoreID
  LEFT JOIN PotionShop.Item I ON I.ItemID = SI.ItemID AND I.PotionTypeID = @PotionTypeID
GROUP BY S.StoreID, S.[Address], S.StateCode, S.ZipCode
ORDER BY S.StoreID;

END;