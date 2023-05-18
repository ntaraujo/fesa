-- Criar as tabelas que serão usadas

ALTER TABLE Origem ADD Processado BIT DEFAULT 0;
UPDATE Origem SET Processado = 0;

DROP TABLE Recebimento
DROP TABLE UnidadeGestora
DROP TABLE Orgao
DROP TABLE OrgaoSuperior
DROP TABLE Localizacao
DROP TABLE Favorecido


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
