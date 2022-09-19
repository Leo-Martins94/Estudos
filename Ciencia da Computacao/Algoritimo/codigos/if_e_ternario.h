#include <stdio.h>

int main(void) {
 int valor, valor2;
  printf("Informe um Valor numérico: ");
  scanf("%d", &valor);
  if(valor < 0){
    valor2 = 0;
  }else{
    valor2 = valor;
  }
  printf("\n Resolvido com estrutura de if");
  printf("\n ---------------");
  printf("\nO valor de valor2 é: %d \n\n",valor2);
  printf("\n------------");
  printf("Informe um Valor numérico: ");
  scanf("%d", &valor);
  valor2 = (valor < 0) ? 0:valor;
  printf("\nResolvido com Operador ternario '?'");
  printf("\n-----------");
  printf("\nO valor de valor2 é: %d \n\n", valor2);
  return 0;
}