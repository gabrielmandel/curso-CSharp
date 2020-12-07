using System;

class aula26
{
    static void Main()
    {
        int d1, divs, quoc, rest;
        d1 = 10;
        divs = 5;
        quoc = divide(d1,divs,out rest);

        Console.WriteLine("{0}/{1}: quociente = {2} e resto = {3}", d1,divs,quoc,rest);
    }

    static int divide(int dividendo, int divisor,out int resto)
    {
        int quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }
}