#include <stdio.h>
	int main(void)

	{
	  int soma = 20 + 30;
	  int * somaParcial = &soma;
	  printf("\nTeste de utilização de uso de Ponteiros");
	  printf("\n*---------------------------------------*");
	  printf("\n Valor da variável ‘soma’= %i", soma);
	  printf("\n valor da variável *SomaParcial = %i", * somaParcial);
	  return 0;
	}