--criando tabela sem FK e adicionando posteriormente
use EC2_teste
go --executa o comando até aqui

--exclui as tabelas existentes
drop table cliente
drop table cidade
go

--cria as tabelas sem FK
create table cidade (
	codCidade int primary key,
	descricao varchar(100) not null,
	populacao int default -1
)

create table cliente (
	codCliente int not null,
	nome varchar(100),
	codCidade int,
	primary key (codCliente) --chave primaria
)

--criando uma FK, depois que a tabela já existe
alter table cliente
	add constraint FK_cliente_cidade
		foreign key (codCidade) 
		references cidade

------------------------------------------------
--Adicionar um determinado CAMPO

--add campo telefone
alter table cliente
	add telefone varchar(25) default '--SEM TELEFONE--'

--adicionar outro campo
alter table cliente
	add campoTexte decimal(10,2) not null

--para remover um campo
alter table cliente
	drop column campoTexte

--------------------------------

--validando PK

insert into cidade (codCidade, Ddescricao, populacao)
	values (1, 'Mauá', 40000)

insert into cidade
	values (2, 'SBC', 350000)

insert into cidade (codCidade, descricao)
	values (3, 'SCS')

insert into cidade (codCidade, descricao)
	values (3, 'Ribeirão Pires')

create database Nathan_Arauuuuuuu

create table Nathanos
	

