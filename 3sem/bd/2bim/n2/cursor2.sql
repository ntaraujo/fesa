-- Cursor 2: Inserir dados na tabela de resumo

-- Limpar e começar
UPDATE Recebimento SET Processado = 0;
DROP TABLE ResumoFavorecido

CREATE TABLE ResumoFavorecido (
    CodigoFavorecido NVARCHAR(14) PRIMARY KEY,
    ValorTotalRecebido DECIMAL(15,2),
    NomeFavorecido NVARCHAR(100),
    TotalRecebimentos INT
);

-- Tabela temporária
SELECT
    f.CodigoFavorecido,
    f.NomeFavorecido,
    SUM(r.ValorRecebido) as ValorTotalRecebido,
    COUNT(r.Id) as TotalRecebimentos
INTO #Temp
FROM Recebimento r, Favorecido f
WHERE r.CodigoFavorecido = f.CodigoFavorecido
GROUP BY f.CodigoFavorecido, f.NomeFavorecido
ORDER BY ValorTotalRecebido DESC

DECLARE resumoCursor CURSOR FOR
SELECT * FROM #Temp

DECLARE 
@CodigoFavorecido NVARCHAR(14),
@NomeFavorecido NVARCHAR(100),
@ValorTotalRecebido DECIMAL(15,2),
@TotalRecebimentos INT;

OPEN resumoCursor;
FETCH NEXT FROM resumoCursor INTO @CodigoFavorecido, @NomeFavorecido, @ValorTotalRecebido, @TotalRecebimentos;

WHILE @@FETCH_STATUS = 0
BEGIN
    INSERT INTO
        ResumoFavorecido (CodigoFavorecido, ValorTotalRecebido, NomeFavorecido, TotalRecebimentos)
        VALUES (@CodigoFavorecido, @ValorTotalRecebido, @NomeFavorecido, @TotalRecebimentos);
    FETCH NEXT FROM resumoCursor INTO @CodigoFavorecido, @NomeFavorecido, @ValorTotalRecebido, @TotalRecebimentos;
END;

CLOSE resumoCursor;
DEALLOCATE resumoCursor;

-- Visualizar resultado
SELECT * from ResumoFavorecido order by ValorTotalRecebido DESC
