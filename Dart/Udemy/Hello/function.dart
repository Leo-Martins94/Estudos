void main(){
  double result = 0.0;
  boasVindas("Leo");
  result = soma(5,5);
  print(result);
  
}

void boasVindas(String n){
  String nome = n;
  print("Bem vindo ${nome}");
}

double soma(double a, double b){
  double resultado = a + b;
  return resultado;
}