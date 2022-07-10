using System;
class Aula26{
    static void Main(){
        int dividen, divis,quoc,res;
        dividen=7;
        divis=2;
        quoc=divide(dividen,divis,out res);
        Console.WriteLine("{0}/{1}:quociente={2} e resto={3}",dividen,divis,quoc,res);
    }

    static int divide(int dividendo, int divisor, out int resto){
        int quociente;
        quociente=dividendo/divisor;
        resto=dividendo%divisor;
        return quociente;

    }

}