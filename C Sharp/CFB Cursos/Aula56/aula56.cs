using System;
using System.Collections.Generic;
class Aula56{
    static void Main(){
        
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");//adicionar no começo
        transp.AddFirst("aviao");
        transp.AddFirst("Navio");
        transp.AddFirst("Moto");

        transp.AddLast("Bicicleta");//adicionar no fim

        LinkedListNode<string> no;
        no=transp.FindLast("Navio").Next;//aponta para o proximo valor
        transp.AddAfter(no, "patins");//adicionar apos

        LinkedListNode<string> no2;
        no2=transp.FindLast("patins").Value;//aponta para o referido
        transp.AddBefore(no2, "Skate");//adicionar antes

        //transp.Clear();//metodo usado para limpar toda a lista

        if(transp.Find("Carro")==null){
            Console.WriteLine("Não encontrado");
        }else{
            Console.WriteLine("O elemento foi encontrado");
        }
        
        transp.Remove("patins");

        transp.RemoveFirst();//Remove o primiero
        transp.RemoveLast();//Remove o ultimo

        foreach (string t in transp){
            Console.WriteLine("Tranporte: {0}",t);
        }

    }
}