using System;
using System.Collections.Generic;
class Aula55{
    static void Main(){

       Dictionary<int,string> veiculos = new Dictionary<int, string>();

       veiculos.Add(10,"Carros");
       veiculos.Add(5,"Aviao");
       veiculos.Add(0,"Navio");
       veiculos.Add(20,"Moto");
       veiculos.Add(15,"Bicicleta");

       int chave=20; 
       string valor="patins";

       Console.WriteLine("Tamanho do Dictionary: {0}",veiculos.Count);
       if(veiculos.ContainsKey(chave)){
           Console.WriteLine(" A chave {0} está na coleção",chave);
       }else{
           Console.WriteLine("A chave {0} não está na coleção",chave);
       }

       veiculos[15]="patins"; 

       if(veiculos.ContainsValue(valor)){
           Console.WriteLine("O valor {0} está na coleção",valor);
       }else{
           Console.WriteLine("O chave {0} não está na coleção",valor);
       }

        veiculos.Remove(20);

        Dictionary<int,string>.KeyCollection key=veiculos.Keys;

        foreach(int k in key){
            Console.WriteLine(k);
        }

        foreach(KeyValuePair<int,string> v in veiculos){
            Console.WriteLine(v.Value);
        }

       veiculos.Clear();
       Console.WriteLine("Tamanho do Dictionary: {0}",veiculos.Count); 

    }

}