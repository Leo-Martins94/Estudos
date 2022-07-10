using System;

class Base{
    public Base(){
        Console.WriteLine("Construtor Base");
    }
}

class Derivada:Base{
    public Derivada(){
        Console.WriteLine("Construtor da classe derivada");
    }
}

class Derivada1:Derivada{
    public Derivada1(){
        Console.WriteLine("Construtor da classe derivada 1");
    }
}

class Aula37{
    static void Main(){
        Derivada1 derivada1 = new Derivada1();
        
    }
}
