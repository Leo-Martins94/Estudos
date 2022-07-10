using System;
class Aula17{
    static void Main(){
        int[]n=new int[5];//primeira forma de armazenar um vetor
        int[]num=new int[3]{3,5,4};
        int []num1={8,7,5,8,9}

        n[0]=10;//O indice que o nome elemento será atribuido é indicado dentro do colchete
        n[1]=4;
        n[2]=87;
        n[3]=69;
        n[4]=64;

        Console.WriteLine(n[0]);
        Console.WriteLine(num[2]);
        Console.WriteLine(num1[4]);
    }
}