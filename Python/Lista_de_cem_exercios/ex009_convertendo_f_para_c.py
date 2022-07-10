#Faça um Programa que peça a temperatura em graus Fahrenheit, transforme e mostre a temperatura em graus Celsius.
#C = 5 * ((F-32) / 9).

f = float(input('digite a temperatura em Fahrenheit: '))

c = 5 * ((f-32) / 9)

print('{}° Fahrenheit equivalem a {}° Celcius'.format(f, c))