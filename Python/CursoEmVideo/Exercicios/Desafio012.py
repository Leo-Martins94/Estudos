#Faça um algoritimo que leia o preço de um produto e mostre seu novo preço com 5% de desconto

print('Consultor de preços')
print('----------------------')

p = float(input('Digite o valor do produto: '))

d = p*0.05
pd = p-d

print('O desconto é de R$ {}, o produto custara R$ {}'.format(d, pd))
