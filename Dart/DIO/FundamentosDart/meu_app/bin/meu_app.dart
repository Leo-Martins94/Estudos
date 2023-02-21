import 'package:meu_app/meu_app.dart' as meu_app;
import 'dart:io';
import 'dart:convert';

import 'package:test/test.dart';
void main(List<String> arguments) {
   print("Bem vindos a nossa calculadora!");
   print("Informe o primeiro número");
   var line = stdin.readLineSync(encoding: utf8);
   var numero1 = double.parse(line ?? "0");

   print("Informe o segundo número:");
   line = stdin.readLineSync(encoding: utf8);
   var numero2 = double.parse(line ?? "0");

   print("Informe a operação (+, -, *, /)");
   line = stdin.readLineSync(encoding: utf8);
   var operacao = line ?? "";

   double resultado = 0.0;

   switch(operacao){
    case "+":
      resultado = numero1 + numero2;
    break;
    case "-":
      resultado = numero1 - numero2;
    break;
    case "*":
      resultado = numero1 * numero2;
    break;
    case "/":
      resultado = numero1 / numero2;
    break;
    default:
      print("Operação inválida");
      exit(0);
   }

   print("O resultado: $numero1 $operacao $numero2 = $resultado");

}
