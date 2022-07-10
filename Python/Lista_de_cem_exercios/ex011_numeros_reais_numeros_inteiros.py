#Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre:
# A - o produto do dobro do primeiro com metade do segundo .
# B - a soma do triplo do primeiro com o terceiro.
# C - o terceiro elevado ao cubo.

msg = 'A - o produto do dobro do primeiro com metade do segundo .\nB - a soma do triplo do primeiro com o terceiro.\nC - o terceiro elevado ao cubo.'
msgReal = 'Números reais é o nome dado ao conjunto numérico mais conhecido e utilizado por todos, pois qualquer número inteiro ou decimal pertence também a esse conjunto. Sua definição mais utilizada é a seguinte: A união entre o conjunto dos números racionais e o conjunto dos números irracionais.'

print(msgReal)
i1 = int(input('Digite o primeiro número inteiro: '))
i2 = int(input('Digite o segundo número inteiro: '))
r = float(input('Digite um número real: '))

a = (i1 * 2) / (i2/2)
b = (i1 * 3) + r
c = (r**3)

print(msg)
print('A - {}'.format(a))
print('B - {}'.format(b))
print('C - {}'.format(c))
