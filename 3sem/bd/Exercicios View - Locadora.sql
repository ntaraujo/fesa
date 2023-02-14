/*
Usando ao banco de dados de locadora faça:
1) Crie uma view chamada vw_nuncaLocados, que exiba
o nome e codigo dos filmes que nunca foram alugados


2) Crie uma view chamada vw_ClienteSemLocacao, que exiba
o nome e codigo dos clientes que nunca fizeram uma locação

3) Crie uma view chamada vw_Top5, que exiba
o nome e codigo dos 5 filmes mais alugados

4) Crie uma view chamada vw_LocacaoTOP, que exiba o 
nome dos clientes de maneira distinta que fizeram locações
de algum dos filmes Top5 (use a view do ex_3)

5) Crie uma view chamada vw_genero, que exiba o 
codigo e descrição do genero de todos os filmes que nunca
foram locados (use view do ex_1)

6) Cria uma view chamada vw_ClienteTOP, que exiba
os 5 nomes de clientes com codigo, que fizeram o maior
numero de locações

Responda sabendo que existem 6 tabelas:
* "resumo", com as colunas "codCli" e "valorTotal"
* "genero", com as colunas "codGenero" e "descricao"
* "Locacao", com as colunas "CodLocacao", "CodCli", "DataLoc" e "ValorTotalLoc"
* "Midias", com as colunas "CodMidia", "DescMidia", "ValorUnit", "codGenero" e "quantidade
* "Cliente", com as colunas "CodCli", "Cliente", "EnderecoCli" e "TelCli"
* "ItensLocacao", com as colunas "CodLocacao", "CodMidia" e "DataDev"
*/
use Locadora

CREATE VIEW vw_nuncaLocados AS
SELECT m.CodMidia, m.DescMidia
FROM Midias m
WHERE m.CodMidia NOT IN (SELECT CodMidia FROM ItensLocacao);

CREATE VIEW vw_ClienteSemLocacao AS
SELECT c.CodCli, c.Cliente
FROM Cliente c
WHERE c.CodCli NOT IN (SELECT CodCli FROM Locacao);

CREATE VIEW vw_Top5 AS
SELECT Top 5 Midias.CodMidia, Midias.DescMidia
FROM Midias
INNER JOIN ItensLocacao ON Midias.CodMidia = ItensLocacao.CodMidia
GROUP BY Midias.CodMidia, Midias.DescMidia
ORDER BY COUNT(ItensLocacao.CodMidia) DESC

CREATE VIEW vw_LocacaoTOP AS
SELECT DISTINCT Cliente.Cliente
FROM Cliente
INNER JOIN Locacao ON Cliente.CodCli = Locacao.CodCli
INNER JOIN vw_Top5 ON Locacao.CodMidia = vw_Top5.CodMidia

