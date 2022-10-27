-- Nathan Araújo Euzébia Rocha - 081220008
-- Evandro Ijanques Júnior - 081220030

use Atividade_N1_2BIM

--questão 1

alter table atendimento
 add constraint fk_codPaciente
 foreign key(codPaciente)
 references paciente
 
 alter table atendimento 
 add constraint fk_crm
 foreign key (crm)
 references medico

alter table examesdoatendimento
add constraint fk_codexame
foreign key (codexame)
references exame

alter table examesdoatendimento
add constraint fk_codatendimento
foreign key (codatendimento)
references atendimento
 
 
 alter table atendimento 
 add constraint fk2_codconvenio
 foreign key (codConvenio)
 references convenio

 alter table paciente
 add constraint fk_codConvenio
 foreign key (codConvenio)
 references convenio

 
 --questão 2

 select nome, datanasc from paciente order by DataNasc
-- nome                                               datanasc
-------------------------------------------------- -----------------------
--JOANA PRADO                                        1960-10-10 00:00:00
--MARCOS CARLOS OLIVEIRA                             1970-03-10 00:00:00
--RICARDO GOMES DA COSTA                             1980-10-22 00:00:00
--RICHELLE PEREIRA                                   1983-10-26 00:00:00
--FLAVIO DOS SANTOS                                  1998-05-14 00:00:00
--------------------------------------------------------------------------
 --questão 3

 select * from examesdoatendimento where MONTH(datarealizacao) = 5 and day(datarealizacao) between 9 and 21
-- CodAtendimento CodExame    DataRealizacao
-------------- ----------- -----------------------
--1              3           2013-05-16 00:00:00
--1              4           2013-05-19 00:00:00
--1              7           2013-05-21 00:00:00
--2              3           2013-05-16 00:00:00
--2              4           2013-05-09 00:00:00
--2              10          2013-05-13 00:00:00
--3              1           2013-05-17 00:00:00
--3              4           2013-05-13 00:00:00
--------------------------------------------------

 --questão 4

 select * from convenio where Descricao like '%me%'

-- CodConvenio Descricao                                          ValorMaxExame
----------- -------------------------------------------------- ---------------------------------------
--2           UNIMED                                             38.0000
------------------------------------------------------------------------------------------------------

 --questão 5

 select * from exame where Valor between 32 and 45
-- CodExame    Descricao                                          Valor
----------- -------------------------------------------------- ---------------------------------------
--2           ECG                                                40
--7           HEMOGRAMA COMPLETO                                 44
------------------------------------------------------------------------------------------------------
 --questão 6

 select * from atendimento where CodAtendimento in (3, 5, 7)
-- CodAtendimento dataAtendimento         codPaciente CRM         codConvenio ValorTotal
-------------- ----------------------- ----------- ----------- ----------- ---------------------------------------
--3              2013-04-10 00:00:00     3           1           2           320.9400
-------------- ----------------------- ----------- ----------- ----------- ---------------------------------------

--questão 7

select dataAtendimento, CRM from atendimento where crm != 3 and codConvenio = 2 order by crm asc
--dataAtendimento         CRM
----------------------- -----------
--2013-04-10 00:00:00     1
----------------------- -----------

--questão 8

select dataatendimento, codatendimento, nome 
from atendimento, paciente 
where atendimento.codPaciente = paciente.CodPaciente
--dataatendimento         codatendimento nome
----------------------- -------------- --------------------------------------------------
--2013-05-06 00:00:00     1              FLAVIO DOS SANTOS
--2013-05-10 00:00:00     2              MARCOS CARLOS OLIVEIRA
--2013-04-10 00:00:00     3              JOANA PRADO
----------------------- -------------- --------------------------------------------------

--questão 9

select DataRealizacao, codPaciente, Descricao 
from examesdoatendimento ea, exame e, atendimento a
where ea.CodExame = e.CodExame and ea.CodAtendimento = a.CodAtendimento

--DataRealizacao          codPaciente Descricao
----------------------- ----------- --------------------------------------------------
--2013-05-16 00:00:00     1           ECCG
--2013-05-19 00:00:00     1           URINA 1
--2013-05-21 00:00:00     1           HEMOGRAMA COMPLETO
--2013-05-16 00:00:00     2           ECCG
--2013-05-09 00:00:00     2           URINA 1
--2013-05-13 00:00:00     2           RESSONANCIA MAGNETICA
--2013-05-17 00:00:00     3           RAIO X
--2013-05-13 00:00:00     3           URINA 1
--2013-05-07 00:00:00     3           ESCARRO
----------------------- ----------- --------------------------------------------------

--questão 10 

insert into paciente(CodPaciente, nome, datanasc, DataCadastro, CodConvenio)
values(6, 'Nathan Ijanques Neto', '2030-04-01 21:30:00', '2030-04-08 08:30:00', 2)

insert into atendimento (CodAtendimento, dataAtendimento, codPaciente, crm, codConvenio, ValorTotal) 
values(4, '2040-04-01 21:30:00', 6, 1, 2, '44.0000')

insert into examesdoatendimento(CodAtendimento, CodExame, DataRealizacao) values(4, 1, '2040-04-01 00:30:00')


insert into examesdoatendimento(CodAtendimento, CodExame, DataRealizacao) values(4, 2, '2040-05-01 02:30:00')
