#Escreva um programa que leia um valor em metros
#e exiba ele convertido em centimetros e milimetros

print('Conversor de medidas')
print('--------------------------')

m = float(input('Digite a medida em metros: '))
km = m/1000
hm = m/100
dam = m/10
dm = m*10
cm = m*100
mm = m*1000

print('{} KM. \n {} hm. \n {} dam. \n {} metro(s). \n {} decimetros. \n{} centimetros. \n {} milimetros.'.format(km, hm, dam, m, dm, cm, mm))