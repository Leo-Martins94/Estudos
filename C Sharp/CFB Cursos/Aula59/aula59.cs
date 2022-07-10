using System;
using System.Collections.Generic;

class Aula59{
    static void Main(){

        /*
        Adicionando uma fila com um array já existente
        string[] vs={"Carro","Moto","Navio","Aviao"};
        Queue<string> veiculos = new Queue<string>(v);
        */

        Queue<string> equipes = new Queue<string>();

        equipes.Enqueue("Mercedes");//Adiciona no final da fila
        equipes.Enqueue("Red Bull");
        equipes.Enqueue("Ferrari");
        equipes.Enqueue("McLarem");

        string e = "Red Bull";
        if(equipes.Contains(e)){
            Console.WriteLine("A equeipe " + e + " foi encontrada");
        }else{
            Console.WriteLine("Equipe " + e + " não foi encontrada");
        }

        //equipes.Clear();

        Console.WriteLine("Primeira equipe " + equipes.Dequeue());
        Console.WriteLine("Equipes na fila: " + equipes.Peek());//retorna o primeiro elemento mas não remove
        foreach(string eq in equipes){
            Console.WriteLine("Equipe na fila"+ eq);
        }
        Console.WriteLine("Tamanho da Fila 'Queue':  " + equipes.Count);

        while(equipes.Count > 0){
            Console.WriteLine(equipes.Dequeue());
        }

        Console.WriteLine("Tamanha da fila: " + equipes.Count);
    }
}