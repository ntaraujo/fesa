import numpy as np
import math

def funcao_f(x):    
    return x - np.cos(x)

def funcao_f_linha(x):
    return 1 + np.sin(x)

def metodo_newton_raphson(x0,delta1,delta2):
    x = x0
    while True:
        fx = funcao_f(x)
        if abs(fx) < delta1:
            break
        x_anterior = x
        x = x - fx/funcao_f_linha(x)
        if abs(x - x_anterior) < delta2:
            break
    return x

#Script Principal:

#Estimativa Inicial:
x0 = 0.5
#Definição das precisões desejadas delta1 e delta2:
delta1 = 1e-9
delta2 = 1e-9
#Cálculo da estimativa usando a função "metodo_newton_raphson" (que vocês devem
#completar)
estimativa = metodo_newton_raphson(x0,delta1,delta2)
#Impressão da estimativa final na tela:
print('Estimativa final: ', estimativa)
