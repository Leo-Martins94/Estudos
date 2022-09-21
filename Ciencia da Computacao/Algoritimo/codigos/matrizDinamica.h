#include <stdio.h>

float amostraTemperaturaTrimestral[3][4];

void entradaTemperaturas(){
  for(int indice1=0; indice1 < 3; indice1++){
    for(int indice2=0; indice2 <4; indice2++){
      printf("\n Informe a temperatura #%d para o Mes $%d: ", indice2+1, indice1+1);
    scanf("%f", &amostraTemperaturaTrimestral[indice1][indice2]);
    }
  }
}

int main(void) {
  
  entradaTemperaturas();

  printf("\n Exemplo de acesso a Matriz Bidimensional");
  printf("\n*------------*");

  for(int indiceI = 0; indiceI < 3; indiceI ++){
    printf("\n*----------*");
    for(int indiceJ = 0; indiceJ <4; indiceJ++){
      printf("\n Temperaturas %d = %.2f", indiceJ+1, amostraTemperaturaTrimestral[indiceI][indiceJ]);
    }
  }
  
  return 0;
}