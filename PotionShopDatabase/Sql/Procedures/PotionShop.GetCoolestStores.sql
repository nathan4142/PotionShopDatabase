CREATE OR ALTER PROCEDURE PotionShop.GetCoolestStores
    @GoldStars INT
AS
BEGIN
    SELECT 
        S.StoreID, S.[Address], S.StateCode, S.ZipCode,
        SUM(E.GoldStars) AS TotalGoldStars
    FROM PotionShop.Store S
    INNER JOIN 
        PotionShop.Employee E ON S.StoreID = E.StoreID
    GROUP BY 
        S.StoreID, S.[Address], S.StateCode, S.ZipCode
    HAVING 
        SUM(E.GoldStars) >= @GoldStars

    ORDER BY TotalGoldStars DESC;
END