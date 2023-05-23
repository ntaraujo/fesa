#Importação das bibliotecas de interesse:
import numpy as np
import math

def funcao_f(x):    
    #ATENÇÃO! NÃO HÁ NECESSIDADE DE ALTERAR ESTA FUNÇÃO.
    
    #Entrada: o valor de x onde queremos avaliar o valor de f(x) = x - cos(x)
    
    #Saída: o valor de f(x) = x - cos(x)    
    f = x - np.cos(x)
    return f

def funcao_f_linha(x):
    #Entrada: o valor de x onde queremos avaliar o valor de f'(x)
    
    #Saída: o valor de f'(x)
    return f_linha

def metodo_newton_raphson(x0,delta1,delta2):

    return estimativa
    




#########################################################################

#Script Principal:

#Estimativa Inicial:
x0 = 
#Definição das precisões desejadas delta1 e delta2:
delta1 = 1e-9
delta2 = 1e-9
#Cálculo da estimativa usando a função "metodo_newton_raphson" (que vocês devem
#completar)
estimativa = metodo_newton_raphson(x0,delta1,delta2)
#Impressão da estimativa final na tela:
print('Estimativa final: ',estimativa)
