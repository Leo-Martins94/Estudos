# a = int(input('Primeiro valor: '))
# b = int(input('Segundo valor: '))
# c = int(input('Terceiro valor: '))
# if a > b and a > c:
#     print('O maios valor é {}'.format(a))
# elif b > a and b > c:
#     print('O maior valor é {}'.format(b))
# else :
#     print("O maior valor é {}".format(c))
#
# print('Fim do programa')

# a = int(input('Digite um número: '))
# b = int(input('Digite outro número: '))
#
# rest1 = a % 2
# rest2 = b % 2
#
# if rest1 == 0 and rest2 == 0:
#     print('Os números {} e {} são pares'.format(a, b))
# elif rest1 == 0 and rest2 != 0:
#     print('Apenas o número {} é par'.format(a))
# else:
#     print('Apenas o número {} é par'.format(b))

n1 = int(input('Digite a primeira nota'))
n2 = int(input('Digite a segunda nota'))
n3 = int(input('Digite a tercira nota'))
n4 = int(input('Digite a quarta nota'))

media = (n1 + n2 + n3 + n4)/4

if media == 10:
    print('Aprovado com louvor')
elif media == 8 and media < 10:
    print('Aprovado')
elif media >= 5 and media < 8:
    print('Em recuperação')
else:
    print('Aluno Reprovado')

print('Fim do sistema')