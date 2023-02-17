void main(){
  int idade = 11;
  if(idade >= 18){
    print("Você tem ${idade} anos, então já pode solicitar seu cartão de credito");
  }else if(idade >= 14 && idade < 18){
    print("Você tem ${idade} anos, então só pode solicitar o cartão com autorização dos seus pais");
  }else{
    print("Você tem ${idade} anos, então ainda não pode solicitar um  cartão");
  }

  print("Fim do programa");
}