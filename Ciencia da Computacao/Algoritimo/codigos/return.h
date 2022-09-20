#include <stdio.h>
#include <stdbool.h>

bool verificaPar(int numero){
  if(numero % 2 == 0){
    return true;
  }else{
    return false;
  }
}

int main(void) {
  
  int numeroEntrada = 4;

  if(verificaPar(numeroEntrada)){
    printf("\n Sim. O número %d é PAR", numeroEntrada);
  }else{
    printf("\n não. O numero %d é IMPAR ", numeroEntrada);
  }
  
  return 0;
}