//import 'package:meu_app/meu_app.dart' as meu_app;
import 'dart:io';
import 'dart:convert';

import 'package:test/test.dart';
void main(List<String> arguments) {
   
  print("Bem vindos a nossa calculadora!");

  var numero1 = lerConsoleDouble("Informe o primeiro numero");

  var numero2 = lerConsoleDouble("Informe o segundo numero");

  var operacao = lerConsole("Informe a operação (+, -, *, /)");

  calcular(operacao, numero1, numero2);

}

void calcular(String operacao, double numero1, double numero2){
  double resultado = 0.0;

  switch(operacao){
    case "+":
      resultado = soma(numero1, numero2);
    break;
    case "-":
      resultado = subtracao(numero1, numero2);
    break;
    case "*":
      resultado = mult(numero1, numero2);
    break;
    case "/":
      resultado = div(numero1, numero2);
    break;
    default:
      print("Operação inválida");
      exit(0);
  }

  print("O resultado: $numero1 $operacao $numero2 = $resultado");
}

double lerConsoleDouble(String texto){
  var numero = double.tryParse(lerConsole(texto));
  if(numero == null){
    print("Número invalido, aplicando o numero 0");
    return 0.0;
  }else{
    return numero;
  }
}

String lerConsole(String texto){
  print(texto);
  var line = stdin.readLineSync(encoding: utf8);
  return line ?? "";
}

double soma(double n1, double n2){
    double result = n1 + n2;
    return result;
}

double subtracao(double n1, double n2){
    double result = n1 - n2;
    return result;
}

double mult(double n1, double n2){
    double result = n1 * n2;
    return result;
}

double div(double n1, double n2){
  if(n2 == 0){
    print("Não é possivel dividir por 0");
    exit(0);
  }else{
    double result = n1 / n2;
    return result;
  }
}