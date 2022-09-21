#include <stdio.h>

  int sqrt(int entrada){
    entrada = entrada * entrada;
    return (entrada);
  }

	int main(void)

	{

    int t = 4;

    printf("\n *exemplo de função por Referencia");
    printf("\n*-------------*");
    printf("\n %d %d", sqrt(t),t);
    
	  return 0;
	}