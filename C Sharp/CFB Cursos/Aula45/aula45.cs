using System;
struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public void info(){
        Console.WriteLine("Marca.: {0}",this.marca);
        Console.WriteLine("Modelo: {0}",this.modelo);
        Console.WriteLine("Cor...: {0}",this.cor);
        Console.WriteLine("-----------------------");
    }
}
class Aula45{
    static void Main(){
        Carro[] carros = new Carro[5];

        carros[0].marca="Honda";
        carros[0].modelo="Civic";
        carros[0].cor="Azul";
        carros[1].marca="Ford";
        carros[1].modelo="Mustang GT";
        carros[1].cor="Prata";
        carros[2].marca="Honda";
        carros[2].modelo="MacLarren";
        carros[2].cor="Laranja";
        carros[3].marca="Ferrari";
        carros[3].modelo="Enzo";
        carros[3].cor="Vermelho";
        carros[4].marca="Ford";
        carros[4].modelo="Edge";
        carros[4].cor="Branca";

        carros[0].info();

        for(int i=0; i<carros.Length;i++){
            carros[i].info();
        }

    }
}