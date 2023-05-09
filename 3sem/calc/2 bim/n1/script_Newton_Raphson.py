#Importação da função "newton_raphson" do arquivo de mesmo nome:
from metodo_Newton_Raphson import metodo_Newton_Raphson
# valores de entrada
alpha = 0 # substituir pelo valor do penúltimo algarismo do seu RA
beta = 8 # substituir pelo valor do último algarismo do seu RA
delta1 = 1e-9
delta2 = 1e-9
x0 = -0.5
estimativa, iteracoes = metodo_Newton_Raphson(x0,delta1,delta2,alpha,beta)
#Impressão da estimativa final na tela:
print("Estimativa final:  {:.10f}".format(estimativa))
print(f"Iterações:  {iteracoes}")
