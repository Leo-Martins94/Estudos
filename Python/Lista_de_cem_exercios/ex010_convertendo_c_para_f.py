#Faça um Programa que peça a temperatura em graus Celsius, transforme e mostre em graus Fahrenheit.

c = float(input('Diga a temperatura em Celsios: '))

f = (c * 9/5) + 32

print('{}°Celsius equivalem a {}°Fahrenheit'.format(c, f))