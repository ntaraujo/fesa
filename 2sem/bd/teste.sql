create database google

create table cidade (
	codCidade int primary key,
	descricao varchar(100) not null,
	populacao int default -1
)

create table cliente (
	codCliente int not null,
	nome varchar(100),
	codCidade int foreign key
		references cidade,
	primary key (codCliente)
)