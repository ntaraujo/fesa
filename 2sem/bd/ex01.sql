/* Utilizando o arquivo de criação de banco de dados "Cria Banco Locadora", ou usando
esse mesmo banco caso já exista, resolva os seguintes requisitos:
1-Liste todos os clientes que possuem seu código entre 4 e 7
2-Resolva o item 1 de uma maneira diferente
3-Liste todos os clientes que começam com a letra 'a' ou terminam com a letra 'z'
4-Liste todas as midias que tenham os seguintes valores de locação: 6,90 ou 2,40 ou 3,75
5-Resolva o exercicio anterior de alguma outra forma
6-Liste distintamente os codigos dos clientes que fizeram alguma locação
7-Liste distintamente os codigos de midias que foram locadas
8-Liste as midias em ordem decrescente de valor de locação
9-Liste as 4 midias mais caras
10-Liste as 10 midias mais baratas
11-Liste os itens de locação em ordem de locacao e midia
*/

use locadora

select * from cliente

-- 1
select * from cliente where codcli between 4 and 7

-- 2
select * from cliente where codcli >= 4 and codcli <= 7

-- 3
select * from cliente where cliente like 'a%' or cliente like '%z'

-- 4
select * from midias where valorunit in (6.90, 2.40, 3.75)

-- 5
select * from midias where valorunit = 6.90 or valorunit = 2.40 or valorunit = 3.75

-- 6
select distinct c.codcli from locacao l, cliente c where l.codcli = c.codcli

-- 7
select distinct m.codmidia from midias m, itenslocacao i where m.codmidia = i.codmidia

-- 8
select * from midias order by valorunit desc

-- 9
select top 4 * from midias order by valorunit desc

-- 10
select top 10 * from midias order by valorunit asc

-- 11
select * from itenslocacao order by codlocacao, codmidia