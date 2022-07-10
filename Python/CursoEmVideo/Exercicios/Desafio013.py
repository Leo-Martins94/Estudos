#Faça um algoritimo que leia o salário de um funcionario e moste o novo salario com 15% de aumento

s = float(input('Digite o salario a ser reajustado: '))

a = s*0.15
r = a+s

print('O aumento foi de R${:.2f}, o novo salario é de R${:.2f}'.format(a, r))