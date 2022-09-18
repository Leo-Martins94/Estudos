#include <stdio.h>

int main(void) {
  int iJ, iI;
  iJ =18; iI = 60;
  int idade = 59;
  if((idade > iJ)&&(idade < iI)){
    printf("A idade informada é d eima pessoa de meia-idade");
  }else{
    if(idade >= iI){
      printf("\nA idade informada é de uma pessoa idosa. \n");
    }else{
      printf("\nA idade informada é de um jovem.\n");
    }
  }
  return 0;
}