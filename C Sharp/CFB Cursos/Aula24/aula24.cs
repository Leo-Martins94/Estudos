using System;
class Aula24{
    static void Main(){
        int v1,v2,r;
        genisis();
        Console.WriteLine("---------------------");
        Console.Write("Digite o primeiro valor: ");
        v1=int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2=int.Parse(Console.ReadLine());
        //r=soma(v1,v2);
        Console.WriteLine("A soma de {0} e {1} é: {2}",v1,v2,soma(v1,v2));
    }

    static void genisis(){//corpo de metodo basico, metodo void não retorna nada

        Console.WriteLine("Genisis");
        Console.WriteLine("Cuso de C#");
        Console.WriteLine("Aula24");

    }

    static int soma(int n1, int n2){
        int s=n1+n2;

        return s;
    }



}