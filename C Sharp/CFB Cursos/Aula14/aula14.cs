using System;
class Aula014{
    static void Main(){

        int n1,n2,m;
        string res,nome;

        n1=n2=0;

        Console.Write("Digite o nome do aluno: ");
        nome=Console.ReadLine();
        Console.Write("Digite a nota n1: ");
        n1=int.Parse(Console.ReadLine());
        Console.Write("Digite a nota n2: ");
        n2=int.Parse(Console.ReadLine());

        m=(n1+n2)/2;


        if(m >=6){
            if(m==10){
               res="Aprovado com louvor";     
            }else
            {
              res="Aprovado";  
            }
        }else{
            if (m >=5)
            {
                res="Em recuperação";
            }else
            {
                res="Reprovado";
            }
        }

        Console.Write("O aluno {0} recebeu a media {1}, portanto está {2}",nome,m,res);

    }
}