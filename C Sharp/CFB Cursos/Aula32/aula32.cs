using System;
class Calculos{
    public int v1;
    public int v2;
    public Calculos(int v1, int v2){
        this.v1=v1;
        this.v2=v2;
    }

    public int Somar(){
        return v1+v2;
    }
}
class Aula32{
    static void Main(){
        Calculos calculos = new Calculos(20,30);

        Console.WriteLine(calculos.Somar());
    }
}