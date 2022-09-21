#include <stdio.h>

int main(void) {
  float notas[4];
  float soma = 0;

  printf("\n Exemplo de inicialização dinâmica de vetor");
  printf("\n*-----------*");
  for(int indice1 = 0; indice1 < 4; indice1++){
    printf("\nInforme a nota %d ", indice1+1);
    scanf("%f",&notas[indice1]);
  }

  for(int indice2 = 0; indice2 < 4; indice2++){
    soma = soma + notas[indice2];
  }

  printf("\n A mpedia das notas é: %.2f",(soma/4));
  
  return 0;
}