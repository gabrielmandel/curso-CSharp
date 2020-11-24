using System;

class aula20{

    static void Main(){
        int[] num = new int[3];

        int i = 0;
        while(i < num.Length)
        {
            Console.WriteLine(" Batata {0} - num: {1}",i,num[i]);
            num[i] = 0;
            i++;
        }
        Console.WriteLine("ACABOU AS BATATA");

        int i = num.Length-1;
        while(i > 0)
        {
            Console.WriteLine(" Batata {0} - num: {1}",i,num[i]);
            num[i] = 0;
            i++;
        }
        Console.WriteLine("ACABOU AS BATATA");
    }
    }
}