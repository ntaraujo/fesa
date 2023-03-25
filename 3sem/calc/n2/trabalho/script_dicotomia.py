#Importação da função "metodo_dicotomia" do arquivo de mesmo nome:
from metodo_dicotomia import metodo_dicotomia


#Valor de alpha (último algarismo do seu RA):
alpha = 8

#Valor de beta (penúltimo algarismo do seu RA):
beta = 0

#Extremo inferior do intervalo inicial
a = 0
#Extremo superior do intervalo inicial
b = 1
#Definição da precisão desejada
precisao_desejada = 0.00001
#Cálculo da estimativa usando a função "metodo_dicotomia" (que vocês devem
#completar)
estimativa = metodo_dicotomia(alpha,beta,a,b,precisao_desejada)
#Impressão da estimativa final na tela:
print('Estimativa final c/ precisão',precisao_desejada,':',estimativa)
