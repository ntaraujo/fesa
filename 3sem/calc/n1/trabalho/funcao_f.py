def funcao_f(alpha,beta,x):
    #Entradas: 
    #          alpha: último algarismo do seu RA (necessário para 
    #                 o cálculo de f(x))
    #          beta: penúltimo algarismo do seu RA (necessário para 
    #                 o cálculo de f(x))        
    #x: valor de x para o qual desejamos obter o valor de f(x)
    
    #Calculo da função f(x) = x^3 - exp(-x^2)    
    f = 0.1*(x**3-(beta+7)*x+0.5*(alpha+1))
    #Retorna o valor da função f para o valor de x recebido na entrada
    return f

