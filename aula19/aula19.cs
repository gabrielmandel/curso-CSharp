using System;

class aula19{

    static void Main(){
        int[] num = new int[3];

        for (int i = 0; i < num.Length; i++)
        {
            num[i] = i;
            Console.WriteLine("posição: {0} - Num: {1}",i,num[i]);
        }
    }
}