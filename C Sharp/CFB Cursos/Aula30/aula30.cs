using System;
public class Jogador{
    public string nome;
    public int energia;
    public bool vivo;

    public Jogador(){
        energia=100;
        vivo=true;
        nome="Jogador";
    }

    public Jogador(string n){
        nome=n;
        energia=100;
        vivo=true;

    }

    public Jogador(string n, int e){
        energia=e;
        vivo=true;
        nome=n;

    }

    public Jogador(string n, int e, bool v){
        energia=e;
        vivo=v;
        nome=n;
    }

    public void info(){
        Console.WriteLine("Nome do jogado: {0}",nome);
        Console.WriteLine("Energia: {0}",energia);
        Console.WriteLine("Status: {0}",vivo);
        Console.WriteLine("------------------------\n");
    }

    ~Jogador(){
        Console.WriteLine("Fim de jogo {0}",nome);
    }
}

class Aula30{
    static void Main(){

        Jogador j1=new Jogador();
        Jogador j2=new Jogador("Leo");
        Jogador j3=new Jogador("MArtins",50);
        Jogador j4=new Jogador("Mano",0,false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
    }

}