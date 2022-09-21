#include <stdio.h>

  double fatorial(int entrada){
    double vFatorial;
    printf("\n Sequencia de Chamadas recursivas = %d", entrada);
    if(entrada <= 1){
      return(1);
    }else{
      vFatorial = entrada * fatorial(entrada -1);
      printf("\n Valores Retornados = %2.f", vFatorial);
      return (vFatorial);
    }
  }

	int main(void)

	{
	  int numero;
    double f;

    printf("Digite o numero que deseja calcuar o fatorial: ");
    scanf("%d", &numero);
    printf("\n *------------*");
    f = fatorial(numero);
    printf("\nFatorial de &d = %.01f", numero, f);
    
	  return 0;
	}