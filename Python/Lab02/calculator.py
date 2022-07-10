#Criando a pythonCaulator

#Variaveis
x = 0
y = 0
op = 0
calcular = 's'
msg = "''''''''PyCalculato'''''''''"
painel = 'Escolha a operação:\n 1 - Soma\n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão'
msgErro = 'Informe uma operação valida'
#Funções

soma = lambda x,y : x+y
sub  = lambda x,y : x - y
mult = lambda x,y : x * y
div = lambda x,y : x / y

while calcular == 's':
    print(msg)
    print(painel)
    op = int(input('Digite a operação: '))
    x = float(input('Digite o primeiro número: '))
    y = float(input('Digite o segundo número: '))
    if op == 1:
        res = soma(x,y)
        print(res)
    elif op == 2:
        res = sub(x,y)
        print(res)
    elif op == 3:
        res = mult(x,y)
        print(res)
    elif op == 4:
        res = div(x,y)
        print(res)
    else:
        print(msgErro)
    calcular = input('Deseja fazer outro calculo [s/n]: ')
else:
    print('Fim do programa')