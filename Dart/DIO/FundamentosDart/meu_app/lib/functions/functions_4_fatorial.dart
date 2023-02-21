void main(List<String> arguments){
  var resultado = fatorial(3);
  print(resultado);
}

int fatorial(int numero){
  if(numero == 1){
    return 1;
  }else{
    return numero *fatorial(numero-1);
  }
}