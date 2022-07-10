using System;
using System.Collections.Generic;
class Aula58{
    static void Main(){

        List<string> carros = new List<string>();

        carros.Add("Genisis");
        carros.Add("Mustang");
        carros.Add("Edge");
        carros.Add("Jetta");
        carros.Add("Genisis");

        carros.Insert(1,"Civic");
        
        if(carros.Remove("Jetta")){
            Console.WriteLine("Jetta removido com sucesso");
        }else{
            Console.WriteLine("Carro não removido por favor tente novamente.");
        }

        int Ppos = carros.IndexOf("Genisis");
        int pos = carros.LastIndexOf("Genisis");


        foreach(string car in carros){
            Console.WriteLine("Carro: {0}", car);
        }
        
        Console.WriteLine("O primeiro Genisis está na posição {0}", Ppos);
        Console.WriteLine("O ulto mo Genisis está na posição {0}",pos);

        carros.Reverse();

        foreach(string Rcar in carros){
            Console.WriteLine("Carro reverso: {0}", Rcar);
        }

        carros.Sort();

        foreach(string Ocar in carros){
            Console.WriteLine("Carro ordadenado: {0}",Ocar);
        }

        int tamanho = carros.Count;
        Console.WriteLine("O tamanho da lista de carros é {0}", tamanho);

        carros.Capacity = 20;
        
        int capacidade = carros.Capacity;

        Console.WriteLine("A capacidade da lista de carros é {0}", capacidade);

    }
}