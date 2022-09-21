#include <stdio.h>
#include <string.h>

int main(void) {

  char nome[15];
  char *str1 = "banana1";
  char *str2 = "banana2";
  int ret;
  
  strcpy(nome, "Fulano de Tal");

  printf("\n Exemplo de cópia de string");
  printf("\n*-------------*");

  printf("\n Nome = %s", nome);
  printf("\n O tamanho da string 'nom' é %li",strlen(nome));

  printf("\n*-------------*");
  printf("\n Compração de String");

  ret = strncmp(str1, str2, 8);

  if(ret > 0){
    printf("\nStr1 é maior");
  }else if (ret < 0){
    printf("\nStr2 é maior");
  }else{
    printf("\nAs duas palavras são iguais");
  }
  
  
  return 0;
}