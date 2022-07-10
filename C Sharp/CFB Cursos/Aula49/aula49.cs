using System;

class Mat{
    public static double pi = 3.14;

    public static double dobro(double n){
        return n*2;
    }
}

class Aula49{
    static void Main(){

        double vpi=Mat.pi;
        var num=10;

        Console.WriteLine(vpi);
        Console.WriteLine(Mat.dobro(num));

    }
}