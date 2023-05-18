-- Stored procedure para inserir dados nas tabelas normalizadas
CREATE OR ALTER PROCEDURE InserirDados (
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
    @ValorRecebidoString NVARCHAR(16)
)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Inserir dados nas tabelas normalizadas
        IF NOT EXISTS (SELECT * FROM Favorecido WHERE CodigoFavorecido = @CodigoFavorecido)
            INSERT INTO Favorecido (CodigoFavorecido, NomeFavorecido) VALUES (@CodigoFavorecido, @NomeFavorecido);
        
        IF NOT EXISTS (SELECT * FROM Localizacao WHERE SiglaUF = @SiglaUF)
            INSERT INTO Localizacao (SiglaUF, NomeMunicipio) VALUES (@SiglaUF, @NomeMunicipio);
        
        IF NOT EXISTS (SELECT * FROM OrgaoSuperior WHERE CodigoOrgaoSuperior = @CodigoOrgaoSuperior)
            INSERT INTO OrgaoSuperior (CodigoOrgaoSuperior, NomeOrgaoSuperior) VALUES (@CodigoOrgaoSuperior, @NomeOrgaoSuperior);
        
        IF NOT EXISTS (SELECT * FROM Orgao WHERE CodigoOrgao = @CodigoOrgao)
            INSERT INTO Orgao (CodigoOrgao, NomeOrgao) VALUES (@CodigoOrgao, @NomeOrgao);
        
        IF NOT EXISTS (SELECT * FROM UnidadeGestora WHERE CodigoUnidadeGestora = @CodigoUnidadeGestora)
            INSERT INTO UnidadeGestora (CodigoUnidadeGestora, NomeUnidadeGestora) VALUES (@CodigoUnidadeGestora, @NomeUnidadeGestora);
        
        DECLARE @DataLancamento DATE = dbo.StringParaData(@DataLancamentoString);
        DECLARE @ValorRecebido DECIMAL(15,2) = dbo.StringParaDecimal(@ValorRecebidoString);
        
        INSERT INTO Recebimento (
            CodigoFavorecido,
            SiglaUF,
            CodigoOrgaoSuperior,
            CodigoOrgao,
            CodigoUnidadeGestora,
            DataLancamento,
            ValorRecebido
         ) VALUES (
             @CodigoFavorecido,
             @SiglaUF,
             @CodigoOrgaoSuperior,
             @CodigoOrgao,
             @CodigoUnidadeGestora,
             @DataLancamento,
             @ValorRecebido
         );

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
