using System;
class Carro{
    private int velMax;

    public int vm{//exemplo de propriedade
        get{
            return velMax;
        }
        set{
            if(value < 0){
                velMax=0;
            } else if (value > 300){
                velMax=0;
            }else{
                velMax=value;
            }
        }
    }

    public Carro(){
        this.velMax=120;
    }

}
class Aula41{
    static void Main(){
        Carro c1= new Carro();
        c1.vm=250;
        Console.WriteLine("Velocidade: {0}",c1.vm);
    }
}