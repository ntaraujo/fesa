-- Exportar Schema do Banco de Dados
SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_SCHEMA = 'dbo';

-- Checar se tem alguma query em execução
SELECT
    r.session_id,
    r.status,
    r.start_time,
    r.command,
    r.database_id,
    r.blocking_session_id,
    t.text AS [query_text],
    qp.query_plan AS [query_plan]
FROM
    sys.dm_exec_requests AS r
CROSS APPLY
    sys.dm_exec_sql_text(r.sql_handle) AS t
CROSS APPLY
    sys.dm_exec_query_plan(r.plan_handle) AS qp