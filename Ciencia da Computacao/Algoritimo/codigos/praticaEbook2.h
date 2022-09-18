#include <stdio.h>

int main(void) {
  int b1,b2,b3,b4, media;
  printf("\n Digite a nota do primeiro bimeste: ");
  scanf("%i",&b1);
   printf("\n Digite a nota do segundo bimeste: ");
  scanf("%i",&b2);
   printf("\n Digite a nota do terceiro bimeste: ");
  scanf("%i",&b3);
   printf("\n Digite a nota do quarto bimeste: ");
  scanf("%i",&b4);

  media = (b1+b2+b3+b4)/4;

  if(media >= 7){
    printf("\nAluno aprovado com média: %i", media);
  }else{
    printf("\nAluno reprovado com média: %i", media);
  }
  
  
  return 0;
}