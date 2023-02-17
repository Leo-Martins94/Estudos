void main(){
  String status = "PENDENTE";

  switch (status){
    case "ABERTO":
      print("O seu pedido ainda está em aberto");
    break;
    case "ANDAMENTO":
      print("Seu pedido já está em andamento");
    break;
    case "FECHADO":
      print("O seu pedido já foi finalizado");
    break;
    default:
      print("Status invalido");
    break;
  }

  print("Fim do programa");
}