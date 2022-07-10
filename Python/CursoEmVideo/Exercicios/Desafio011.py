#Faça um programa que leia a largura e a altura de uma parede e depois calcule
# sua area e a quantidade de tinta nescessaria para pinta-la
#Cada litro de tinta pinta 2mquadrados

a = float(input('Qual a altura da parede? '))
l = float(input('Qual a largura da parede? '))

mq  = a*l
litroDeTinta = mq/2

print('A parede tem {:.2f} m², e será preciso de {:.3f} litros de tinta'.format(mq, litroDeTinta))