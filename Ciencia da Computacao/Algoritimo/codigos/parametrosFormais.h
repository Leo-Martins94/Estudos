#include <stdio.h>

int operaValores(char operacao, int valor1, int valor2){
  int resultado = 0;

  if (operacao == 'A')
  {
    resultado = valor1 + valor2;
  }
  else
  {
    resultado = valor1 * valor2;
  }

return resultado;
  
}

int main(void) {
  int operacao = operaValores('M',2,3);
  printf("O valor da Operação é:%d",operacao);
  
  return 0;
}