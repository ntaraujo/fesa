import math

def f(x):
    return x**9 + math.sin(x) - 0.1

def f_linha(x):
    return 9*x**8 + math.cos(x)

def metodo_Newton_Raphson(x0, delta1, delta2, alpha, beta):
    x = x0
    iteracoes = 0
    while True:
        iteracoes += 1
        fx = f(x)
        if abs(fx) < delta1:
            return x, iteracoes
        f_linhax = f_linha(x)
        if abs(f_linhax) < delta2:
            return x, iteracoes
        x = x - fx/f_linhax