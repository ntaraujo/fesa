USE pedidos

SELECT * FROM EX2_PEDIDO

INSERT INTO EX2_PEDIDO VALUES (7, null, '2023/03/02', 00007, 152.11)

-- 1
SELECT
	p.codpedido,
	c.nome
FROM
		EX2_PEDIDO p
	INNER JOIN
		EX2_CLIENTE c
	ON (p.codcliente = c.codcliente)

-- 2
SELECT
	pc.*,
	count(i.numeroitem) AS qtd
FROM
		(
			SELECT
				p.codpedido,
				c.nome
			FROM EX2_PEDIDO p INNER JOIN EX2_CLIENTE c
				ON (p.codcliente = c.codcliente)
		) pc
	INNER JOIN
		EX2_ITEMPEDIDO i
    ON (pc.codpedido = i.codpedido)
GROUP BY
	pc.codpedido, pc.nome

-- 2 v2
SELECT
	p.codpedido,
	c.nome,
	count(i.numeroitem) AS qtd
FROM
			EX2_PEDIDO p
		INNER JOIN
			EX2_CLIENTE c
		ON (p.codcliente = c.codcliente)
	INNER JOIN
		EX2_ITEMPEDIDO i
    ON (p.codpedido = i.codpedido)
GROUP BY
	p.codpedido, c.nome