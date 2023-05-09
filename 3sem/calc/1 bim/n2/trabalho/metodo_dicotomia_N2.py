import numpy as np
from funcao_f_N2 import funcao_f_N2

def metodo_dicotomia(alpha,beta,a,b,precisao_desejada):
    
    erro_max = b - a
    numero_iteracoes = 0

    while erro_max > precisao_desejada:       

        fa = funcao_f_N2(alpha,beta,a)

        funcao = funcao_f_N2(alpha, beta, (a + b)/2)
        if funcao == 0:
            break
        elif np.sign(funcao) == np.sign(fa) :
            a = (a + b)/2 
        else:
            b = (a + b)/2
        erro_max = (b - a)/2
        numero_iteracoes += 1

    estimativa_final = (a + b)/2

    print('Número de iterações: ', numero_iteracoes)
    return estimativa_final
