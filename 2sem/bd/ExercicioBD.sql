drop database ExercicioDB

create database ExercicioDB

create table Aluno (
	RM int primary key,
	Nome varchar(60),
	Estado varchar(2),
	Nascimento date
	)

insert into Aluno (RM, Nome, Estado, Nascimento)
	values	(5001,'Asdronio da Silva','SP','12/24/1961'),
			(5002,'Severino Severá SeVou','MG','07/08/1967'),
			(5003,'Juvenal Juvênio','MG','05/21/1975'),
			(5004,'Ambrósio Adelino Xavier','PA','02/17/1949'),
			(5005,'Adelino da Silva Sauro','RJ','06/30/1985'),
			(5006,'Adamastor Augusto','SP','09/21/1974'),
			(5007,'Chapecó Iramir  da Silva','RJ','07/07/1947'),
			(5008,'Carlitos Tevez ','BU','11/06/1985'),
			(5009,'Silvio Santos','SP','12/11/1935')

-- 1
select RM, Nome from Aluno where Nome like 'A%'

-- 2
select * from Aluno where year(Nascimento) = 1985

-- 3
select Nome, Nascimento from Aluno where year(Nascimento) < 1950

-- 4
select * from Aluno where month(Nascimento) = 7 order by Nome

-- 5
select Nome, Nascimento from Aluno where day(Nascimento) < 20 and year(Nascimento) < 1985

-- 6
select * from Aluno order by Nascimento desc

-- 7
select Nome, year(Nascimento) "Ano" from Aluno order by Ano desc

-- 8
select Nome, day(Nascimento) "Dia", month(Nascimento) "Mês", year(Nascimento) "Ano" from Aluno

-- 9
update Aluno set Nome = 'Adrônio da Silva Silveira' where RM = 5001

-- 10
update Aluno set Nome = 'Severino Seviu Denovo', Nascimento = '08/08/1967' where RM = 5002

-- 11
update Aluno set Estado = 'PE' where Estado = 'RJ'

-- 12
update Aluno set Nome = Nome + ' Santos' where Nome like '%Silva%'

-- 13
delete from Aluno where RM = 5006

-- 14
delete from Aluno where year(Nascimento) < 1970

-- 15
delete from Aluno where RM != 5008

-- 16
delete from Aluno where Nome like '%Carlitos%'

select * from Aluno