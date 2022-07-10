using System;
using System.Collections.Generic;
class Aula57{
    static void Main(){

        List<string> carros = new List<string>();
        List<string> carros2 = new List<string>(); 
        string[] carros3 =  new string[4];

        carros.Add("Genisis");
        carros.Add("Jetta");
        carros.Add("Mustang");
        carros.Add("Edge");

        carros2.AddRange(carros);

        if(carros.Contains("Genisis")){
            Console.WriteLine("Contem carro indicado");
        }else{
            Console.WriteLine("Não contem na lista");
        }

        carros.CopyTo(carros3, 0);

       // carros.Clear();

        foreach(string car in carros){
            Console.WriteLine("Carro: {0}",car);
        }

        Console.WriteLine("Imprimindo carros 2");

        foreach(string car2 in carros2){
            Console.WriteLine("Carros2: {0}",car2);
        }

        foreach(string car3 in carros3){
            Console.WriteLine("Carros3: {0}",car3);
        }

        string c="jetta";
        int pos=0;

        pos=carros.IndexOf(c);

        Console.WriteLine("Carro {0}, está na psossição{1}",c,pos);

    }
}