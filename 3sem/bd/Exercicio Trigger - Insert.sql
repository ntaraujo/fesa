/*
	Usando o banco de dados de Com�rcio fa�a:
	1) Uma trigger de inclus�o para a tabela de notaFiscal
	que n�o permita a inclus�o de uma nota com a data de emiss�o
	menor que a data do sistema operacional

	2) Uma trigger de inclus�o na tabela de itensNotaFiscal
	que possua a quantidade negativa. Junto a essa trigger
	fa�a uma verifica��o se o valor informado � igual ao
	valor do produto que est� sendo inserido vezes a quantidade
	de itens inseridos

	3) Crie uma trigger para exclus�o de registro na tabela
	de notaFiscal, para que toda vez que uma nota fiscal
	for excluida o sistema dever� automaticamente excluir
	todos os itens que existem para essa nota na tabela
	de itensNotaFiscal
*/

SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_CATALOG = 'Comercio'
ORDER BY TABLE_NAME, ORDINAL_POSITION

--1)
CREATE OR ALTER TRIGGER tr_notaFiscal_insert
ON notaFiscal
FOR INSERT
AS
BEGIN
    DECLARE @now DATETIME
    SET @now = GETDATE()
    
    IF EXISTS (SELECT * FROM inserted WHERE dataEmissao < @now)
    BEGIN
        RAISERROR('A data de emiss�o da nota n�o pode ser menor que a data atual.', 16, 1)
        ROLLBACK TRANSACTION
    END
END

select * from notaFiscal

INSERT INTO notaFiscal (nrNota, dataEmissao, destinatario) VALUES (1, '2022-01-01', 'Cliente A')
INSERT INTO notaFiscal (nrNota, dataEmissao, destinatario) VALUES (2, GETDATE()+1, 'Cliente B')

-- 2)
CREATE OR ALTER TRIGGER tr_itensNotaFiscal_insert
ON itensNotaFiscal
FOR INSERT
AS
BEGIN
    DECLARE @codProduto INT, @quantidade INT, @valor DECIMAL(18, 2), @valorCalculado DECIMAL(18, 2)
    
    SELECT @codProduto = codProduto, @quantidade = quantidade, @valor = valor FROM inserted
    
    IF @quantidade < 0
    BEGIN
        RAISERROR('A quantidade n�o pode ser negativa.', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    
    SELECT @valorCalculado = preco * @quantidade FROM produto WHERE codProduto = @codProduto
    
    IF @valor != @valorCalculado
    BEGIN
        RAISERROR('O valor informado � diferente do valor calculado.', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
END

select * from itensNotaFiscal

INSERT INTO itensNotaFiscal (nrNota, codProduto, quantidade, valor) VALUES (2, 1, -1, 10.00)
INSERT INTO itensNotaFiscal (nrNota, codProduto, quantidade, valor) VALUES (2, 2, 2, 5.00)
INSERT INTO itensNotaFiscal (nrNota, codProduto, quantidade, valor) VALUES (2, 1, 10, 38.8)

-- 3)
CREATE OR ALTER TRIGGER tr_notaFiscal_delete
ON notaFiscal
INSTEAD OF DELETE
AS
BEGIN
    DELETE FROM itensNotaFiscal
    WHERE nrNota IN (SELECT nrNota FROM deleted)
    
    DELETE FROM notaFiscal
    WHERE nrNota IN (SELECT nrNota FROM deleted)
END

select * from notaFiscal
select * from itensNotaFiscal

DELETE FROM notaFiscal WHERE nrNota = 2

-- 4) 