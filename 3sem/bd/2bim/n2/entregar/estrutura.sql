-- Fake de como o Origem é criado, visto que é feito no Azure por meio do DataFactory, conforme vídeo explicativo:
CREATE TABLE Origem (
    [Código Favorecido] NVARCHAR(MAX),
    [Nome Favorecido] NVARCHAR(MAX),
    [Sigla UF] NVARCHAR(MAX),
    [Nome Município] NVARCHAR(MAX),
    [Código Órgão Superior] NVARCHAR(MAX),
    [Nome Órgão Superior] NVARCHAR(MAX),
    [Código Órgão] NVARCHAR(MAX),
    [Nome Órgão] NVARCHAR(MAX),
    [Código Unidade Gestora] NVARCHAR(MAX),
    [Nome Unidade Gestora] NVARCHAR(MAX),
    [Ano e mês do lançamento] NVARCHAR(MAX),
    [Valor Recebido] NVARCHAR(MAX)
);

-- Adiciona uma coluna à tabela Origem para indicar se o registro já foi processado
ALTER TABLE Origem ADD Processado BIT DEFAULT 0;
UPDATE Origem SET Processado = 0;

CREATE TABLE Favorecido (
    CodigoFavorecido NVARCHAR(14) PRIMARY KEY,
    NomeFavorecido NVARCHAR(100)
);

CREATE TABLE Localizacao (
    SiglaUF NVARCHAR(2) PRIMARY KEY,
    NomeMunicipio NVARCHAR(32)
);

CREATE TABLE OrgaoSuperior (
    CodigoOrgaoSuperior NVARCHAR(5) PRIMARY KEY,
    NomeOrgaoSuperior NVARCHAR(45)
);

CREATE TABLE Orgao (
    CodigoOrgao NVARCHAR(5) PRIMARY KEY,
    NomeOrgao NVARCHAR(92)
);

CREATE TABLE UnidadeGestora (
    CodigoUnidadeGestora NVARCHAR(6) PRIMARY KEY,
    NomeUnidadeGestora NVARCHAR(45)
);

CREATE TABLE Recebimento (
    Id INT IDENTITY PRIMARY KEY,
    CodigoFavorecido NVARCHAR(14) FOREIGN KEY REFERENCES Favorecido(CodigoFavorecido),
    SiglaUF NVARCHAR(2) FOREIGN KEY REFERENCES Localizacao(SiglaUF),
    CodigoOrgaoSuperior NVARCHAR(5) FOREIGN KEY REFERENCES OrgaoSuperior(CodigoOrgaoSuperior),
    CodigoOrgao NVARCHAR(5) FOREIGN KEY REFERENCES Orgao(CodigoOrgao),
    CodigoUnidadeGestora NVARCHAR(6) FOREIGN KEY REFERENCES UnidadeGestora(CodigoUnidadeGestora),
    DataLancamento DATE,
    ValorRecebido DECIMAL(15,2),
    Processado BIT DEFAULT 0
);

CREATE TABLE ResumoFavorecido (
    CodigoFavorecido NVARCHAR(14) PRIMARY KEY,
    ValorTotalRecebido DECIMAL(15,2),
    NomeFavorecido NVARCHAR(100),
    TotalRecebimentos INT
);

-- Função para converter string em data
CREATE OR ALTER FUNCTION StringParaData (@dataString NVARCHAR(10))
RETURNS DATE
AS
BEGIN
    DECLARE @data DATE;
    SET @data = CONVERT(DATE, '01/' + @dataString, 103);
    RETURN @data;
END;

-- Função para converter string em decimal
CREATE OR ALTER FUNCTION StringParaDecimal (@valorString NVARCHAR(20))
RETURNS DECIMAL(15,2)
AS
BEGIN
    DECLARE @valor DECIMAL(15,2);
    SET @valor = CONVERT(DECIMAL(15,2), REPLACE(@valorString, ',', '.'));
    RETURN @valor;
END;

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
