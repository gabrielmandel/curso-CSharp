using System;

class Aula08{

    static void Main(){

        int v1,v2,soma;
        string nome;

        // Console.WriteLine("Digite seu nome: ");
        // nome = Console.ReadLine();
        // Console.WriteLine("Seu nome é: {0}",nome);
        Console.WriteLine("Digite o primeiro numero: ");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segu;ndo numero: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        soma = v1 + v2;
         Console.WriteLine("A soma de {0} mais {1} é igual a: {2}",v1,v2,soma);
         
    }
}