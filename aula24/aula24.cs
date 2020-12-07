using System;

class aula24
{
    static void Main()
    {
        int v1,v2,r;
        v1 = Int32.Parse(Console.ReadLine());
        v2 = Convert.ToInt32(Console.ReadLine());
        soma(v1,v2);
        batata();
        r = soma2(v1,v2);
        Console.WriteLine("Retorno Soma de {0} e {1} é: {2}",v1,v2,r);
    }

    static void batata()
    {
        Console.WriteLine("Método void batata");
    }
    static void soma(int n1, int n2)
    {
        int res = n1 + n2;
        Console.WriteLine("A Soma de {0} e {1} é: {2}",n1,n2,res);
    }
    static int soma2(int n1, int n2)
    {
        int res = n1 + n2;
        return res;
    }
}