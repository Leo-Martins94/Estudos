#Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu peso ideal.
# usando a seguinte fórmula: (72.7*altura) - 58

msg = 'IMC'
altura = float(input('Digite sua altura: '))

pesoIdeal = (72.7*altura) - 58

print(msg)
print('Para a sua altura {}, seu peso ideal é {}'.format(altura, pesoIdeal))