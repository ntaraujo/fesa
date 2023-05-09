import math

def script_serie_maclaurin(precisao_desejada, x):
 
    precisao_desejada_alcancada = False
    k = 1
    f = 0

    while not precisao_desejada_alcancada:

        termo = math.pow(-1,k-1) * math.pow(x,2*k-1) / math.factorial(2*k-1)
        f += termo
        resto = abs(termo * math.pow(x,2))
        k += 1
       
        if (resto <= precisao_desejada):
            precisao_desejada_alcancada = True

    return f