#Crie um algoritimo que leia um número e mostre seu dobro
#triplo e raiz quadrada

n = float(input('Digite um numero: '))

d = n*2
t = n*3
r = n**(1/2)

print('o numero digitado foi {}, seu dobro é {}, seu triplo é {}, e sua raiz quadrada é {}'.format(n, d, t, r))