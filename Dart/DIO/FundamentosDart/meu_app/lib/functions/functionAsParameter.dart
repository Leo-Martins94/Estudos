void main(List<String> args) {
  print(executar(10,incrementar));
  print(executar(10,decrementar));
}

int executar (int numero, Function func){
  return func(numero);
}

int incrementar(int numero){
  return numero++;

}

int decrementar(int numero){
  return numero--;
}