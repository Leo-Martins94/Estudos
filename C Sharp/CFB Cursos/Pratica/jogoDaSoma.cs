using System;
public class Jogador{
    public string name;
    public int point;
    public int tentativas;
    public Jogador(string n){
        name=n;
        point=0;
    }
    ~Jogador(){
        Console.WriteLine("Fim de jogo, até a próxima");
    }
}

class JogoDaSoma{
    static void Main(){
        string nameJ1;
        int [] perguntas =new int[5];
        int v1,v2,resultado,p;
        char jogar='s';
        p=0;

        BoasVindas();

        nameJ1=Console.ReadLine();
        Random random = new Random();

        for(int i=0; i<perguntas.Length;i++){
            perguntas[i]=random.Next(100);
        }

        Jogador j1= new Jogador(nameJ1);

        Console.Write("Certo {0}, Voce está pronto para começar o desafio? [s]sim / [n]não: ",j1.name);
        jogar=char.Parse(Console.ReadLine());
        Console.WriteLine("------------------------------------------");
        while (jogar == 's'){
            Console.WriteLine("Muito bem, gerando perguntas....");
            for(int i=0; i<perguntas.Length;i++){
                perguntas[i]=random.Next(100);
            }
            Console.WriteLine("-------------------------------------");
            for(int i=0; i < perguntas.Length; i++){
                p++;
                Console.WriteLine("Pergunta {0} - Digite dois numeros para chegar em {1}: ",p,perguntas[i]);
                Console.Write("Digite o primeiro numero: ");
                v1=int.Parse(Console.ReadLine());
                Console.Write("Voce ja digitou {0}, digite o segundo numero: ",v1);
                v2=int.Parse(Console.ReadLine());
                resultado=Soma(v1,v2);
                if (perguntas[i] == resultado){
                    j1.point++;
                }
            }

            Console.WriteLine("{0} você fez {1} pontos",j1.name,j1.point); 
            Console.WriteLine("----------------------------------------");
            Console.Write("Deseja Jogar novamente? [s]sim / [n] não: ");
            jogar=char.Parse(Console.ReadLine());
        }
       



    }

    static void BoasVindas(){
        Console.WriteLine("Bem vindo ao jogo da soma");
        Console.WriteLine("Você terá que informar dois números, e a soma deles deverá ser igual ao número informado, vamos nessa?");
        Console.Write("Primeiro informe seu nome: ");
    }

    static int Soma(int n1, int n2){
        int res;
        res=n1+n2;
        return res;
    }    


}
