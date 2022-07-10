using System;
public class Jogador{
    static public string name;
    static public int energia;
    static public bool vivo;
    static public void iniciar(string n){
        name=n;
        energia=100;
        vivo=true;

    }
    static public void info(){
        Console.WriteLine("Nome: {0}",name);
        Console.WriteLine("Energia: {0}",energia);
        Console.WriteLine("Status: {0}",vivo);
        Console.WriteLine("-----------------\n");
    }

}

    class Inimigo{
        static public  bool alerta;
        public string nome;
        public Inimigo(string n){
            alerta=false;
            nome=n;
        }

        public void info(){
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Em alerta: {0}", alerta);
            Console.WriteLine("----------------------\n");
        }
    }
class Aula31{
    static void Main(){

        Jogador.iniciar("Leo");
        Jogador.info();

        Inimigo i1 = new Inimigo("Cabuloso");
        Inimigo i2 = new Inimigo("Trevoso");
        Inimigo i3 = new Inimigo("Capiroto");

        Inimigo.alerta=true;

        i1.info();
        i2.info();
        i3.info();

    }
}