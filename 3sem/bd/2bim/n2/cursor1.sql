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

-- Checar se todos os dados foram inseridos
SELECT TOP 1 * FROM Origem WHERE Processado = 0;
