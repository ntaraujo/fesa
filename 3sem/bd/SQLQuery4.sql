

create or alter procedure SP_insere_Func(
	@func_id int,
	@func_nome varchar(50),
	@gerente_id int,
	@setor_id int,
	@func_salario decimal(10,2),
	@func_dataNasc smalldatetime
) as begin
	if not exists (select setor_id from setores where setor_id = @setor_id) begin
		print 'Setor informado inexistente'
		return -1
	end
end