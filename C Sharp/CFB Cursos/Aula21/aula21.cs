using System;
class Aula21{
    static void Main(){

        string senha="123";
        string senhauser;
        int tentativas=0;

        do{
            Console.Clear();
            Console.Write("Digite sua senha: ");
            senhauser=Console.ReadLine();
            tentativas++;
        }while(senha!=senhauser);

        Console.WriteLine("Senha Corretas, Tentativas:{0}",tentativas);

    }
}