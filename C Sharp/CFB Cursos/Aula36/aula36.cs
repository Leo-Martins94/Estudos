using System;

class Veiculo{
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax){
        velAtual=0;
        this.velMax=velMax;
        ligado=false;
    }
    public int getVelMax(){
        return velMax;
    }
}

class Carro:Veiculo{
    public string nome;
    public Carro(string nome,int vMax):base(vMax){
        this.nome=nome;
        ligado=true;
    }

    public void info(){
        Console.WriteLine("nome: {0}",nome);
        Console.WriteLine("Velocidade atual: {0}",velAtual);
        Console.WriteLine("Velocidade Maxima: {0}",getVelMax());
        Console.WriteLine("Está ligado? {0}",ligado);
    }

}

class Aula36{
    static void Main(){
        Carro carro=new Carro("Mustang Shelby",300);

        carro.info();
    }
}