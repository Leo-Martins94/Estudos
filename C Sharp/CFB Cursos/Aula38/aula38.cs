using System;

class Base{
    public Base(){
        Console.WriteLine("Construtor classe base");
    }

    virtual public void info(){
        Console.WriteLine("Base");
    }
}

class Derivada:Base{
    public Derivada(){
        Console.WriteLine("Construtor da classe Derivada");
    }

    override public void info(){
        Console.WriteLine("Derivada");
    }
}

class Derivada1:Derivada{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada 1");
    }

    public override void info(){
        Console.WriteLine("Derivada1");
    }
}

class Aula38{
    static void Main(){
        Base Ref;
        Derivada derivada = new Derivada();
        Derivada1 derivada1 = new Derivada1();

        Ref=derivada;

        Ref.info();
    }
}