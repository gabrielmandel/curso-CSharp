using System;  

class Aula16{

    static void Main(){

        int tempo = 0;
        char escolha;

        inicio:

        Console.Clear();

        Console.WriteLine("Porto Alegre/RS à Laguna/SC");
        Console.WriteLine("Escolha o Transporte: [a]Avião | [c]Carro | [o]Ônibus  ");
        escolha = char.Parse(Console.ReadLine());
        
        switch(escolha){
            case 'a':
            case 'A':
                tempo = 50;
                break;
            case 'c':
            case 'C':
                tempo = 360;
                break;
            case 'o':
            case 'O':
                tempo = 480;
                break;
            default:
                tempo = -1;
                break;
        }
        if(tempo < 0){
            Console.WriteLine("Transporte inválido!");
        } else{
            Console.WriteLine("Para o transporte escolhdo o tempo é: {0} minutos!",tempo);
        }

        Console.Write("\nCalcular novamente?[s/n]: ");
        escolha = char.Parse(Console.ReadLine());

            if(escolha == 's' || escolha == 'S'){
                goto inicio;
            } else{
                Console.Clear();
                Console.WriteLine("Fim do programa.");
            }
    }        
}