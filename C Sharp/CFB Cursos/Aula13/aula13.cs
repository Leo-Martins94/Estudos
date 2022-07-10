using System;
class Aula13{
    static void Main(){
        int n1,n2,m;
        string res;
        n1=n2=0;
        Console.Write("Digite a nota em n1: ");
        n1=int.Parse(Console.ReadLine());
        Console.Write("Digite a nota em n2: ");
        n2=int.Parse(Console.ReadLine());

        m=(n1+n2)/2;

        if (m <4){
            res="Reprovado";
        }else if (m <= 5 ){
            res="Deverá fazer recuperação";
        }else{
            res="Aprovado";
        }

        Console.WriteLine("A media foi {0} portanto o aluno está {1}",m,res);
    }
}