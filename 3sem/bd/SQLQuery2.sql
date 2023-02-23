declare @salario decimal(10,3)
declare @media decimal(10,2)
declare @idade int = 18

use funcionarios

set @salario = 3400.875

set @salario = (select sum(func_salario) from funcionarios)

select @salario = sum(func_salario), @media = avg(func_salario) from funcionarios

select @salario, @media

select * from funcionarios