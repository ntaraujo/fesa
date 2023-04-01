#Importação da função "metodo_dicotomia_N2" do arquivo de mesmo nome:
from metodo_dicotomia_N2 import metodo_dicotomia_N2


#Valor de alpha (último algarismo do seu RA):
alpha = 9

#Valor de beta (penúltimo algarismo do seu RA):
beta = 9

#Extremo inferior do intervalo inicial
a = 0
#Extremo superior do intervalo inicial
b = 1
#Definição da precisão desejada
precisao_desejada = 0.0001
#Cálculo da estimativa usando a função "metodo_dicotomia" (que vocês devem
#completar)
estimativa = metodo_dicotomia(alpha,beta,a,b,precisao_desejada)
#Impressão da estimativa final na tela:
print('Estimativa final c/ precisão',precisao_desejada,':',estimativa)
