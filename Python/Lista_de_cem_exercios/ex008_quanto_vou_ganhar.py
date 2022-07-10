##Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês.
# Calcule e mostre o total do seu salário no referido mês.

s = float(input('Quanto você ganha por hora:'))
h = float(input('Quantas horas voce trabalha por mes: '))

sm = s * h

print('Trabalhando {} horas por dia, e ganhando R${} por hora, voce ganhara R${} por mes '.format(s, h, sm))
