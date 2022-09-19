#include <stdio.h>
#include <stdlib.h>

int entradaDados(){
  int numeroEntrada;
  printf("\n Informe o número base para tabuada: ");
  scanf("%d", &numeroEntrada);
 return numeroEntrada; 
}

int main(void) {

  int numeroDigitado = entradaDados();
  if(numeroDigitado < 1 || numeroDigitado > 10){
    printf("\n Númeor Informado é inválido (Fora do Intervalor 1-10");
    exit(0);
  }
  printf("\n*-----------*");
  printf("\n Você selecionou a tabuada do %d", numeroDigitado);
  printf("\n*-----------*");
  for(int controle =1; controle <=10; controle++){
    printf("\n %d x %d = %d", controle, numeroDigitado, numeroDigitado * controle);
  }
  
  return 0;
}