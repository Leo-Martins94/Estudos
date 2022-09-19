#include <stdio.h>

char menu(void){
  char opcaoDigitada;
  printf("\n*-----------*");
  printf("\n* CADASTRO DE CLIENTES *");
  printf("\n* *");
  printf("\n* 1- Consulta *");
  printf("\n* 2- Alteração *");
  printf("\n* 3- Inclusão *");
  printf("\n* 4- Exclusão *");
  printf("\n* 0- Sair *");
  printf("\n*----------*");
  printf("\n* Selecione a opção: ");
  opcaoDigitada=getchar();
  return opcaoDigitada;
}

int main(void) {
  char opcao = menu();
  switch(opcao)
    {
      case '1':
        printf("\n Voce escolheu Consulta");
      break;
      case '2':
        printf("\n Voce escolheu Alteração");
      break;
      case '3':
        printf("\n voce escolheu Inclusão");
      break;
      case '4':
        printf("\nVoce escolheu Exclusão");
      break;
      Default:
        printf("Opção Invalida");
    }
  return 0;
}