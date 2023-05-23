# Gambiarras
import sys
this_dir = sys.path[0]
import matplotlib
matplotlib.use('tkagg')

#Importação das bibliotecas de interesse:
import numpy as np
import math
import matplotlib.pyplot as plt
from scipy import signal
import os

def funcao_gera_figura(f,s,t,nome):
    #ATENÇÃO! NÃO HÁ NECESSIDADE DE ALTERAR ESTA FUNÇÃO.

    #Entradas:
    #f [numpy array] : função periódica que estamos interessados 
    #em analisar
    #s [numpy array]: expansão em Série de Fourier da função f, pre-
    #viamente calculada
    #t [numpy array]: vetor de tempo
    #nome [string]: nome do arquivo a ser salvo.
    #Importação das bibliotecas de interesse:

    #Resolução da figura:
    dpi = 300
    #Criação da figura, com tamanho e resolução especificados
    fig, ax = plt.subplots()
    fig.set_size_inches(5, 3)
    fig.set_dpi(dpi)

    #Gera os gráficos da função de interesse e da sua aproximação
    #por Série de Fourier:
    plt.plot(t,f,'-b')
    plt.plot(t,s,'-r')
    #Definição dos eixos
    ax.axis([min(t), max(t), -0.5, 1.5])
    #Gera a grade para facilitar a leitura do gráfico
    ax.grid()
    #Nomes de cada eixo:
    plt.xlabel(r'$t[s]$')
    #Salva a imagem em formato pdf.
    plt.savefig(f'{nome}.jpg', format='jpg', dpi=dpi)

def coeficientes_fourier(numero_de_harmonicas):
    #Entrada:
    #numero_de_harmonicas [int]: numero de harmônicas a serem consi-
    #deradas
    #Saída:
    #a_n [numpy array]: vetor de coeficientes a_n (n entre 1 e 
    #numero_de_harmonicas) da expansão em Série de Fourier

    an = np.zeros(numero_de_harmonicas+1)
    an[0] = 0.5

    for n in range(1, numero_de_harmonicas+1):
        an[n] = 0.0 if n % 2 == 0 else (2/(n*np.pi)) * (-1)**((n-1)/2)
    return an

# Script principal:
t = np.linspace(-2, 2, 10000) 

T0 = 2

f0 = 1/T0

f = 0.5*(signal.square(2*np.pi*f0*(t+T0/4))+np.ones_like(t))

a0 = 0.5

vetor_harmonicas = [1,3,5,7,9,11,13,25,50]

for N in vetor_harmonicas:    
    an = coeficientes_fourier(N)
    s = a0 * np.ones_like(t)
    for n in range(1,N+1):
        s += an[n] * np.cos(n*2*np.pi*f0*t)

    nome_figura = os.path.join(this_dir, f"quadrada_{N}_harmonicas")
    funcao_gera_figura(f,s,t,nome_figura)
