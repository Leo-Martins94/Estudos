using System;
class Aula06{
    static void Main(){
        int n1,n2,n3;
        n1=10; n2=20; n3=30;
        Console.WriteLine("n1=\t{0},\n n2={1}, \nn3={2}",n1,n2,n3);
        double valorCompra=5.50;
        double valorVenda;
        double lucro=0.1;
        string produto="pastel";
        valorVenda=valorCompra+(valorCompra*lucro);

        Console.WriteLine("Produto......:{0,15}",produto);
        Console.WriteLine("Valor de C...:{0,15:c}",valorCompra);
        Console.WriteLine("Lucro.........{0,15:p}",lucro);
        Console.WriteLine("Valor de V...:{0,15:c}",valorVenda);
    }
}