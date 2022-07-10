#Crie um programa que leia quanto dinheiro uma pessoa tem na carteira e mostre quantos dolares a pessoa pode comprar

print('conversor de moedas')

r = float(input('Quantos reais voce tem? '))

d = r / 5.2

print('Com R$ {}, voce pode comprar ${:.2f}'.format(r, d))