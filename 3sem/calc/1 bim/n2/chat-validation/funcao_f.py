import numpy as np
from script_serie_maclaurin import script_serie_maclaurin
def funcao_f(alpha,beta,x):
    f = np.power(x,beta+1) + np.vectorize(script_serie_maclaurin)(np.full_like(x, 1e-9), x) - (alpha+1)/10 
    return f