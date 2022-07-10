## faça um  programa que receba 4 notas bimestrais e devolva a media

b1 = float(input('digite a media do primeiro bimestre: '))
b2 = float(input('digite a media do segundo bimestre: '))
b3 = float(input('digite a media do terceiro bimestre: '))
b4 = float(input('digite a media do quarto bimestre: '))

media = (b1 + b2 + b3 + b4) / 4

print('A media do aluno foi: {}'.format(media))