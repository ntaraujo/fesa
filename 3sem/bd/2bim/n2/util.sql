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

SELECT
    f.CodigoFavorecido,
    f.NomeFavorecido,
    SUM(r.ValorRecebido) as ValorTotalRecebido,
    COUNT(r.Id) as TotalRecebimentos
INTO #Temp
FROM Recebimento r, Favorecido f
WHERE r.CodigoFavorecido = f.CodigoFavorecido
GROUP BY f.CodigoFavorecido, f.NomeFavorecido
ORDER BY ValorTotalRecebido DESC

SELECT COUNT(*) FROM #Temp

SELECT COUNT(*) FROM ResumoFavorecido

SELECT *, ValorTotalRecebido / TotalRecebimentos as ValorMedio
FROM ResumoFavorecido ORDER BY TotalRecebimentos DESC, ValorMedio DESC