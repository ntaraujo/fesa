import numpy as np
import matplotlib.pyplot as plt
from funcao_f import funcao_f
beta = 0
alpha = 8
x_min = 0
x_max = 1
numero_de_pontos = 600
x = np.linspace(x_min,x_max,numero_de_pontos)
y = funcao_f(alpha,beta,x)
y_max = -1
y_min = 1
fig, ax = plt.subplots()
fig.set_size_inches(3, 2)
ax.plot(x, y)
ax.axis([x_min, x_max, y_min, y_max])
plt.xlabel(r'$x$')
plt.ylabel(r'$f(x)$')
plt.show()
