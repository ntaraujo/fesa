#Importação das bibliotecas de interesse:
import numpy as np
import matplotlib.pyplot as plt
from funcao_f_N2 import funcao_f_N2

beta = 0
alpha = 8

x_min = -2
x_max = 2

numero_de_pontos = 600

x = np.linspace(x_min,x_max,numero_de_pontos)

y = funcao_f_N2(alpha,beta,x)

y_max = 4
y_min = -4

dpi = 300

def gera_figura_N2():
    fig, ax = plt.subplots()
    fig.set_size_inches(3, 2)
    fig.set_dpi(dpi)

    ax.plot(x, y)
    ax.axis([x_min, x_max, y_min, y_max])
    plt.xticks([-3,-2,-1,0,1,2,3],["",-2,-1,0,1,2,""])
    ax.grid()

    plt.xlabel(r'$x$')
    plt.ylabel(r'$f(x)$')

    plt.savefig('grafico_N2.pdf', format='pdf', dpi=dpi)
    plt.show()

if __name__ == '__main__':
    gera_figura_N2()
