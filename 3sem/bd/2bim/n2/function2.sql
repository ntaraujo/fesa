-- Função para converter string em decimal
CREATE OR ALTER FUNCTION StringParaDecimal (@valorString NVARCHAR(20))
RETURNS DECIMAL(15,2)
AS
BEGIN
    DECLARE @valor DECIMAL(15,2);
    SET @valor = CONVERT(DECIMAL(15,2), REPLACE(@valorString, ',', '.'));
    RETURN @valor;
END;
