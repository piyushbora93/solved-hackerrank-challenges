DECLARE @currentCount INT
DECLARE @table TABLE (PrimeNumber INT)
SET @currentCount = 2

WHILE (@currentCount <= 1000)
BEGIN
    IF NOT EXISTS (SELECT PrimeNumber FROM @table WHERE @currentCount % PrimeNumber = 0)        
    BEGIN
       INSERT INTO @table (PrimeNumber) VALUES (@currentCount)       
    END    
    SET @currentCount = @currentCount + 1
END

SELECT STRING_AGG(PrimeNumber, '&') AS PrimeNumbers FROM @table
