using System;
struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor){
        this.marca=marca;
        this.modelo=modelo;
        this.cor=cor;
    }

    public void info(){
        Console.WriteLine("Marca: {0}",this.marca);
        Console.WriteLine("Modelo: {0}",this.modelo);
        Console.WriteLine("Cor: {0}", this.cor);
        Console.WriteLine("------------- \n");
    }
}
class Aula44{
    static void Main(){
        Carro c1;
        Carro c2 = new Carro("Honda", "MacLaren", "Laranja");

        c1.marca="Ford";
        c1.modelo="Shelby";
        c1.cor="prata";

        c1.info();
        c2.info();
        
    }
}