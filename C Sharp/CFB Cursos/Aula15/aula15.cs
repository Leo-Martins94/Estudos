using System;
class Aula15{
    static void Main(){

        int tempo=0;
        char escolha,escolhal;

        Console.WriteLine("Belo Horizonte/MG a Vitoria/ES");
        Console.WriteLine("Digite [a]Avião, [c]Carro, [o]ônibus");
        Console.Write("Escola o transporte: ");
        escolha=char.Parse(Console.ReadLine());
        escolhal=char.ToLower(escolha);
        switch (escolhal){
            case 'a':
                tempo=50;
                break;
            case 'c':
                tempo=480;
                break;
            case 'o':
                tempo=660;
                break;
            default:
                tempo=-1;
                break;
                      
        }

        if(tempo<0){
            Console.WriteLine("Transporte indefinido");
        }else{
            Console.WriteLine("Para o transporte escolhido o tempo de vigem é de {0} minutos.",tempo);
        }

    }
}