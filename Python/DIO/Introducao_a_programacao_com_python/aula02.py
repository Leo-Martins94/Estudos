a = int(input('Digite o primeiro número: '))
b = int(input('Digite o segundo numero: '))

soma = a + b
subtracao = a - b
divisao = a / b
multiplicacao = a * b
resto = a % b

#Convertentdo int em string para concatenação
soma = str(soma)

#Convertendo resultado da devisao para int
dicisao = int(divisao)

print(type(soma))
print(type(divisao))
print('Soma: ' + soma)
print('subtração: {},\n Divisão: {},\n Multiplicação: {mult}\n'.format(subtracao, divisao, mult = multiplicacao))
