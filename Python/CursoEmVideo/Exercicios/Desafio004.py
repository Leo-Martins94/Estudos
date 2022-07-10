# Faça um programa que leia algo pelo teclado e mostre na tela o seu tipo primitido,
# e todas as informações e todas as informações possiveis sobre ele

msg = 'Digite algo que vamos dar informações sobre ele, pronto para começar ?'

print(msg)

algo = input('Digite algo: ')

print(algo)
print('O tipo do elemento digitado é: ', type(algo))
print('--------------------------------')

print('É numerio ?', algo.isnumeric())
print('--------------------------------')

print('É decimal?')
print(algo.isdecimal())
print('--------------------------------')

print('É AlphaNumerico?')
print(algo.isalnum())
print('--------------------------------')

print('É Alfabetico?')
print(algo.isalpha())




