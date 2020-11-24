using System;

class aula21{
    static void Main(){

        string senha = "123";
        string senhauser;
        int tentativas = 0;
        do{
            Console.Clear();
            Console.WriteLine("Digite a batata: ");
            senhauser = Console.ReadLine();
            tentativas++;
        } while( senha != senhauser);

        Console.WriteLine("Senha correta, tentativas: {0}",tentativas);
    }
}