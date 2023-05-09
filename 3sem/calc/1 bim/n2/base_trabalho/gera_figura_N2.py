#Importação das bibliotecas de interesse:
import numpy as np
import matplotlib.pyplot as plt
#Importação da função "funcao_f_N2" definida no arquivo de mesmo nome:
from funcao_f_N2 import funcao_f_N2


beta = 10
alpha = 0

#Extremo inferior do intervalo onde vamos olhar para o gráfico da função f
x_min = -3
#Extremo superior do intervalo onde vamos olhar para o gráfico da função f
x_max = 3
#Número de pontos intermediários usados ´p/ gerar o gráfico
numero_de_pontos = 600

#Geração de um vetor x com elementos linearmente espaçados entre x_min e x_max
#com número de elementos igual ao valor da variável numero_de_pntos
x = np.linspace(x_min,x_max,numero_de_pontos)

#Cálculo do valor da função f para cada elemento do vetor x:
y = funcao_f_N2(alpha,beta,x)


#Valores máximos e mínimos do vetor y (serão usados para definir os eixos
#da figura)
y_max = 2
y_min = -2

#Resolução da figura:
dpi = 300
#Criação da figura, com tamanho e resolução especificados
fig, ax = plt.subplots()
fig.set_size_inches(3, 2)
fig.set_dpi(dpi)

#Gera o gráfico, com o vetor x no eixo x e o vetor y no eixo y
ax.plot(x, y)
#Definição dos eixos
ax.axis([x_min, x_max, y_min, y_max])
#Gera a grade para facilitar a leitura do gráfico
plt.xticks([-3,-2,-1,0,1,2,3],["",-2,-1,0,1,2,""])
ax.grid()
#Nomes de cada eixo:
plt.xlabel(r'$x$')
plt.ylabel(r'$f(x)$')
#Mostra a figura na tela e salva a imagem em formato pdf.
plt.show()
plt.savefig('grafico_N2.pdf', format='pdf', dpi=dpi)
