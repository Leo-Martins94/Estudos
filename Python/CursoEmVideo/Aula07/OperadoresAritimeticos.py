#nome = input("Qual o seu nome?  ")
#print('Prazer em te conhecer {:=^20}'.format(nome))

n1 = int(input('Digite um valor: '))
n2 = int(input('Digite outro valor: '))

s = n1+n2
sub = n1-n2
m = n1*n2
d = n1/n2
dint = n1//n2
r = n1%n2
e = n1**n2

print('A soma dos valores indicados é {}, a subtração é {} e a multiplicação é {}'.format(s,sub,m),end=">>")
print('A divisão é {:.2f}, a divisão inteira é {}, e o resto da divisão é {}'.format(d,dint,r))
print('A  potencia é {}'.format(e))



