CREATE PROCEDURE PotionShop.CreateItem
    @Name NVARCHAR(100),
    @Price DECIMAL(18, 2),
    @PotionTypeID INT,
    @ItemID INT OUTPUT
AS
BEGIN
    INSERT INTO PotionShop.Item (Name, Price, PotionTypeID)
    VALUES (@Name, @Price, @PotionTypeID);

    SET @ItemID = SCOPE_IDENTITY();
END;