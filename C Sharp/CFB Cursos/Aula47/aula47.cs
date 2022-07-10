using System;
class Calc{

    public int soma(int n1, int n2){
        return n1+n2;
    }
    public int soma(params int[]n){
        int s=0;
        for(int i=0; i<n1.Length;i++){
            s+=n[i];
        }
        return s;
    }
    public double soma(params double[]n){
        double s=0;
        for(int i=0; i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }

}
class Aula47{
    static void Main(){
        int res;

        Calc calc = new Calc();

        res = calc.soma(10,8,5);
        var resdoub = calc.soma(10.5,8.3,9.7);

        Console.WriteLine(res);
        Console.WriteLine(resdoub);

    }
}