-- Cursor 1: Inserir dados nas tabelas normalizadas

DECLARE 
@CodigoFavorecido NVARCHAR(14),
@NomeFavorecido NVARCHAR(100),
@SiglaUF NVARCHAR(2),
@NomeMunicipio NVARCHAR(32),
@CodigoOrgaoSuperior NVARCHAR(5),
@NomeOrgaoSuperior NVARCHAR(45),
@CodigoOrgao NVARCHAR(5),
@NomeOrgao NVARCHAR(92),
@CodigoUnidadeGestora NVARCHAR(6),
@NomeUnidadeGestora NVARCHAR(45),
@DataLancamentoString NVARCHAR(7),
@ValorRecebidoString NVARCHAR(16),
@Processado BIT;

DECLARE recebimentoCursor CURSOR FOR
SELECT * FROM Origem WHERE Processado = 0;

OPEN recebimentoCursor;
FETCH NEXT FROM recebimentoCursor INTO 
@CodigoFavorecido,
@NomeFavorecido,
@SiglaUF,
@NomeMunicipio,
@CodigoOrgaoSuperior,
@NomeOrgaoSuperior,
@CodigoOrgao,
@NomeOrgao,
@CodigoUnidadeGestora,
@NomeUnidadeGestora,
@DataLancamentoString,
@ValorRecebidoString,
@Processado;

WHILE @@FETCH_STATUS = 0
BEGIN
    EXEC InserirDados 
    @CodigoFavorecido,
    @NomeFavorecido,
    @SiglaUF,
    @NomeMunicipio,
    @CodigoOrgaoSuperior,
    @NomeOrgaoSuperior,
    @CodigoOrgao,
    @NomeOrgao,
    @CodigoUnidadeGestora,
    @NomeUnidadeGestora,
    @DataLancamentoString,
    @ValorRecebidoString;
    UPDATE Origem SET Processado = 1 WHERE CURRENT OF recebimentoCursor;
    
    FETCH NEXT FROM recebimentoCursor INTO 
    @CodigoFavorecido,
    @NomeFavorecido,
    @SiglaUF,
    @NomeMunicipio,
    @CodigoOrgaoSuperior,
    @NomeOrgaoSuperior,
    @CodigoOrgao,
    @NomeOrgao,
    @CodigoUnidadeGestora,
    @NomeUnidadeGestora,
    @DataLancamentoString,
    @ValorRecebidoString,
    @Processado;
END;

CLOSE recebimentoCursor;
DEALLOCATE recebimentoCursor;

-- Cursor 2: Inserir dados na tabela de resumo

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
