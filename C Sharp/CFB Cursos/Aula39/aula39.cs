/*classes abstratas dão referencia para outras classes, e em metodos abstratos não implementaamos o comportamento,
 o prototipo que vai servir como referencia. Uma classe abstrata pode conter metodos abstratos e não abstratos,
se ela possuir metodos não abstratos eles conterão a implementação.
Não se pode instanciar objetos de classes abstratas. */
using System;

abstract class Veiculo{//Classe abstrata.
    protected int velMax;
    protected int velAtual;
    protected bool ligado;

    public Veiculo(){
        ligado=false;
        velAtual=0;
    }
    public void setLigado(bool ligado){
        this.ligado=ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }
    abstract public void aceleracao(int mult);

}

class Carro:Veiculo{
    public Carro(){
        velMax=120;

    }
     override public void aceleracao(int mult){
        velAtual+=10*mult;
    }
}


class Aula36{
    static void Main(){
        Carro carro1 = new Carro();

        carro1.aceleracao(1);
        Console.WriteLine(carro1.getVelAtual());
        carro1.aceleracao(-1);
        Console.WriteLine(carro1.getVelAtual());
    }
}