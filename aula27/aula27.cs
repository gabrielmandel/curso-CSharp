using System;

class aula27
{
    static void Main()
    {
        soma();
    }

    static void soma(params int[]n)
    {
        int res = 0;
        if(n.Length < 1)
        {
            Console.WriteLine("Não existem valores a serem somados");
        }
        if (n.Length < 2)
        {
            Console.WriteLine("Argumentos insuficientes para somar: {0}", n[0]);
        }
        else
        {
            for (int i = 0; i < n.Length; i++)
            {
                res += n[i];
                
            }
            Console.WriteLine("A soma dos valores é:  {0}",res);

        }
    }
}

