using System;

public class Jogador{
    public string nome;
    public int energia;
    public bool vivo;
    public Jogador(string n){
        nome=n;
        energia=100;
        vivo=true;
    }
    ~Jogador(){
        Console.WriteLine("Jogador {0} deletado... Game Over", nome);
    }
}

class Aula29{
    static void Main(){
        string nomeJ1, nomeJ2;
        Console.Write("Digite o nome do jogador 1: ");
        nomeJ1=Console.ReadLine();
        Console.Write("Digite o nome do jogador 2: ");
        nomeJ2=Console.ReadLine();
        Jogador j1=new Jogador(nomeJ1);
        Jogador j2=new Jogador(nomeJ2);

        j1.energia=50;

        Console.WriteLine("Energia do jogador {0} : {1}",j1.nome,j1.energia);
        Console.WriteLine("Energia do jogador {0}: {1}",j2.nome,j2.energia);

    }
    
}