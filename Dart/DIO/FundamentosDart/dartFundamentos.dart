import 'dart:io';
import 'dart:convert';
void main(List<String> arguments) {
   String texto = "Flutter e dart na DIO";
   var texto2 = "DIO";
   String texto3 = texto + texto2;

   print(int.tryParse(texto3));
   print(texto.contains(texto2));
   print(texto.substring(5));
   print(texto.replaceAll("a", "@"));
  

   int numero1 = 1;
   var numero2 = 2;
   int numero3 = numero1 + numero2;

   print("Retorna verdadeiro se a soma for par");
   print(numero1.isEven);
   print(numero2.isEven);

  print("Retorna verdadeiro se for impar");
  print(numero3.isOdd);

  print("É um numero");
  print(numero2.isNaN);

  print("É negativo");
  print(numero3.isNegative);

   List<String> lista = [];
   lista.add("A");
   lista.add("B");
   var lista1 = [];
   lista1.add(1);
   lista1.add(true);
   lista1.add("value");

   double d1 = 3.3;
   double d2 = 2.8;
   print("Remove ponto flutuante");
   print(d1.truncate());
   print("Converte para inteiro");
   print(d2.toInt());
   print("Aredonda para cima");
   print(d1.ceil());
   print("Arredonda para baixo");
   print(d2.floor());

   Map<String, dynamic> map1 = Map<String,dynamic>();

   map1.addAll({"nome":"Leo","Sobrenome":"Martins","Nascimento":DateTime(1994,07,21)});
   print(map1);

   //if ternario
   print("Informe a primeira nota:");
   var line1 = stdin.readLineSync(encoding: utf8);
   print("Informe a segunda nota");
   var line2 = stdin.readLineSync(encoding: utf8);
   var prova1 = int.parse(line1 ?? "0");
   var prova2 = int.parse(line2 ?? "0");

   var resultado = (((prova1 + prova2)/2) >= 7) ? "Aluno aprovado" : "Aluno reprovado";

   print(resultado);

}
