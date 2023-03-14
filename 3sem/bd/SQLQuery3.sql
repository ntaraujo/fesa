use funcionarios

create or alter procedure SP_exemplo2 (@numSetor int) as
begin
	if @numSetor = -1 begin
		select f.setor_id, sum(f.func_salario) as total
		from funcionarios f
		group by f.setor_id
	end
	else
	begin
		select f.setor_id, sum(f.func_salario) as total
		from funcionarios f
		where f.setor_id = @numSetor
		group by f.setor_id
	end
end

exec SP_exemplo2 -1

create or alter procedure SP_insere_setores (@setor_id int, @setor_nome varchar(50))
as begin
	set nocount on

	insert into setores values (@setor_id, @setor_nome)

	set nocount off

	if @@ERROR != 0 begin
		print 'erro na inclusão de dados'
		return -1
	end
	else
		return 0
end


