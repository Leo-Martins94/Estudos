#include <stdio.h>
#include <stdbool.h>

float nota1, nota2, nota3, nota4;

int entradaNotas(){
  for (int controle =1; controle <= 4 ; controle++){
    printf("\n Informe a nota %d = ", controle);
    switch(controle){
      case 1:
        scanf("%f", &nota1);
      break;
      case 2:
        scanf("%f", &nota2);
      break;
      case 3:
        scanf("%f",&nota3);
      break;
      case 4:
        scanf("%f",&nota4);
      break;
    }
  }
}

bool entradaOpcao(){
  int opcaoDigitada;
  int digitacaoOk = 1;
  printf("\n Você deseja calcular outra média? (1=sim/0=Não)");
  while (digitacaoOk == 1){
    scanf("%d", &opcaoDigitada);
    if(opcaoDigitada == 1 || opcaoDigitada ==0){
      digitacaoOk = 0;
    } else{
      digitacaoOk = 1;
      printf("\n Opção invalida (Deve ser 1-sim 0= Não): %d", opcaoDigitada);
    }
  }
  if (opcaoDigitada == 1){
    return true;
  }else{
    return false;
  }
}

int main(void) {
  float media, mediaTurma;
  float acumulaMedia= 0;
  int qtdAlunos = 0;
  bool continuaProcessamento = true;
  while(continuaProcessamento){
   entradaNotas();
    media = (nota1 + nota2 + nota3 + nota4)/4;
    printf("\n *--------*");
    acumulaMedia = acumulaMedia + media;
    qtdAlunos = qtdAlunos +1;
    if(media >= 7.0){
      printf("\n Este Aluno foi APROVADO com média = %.2f",media);
    }else{
      printf("\n Este Aluno foi REPROvADO com média = %.2f", media);
    }
    continuaProcessamento = entradaOpcao();
  }

  mediaTurma = acumulaMedia / qtdAlunos;
  printf("\n *----------*");
  printf("\n A média da Turma foi = %f", mediaTurma);
  printf("\n Obrigado por usar o sistema");
  
  return 0;
}