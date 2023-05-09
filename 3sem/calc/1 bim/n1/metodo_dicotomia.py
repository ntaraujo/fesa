import numpy as np
def metodo_dicotomia(alpha,beta,a,b,precisao_desejada):
    #Entradas: 
    #          alpha: último algarismo do seu RA (necessário para 
    #                 o cálculo de f(x))
    #          beta: penúltimo algarismo do seu RA (necessário para 
    #                 o cálculo de f(x))    
    #          a: extremo inferior do intervalo inicial
    #          b: extremo superior fo intervalo inicial
    #          precisao_desejada: precisão com que se deseja conhecer a raiz


    #Importação da função "funcao_f":
    from funcao_f import funcao_f
    
    #Calculo do erro maximo considerando o intervalo inicial:
    erro_max = b - a
    #Inicialização do numero de iteracoes:
    numero_iteracoes = 0
    #Enquanto o erro maximo cometido for maior que a precisão desejada, faça:
    while erro_max > precisao_desejada:       
        #Variável fa recebe o valor da função f calculada em a:
        fa = funcao_f(alpha,beta,a)
        #A partir daqui, vocês devem completar
        funcao = funcao_f(alpha, beta, (a+b)/2)
        if funcao == 0:
            break
        elif np.sign(funcao) == np.sign(fa) :
            a = (a+b)/2 
        else:
            b = (a+b)/2
        erro_max = (b - a)/2
        numero_iteracoes += 1
            
    #Calculo da estimativa final
    estimativa_final = (a + b)/2
    #Impressão do número de iterações na tela    
    print('Número de iterações: ', numero_iteracoes)
    #Função retorna o valor da estimativa final:
    return estimativa_final

