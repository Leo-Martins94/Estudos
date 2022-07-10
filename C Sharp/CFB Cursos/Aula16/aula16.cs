using System;
class Aula16{
    static void Main(){
      int tempo=0;
      char escolha,escolhaL;

      inicio:

      Console.Clear();
      
      Console.WriteLine("Digite para [a]Avião, [c]Carro, [o]Onibûs");
      Console.Write("Por gentileza informe o metódo de viagem:");
      escolha=char.Parse(Console.ReadLine());
      escolhaL=char.ToLower(escolha);

      switch (escolhaL){
          case 'a':
            tempo=50;
            break;
          case 'c':
            tempo=180;
            break;
          case 'o':
            tempo=480;
            break;
          default:
            tempo=-1;
            break;  
      }

        if(tempo<0){
            Console.WriteLine("Por gentileza informe um transporte valido.");
        }else{
            Console.WriteLine("O tempo de viagem será de {0} minutos.",tempo);
        }

        Console.Write("Deseja calcular outro transporte?[s/n]");
        escolha=char.Parse(Console.ReadLine());
        escolhaL=char.ToLower(escolha);

        if (escolhaL=='s'){
            goto inicio;
        }else{
            Console.Clear();
            Console.WriteLine("Fim do programa...");
        }

    }
}