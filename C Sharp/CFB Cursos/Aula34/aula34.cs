using System;

class Veiculo{//classe base.
    public int rodas;
    public int velMax;
    private bool ligado;
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }

    public string getLigar(){
        if(ligado){
            return "Sim";
        }else{
            return "Não";
        }
    }
}

class Carro:Veiculo{//classe derivada de veiculo.
    public string nome;
    public string cor;
    public Carro(string nome, string cor){
        rodas=4;
        velMax=200;
        this.nome=nome;
        this.cor=cor;
        desligar();
    }
}

class Aula34{
    static void Main(){
        Carro c1=new Carro("Jetta","Azul");
        Console.WriteLine("Nome: {0}",c1.nome);
        Console.WriteLine("Cor: {0}",c1.cor);
        Console.WriteLine("Rodas: {0}",c1.rodas);
        Console.WriteLine("Velocidade Maxima: {0}",c1.velMax);
        Console.WriteLine("Está ligado: {0}",c1.getLigar());

    }
}