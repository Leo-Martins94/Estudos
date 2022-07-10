#Desenvolva um programa que leia as duas notas de um aluno
#E calcule e mostre a sua media

print('Curso em video')
print('---------------------')

n1 = float(input('Digite a nota no primeiro semestre: '))
n2 = float(input('Digite a nota no segundo semestre: '))

m = (n1+n2)/2

print('O aluno tirou {} no primeiro semestre e {} no segundo semtre, fechando a media {}'.format(n1, n2, m))