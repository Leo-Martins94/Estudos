using System;
class Aula20{
    static void Main(){
        
        int[] num=new int[8];
        int i=num.Length-1;

        while(i>0){
            num[i]=i;
            Console.WriteLine(num[i]);
            i--;
        }

        Console.WriteLine("Fim da execução");

    }
}