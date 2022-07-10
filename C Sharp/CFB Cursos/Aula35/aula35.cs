using System;

class Veiculo{
    private int rodas;
    public int velMax;
    private bool ligado;

    public Veiculo(int rodas){
        this.rodas=rodas;
    }
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }
    public string getLigar(){
        return(ligado?"sim":"não");
    }
    public int getRodas(){
        return rodas;
    }
    public void setRodas(int rodas){
        if(rodas<0){
            this.rodas=0;
        }else{
            this.rodas=rodas;
        }
    }
}

class Carro:Veiculo{
    public string nome;
    public string cor;

    public Carro(string nome, string cor):base(4){
        velMax=200;
        this.nome=nome;
        this.cor=cor;
        desligar();
    }
}

class CarroCombate:Carro{
    public int municao;
    public CarroCombate():base("Kverão","Camuflado"){
        municao=200;
        setRodas(8);
    }
}

class Aula35{
    static void Main(){
        Carro c1=new Carro("Jetta","Prata");
        CarroCombate cc1=new CarroCombate();

        Console.WriteLine("Nome: {0}",c1.nome);
        Console.WriteLine("Cor: {0}",c1.cor);
        Console.WriteLine("Rodas: {0}",c1.getRodas());
        Console.WriteLine("Velocidade Maxima: {0}",c1.velMax);
        Console.WriteLine("Está ligado: {0}",c1.getLigar());
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Nome: {0}",cc1.nome);
        Console.WriteLine("Cor: {0}",cc1.cor);
        Console.WriteLine("Rodas: {0}",cc1.getRodas());
        Console.WriteLine("Munição: {0}",cc1.municao);
        Console.WriteLine("Velocidade Maxima: {0}",cc1.velMax);
        Console.WriteLine("Está ligado: {0}",cc1.getLigar());

    }
}