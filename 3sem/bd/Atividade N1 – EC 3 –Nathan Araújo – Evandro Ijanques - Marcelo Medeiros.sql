-- Nathan Araújo Euzébia Rocha 081220008
-- Evandro Ijanques Junior 081220030
-- Marcelo Mendonça Medeiros 082220035


-- 1a
create or alter view vw_VendasProdutos as 
select v.codVenda, v.codCliente, c.nome, v.dtEntrega, (p.preco * iv.quantidade) as valorTotal from Venda v
inner join Cliente c on v.codCliente = c.codCliente
inner join ItensVenda iv on iv.codVenda = v.codVenda
inner join Produto p on iv.codProduto = p.codProduto

select * from vw_VendasProdutos

-- 1b
create or alter view vw_Categoria as
select c.codCategoria, c.descricao, sum(iv.quantidade) as qtdVendida from Categoria c
inner join Produto p on c.codCategoria = p.codCategoria
inner join ItensVenda iv on p.codProduto = iv.codProduto
group by c.codCategoria, c.descricao

select * from vw_Categoria


-- 2a
create or alter procedure sp_ValorPagarCliente as
begin
	select nome, sum(valorTotal) as valorTotal from vw_VendasProdutos
	group by nome
end

exec sp_ValorPagarCliente



-- 2b
create or alter procedure sp_ProdutosEncalhados(@Qtd int output) as
begin
	select @Qtd = count(p.codProduto) from Produto p
	left join ItensVenda iv on p.codProduto = iv.codProduto
	where iv.codProduto is null
end

declare @Qtd int
exec sp_ProdutosEncalhados @Qtd output
print 'A quantidade de produtos encalhados é ' + cast(@Qtd as varchar(15))


-- 3
create or alter procedure sp_RegiaoVenda(@Regiao varchar(30), @Categoria int) as
begin
	select count(v.codVenda) as qtdVendas from ItensVenda iv
	inner join Venda v on iv.codVenda = v.codVenda
	inner join Estado e on v.estadoCompra = e.estado
	inner join Produto p on iv.codProduto = p.codProduto
	where e.regiao = @Regiao and p.codCategoria = @Categoria
end


exec sp_RegiaoVenda 'NR', 1



-- 4
create or alter procedure sp_IncluirVenda(
								@codVenda int,
								@dtVenda smalldatetime,
								@codCliente int,
								@reserva bit,
								@dtEntrega smalldatetime,
								@estadoCompra varchar(2),
								@estadoEntrega varchar(2),
								@codProduto int,
								@quantidade int,
								@preco decimal(10, 2)
								) as
begin
	update Produto
	set qtdEstoque = qtdEstoque - @quantidade
	where codProduto = @codProduto

	if @reserva = 1
	begin
		update Produto
		set qtdReservado = qtdReservado + @quantidade
		where codProduto = @codProduto
	end

	insert into Venda values (
								@codVenda,
								@dtVenda,
								@codCliente,
								@reserva,
								@dtEntrega,
								@estadoCompra,
								@estadoEntrega
								)
	insert into ItensVenda values (
								@codVenda,
								@codProduto,
								@quantidade,
								@preco
								)
end

exec sp_IncluirVenda 6, '1900-01-01', 3, 1, '1900-01-01', 'SP', 'SP', 1, 3, 30000

select * from ItensVenda