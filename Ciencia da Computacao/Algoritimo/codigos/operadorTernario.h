#include <stdio.h>

int main(void) {
  int cod = 101;
  int resultado = cod > 100 ? 200 : 300;
  printf("Valor de resultado %d\n",resultado);
  return 0;
}