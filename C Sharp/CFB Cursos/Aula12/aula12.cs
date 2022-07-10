using System;
class Aula012{
    static void Main(){

        int nota=0;
        string resultado="Reprovado";

        Console.Write("Digite a nota para sabe ro resultado");

        nota=int.Parse(Console.ReadLine());

        if(nota >= 60){
            resultado="Aprovado";
        }

        Console.WriteLine("Resultado: {0}",resultado);

    }
}