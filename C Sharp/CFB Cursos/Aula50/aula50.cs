using System;
delegate int Op(int n1, int n2);
class Mat{
    public static int soma(int n1, int n2){
        return n1+n2;
    }
    public static int dobro(int n){
        return n*2;
    }
    public static int mult(int n1, int n2){
        return n1*n2;
    }
}
class Aula50{
    static void Main(){
        int res;

        Op d = new Op(Mat.soma);

        res=d(10,35);

        Console.WriteLine("Soma: {0}",res);

        d=new Op(Mat.mult);
        
        res=d(10,50);

        Console.WriteLine("Multiplicação: {0}",res);

    }
}