/*
Usando ao banco de dados de locadora faça:
1) Crie uma view chamada vw_nuncaLocados, que exiba
o nome, codigo dos filmes e genero que nunca foram alugados

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
*/

use Locadora

--1) Crie uma view chamada vw_nuncaLocados, que exiba
--o nome e codigo dos filmes que nunca foram alugados
create view vw_nuncaLocados as
	select m.CodMidia, m.DescMidia, m.codGenero
	from Midias m
	left join ItensLocacao itl on m.CodMidia = itl.CodMidia
	where itl.CodLocacao is null

--2) Crie uma view chamada vw_ClienteSemLocacao, que exiba
--o nome e codigo dos clientes que nunca fizeram uma locação
create view vw_ClienteSemLocacao as
	select c.Cliente, c.CodCli
	from Locacao L
	right join Cliente c on c.CodCli = L.CodCli
	where L.CodLocacao is null

--3) Crie uma view chamada vw_Top5, que exiba
--o nome e codigo dos 5 filmes mais alugados
create view vw_Top5 as
	select top 5 m.DescMidia, m.CodMidia
	from midias m
	inner join ItensLocacao itl on itl.CodMidia = m.CodMidia
	group by m.DescMidia, m.CodMidia
	order by count(*) desc

--4) Crie uma view chamada vw_LocacaoTOP, que exiba o 
--nome dos clientes de maneira distinta que fizeram locações
--de algum dos filmes Top5 (use a view do ex_3)
create view vw_LocacaoTOP as
	select distinct c.Cliente
	from vw_Top5 a
	inner join ItensLocacao itl on itl.CodMidia = a.CodMidia
	inner join Locacao L on L.CodLocacao = itl.CodLocacao
	inner join Cliente c on c.CodCli = L.CodCli

--5) Crie uma view chamada vw_genero, que exiba o 
--codigo e descrição do genero de todos os filmes que nunca
--foram locados (use view do ex_1)	
create view vw_genero as
select distinct g.Codgenero, g.descricao
from vw_nuncaLocados a
inner join Genero g on g.Codgenero = a.codGenero

--6) Cria uma view chamada vw_ClienteTOP, que exiba
--os 5 nomes de clientes com codigo, que fizeram o maior
--numero de locações
create view vw_ClienteTOP as
	select top 5 c.Cliente
	from Locacao L 
	inner join Cliente C on c.CodCli = L.CodCli
	group by c.Cliente
	order by count(*) desc


USE locadora;
SELECT * FROM sys.tables;

USE locadora;
SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'nomedatabela';

