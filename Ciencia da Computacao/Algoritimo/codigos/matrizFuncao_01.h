#include <stdio.h>

  void imprimeValores(int valores[5]){
    for(int controle = 0; controle < 5; controle++){
      printf("\n Valor da ocorrência %d = %d", controle, valores[controle]);
    }
  }

	int main(void)
	{

    printf("\n *Exemplo de parametro declarado como Matriz");
    printf("\n*-------------*");
    int valoresOriginais[5] = {
    50,40,30,20,10
    };
    imprimeValores(valoresOriginais);
    
	  return 0;
	}