using System;
class Aula03
{
    static void Main(){
        byte n1=10; // bite armazena apenas de 0 a 255 
        int num=0;
        char letra='l';//armazena apenas um caracter
        float valor=5.3f;//deve passar o f para que a variavél fique no formato float
        string nome="Leo";

        var aux = nome;//ao utilizar o operador var podemos não tipar a variavel, que será atribuido na compilação da atribuição

        int num1,num2,res;
        num1=10;
        num2=2;
        res=num1*num2;

        Console.WriteLine("Valor da variável: "+aux);
        Console.WriteLine(num1+ "X"+ num2 + "= " + res);

    }
}