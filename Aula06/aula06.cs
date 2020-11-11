using System;

class Aula06{

    static void Main(){
        // int n1, n2, n3;
        // n1 = 10;
        // n2 = 20;
        // n3 = 30;

        // Console.WriteLine("\n n1=\t{0}\n n2=\t{1} \n n3=\t{2}",n1,n2,n3);

        double valorCompra = 5.5;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto.....:{0,15}",produto);
        Console.WriteLine("Val.Compra..:{0,15:c}",valorCompra);
        Console.WriteLine("Lucro.......:{0,15:p}",lucro);
        Console.WriteLine("Val.Vend....:{0,15:c}",valorVenda);
    }
}