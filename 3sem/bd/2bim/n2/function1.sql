-- Função para converter string em data
CREATE OR ALTER FUNCTION StringParaData (@dataString NVARCHAR(10))
RETURNS DATE
AS
BEGIN
    DECLARE @data DATE;
    SET @data = CONVERT(DATE, '01/' + @dataString, 103);
    RETURN @data;
END;
