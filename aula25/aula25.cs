using System;

class aula25
{
    static void Main()
    {
        int num = 10;
        dobrar(ref num);
        Console.WriteLine(num);
    }
    //passagem por referencia (alterao valor no mesmo espaço de memoria da variavel)
    static void dobrar(ref int valor)
    {
        valor *= 2;
    }

    //passagem por valor (cria outra variavel de mesmo valor na memoria não afetando a variavel original)
    static void dobrar2(int valor)
    {
        valor *= 2;
    }
}