using System;

namespace calculadoraIMC{

    class Teste
    {
    }
    class IMC 
    {
        static string verificaGrauObesidade(double imc){

            if(imc < 18.5){
                return "Abaixo do peso!";
            }  

            if(imc >= 18.5 && imc < 25)
            {
                return "Peso normal!";
            } 

            if(imc >= 25 && imc < 30 )
            {
                return "Sobrepeso!";
            }  

            if(imc >= 30 && imc < 35)
            {
                return "Obesidade I";
            } 

            if(imc >= 35 && imc < 40)
            {
                return "Obesidade II";
            } 

            return "Obesidade III"; 
        }
        static void Main(){
            // IMC == PESO(kg) / ALTURA ^ 2
            float massa, altura, imc;    
            char continuar = 'S' ;
            char[,] cont = new char[2,2] {{'S','s'} , {'N','n'}};  
            string mensagem = "batata";
          do{  
                Console.Write("Digite seu peso(kg): ");
                massa = float.Parse(Console.ReadLine());
                Console.Write("Digite sua altura(m): ");
                altura = float.Parse(Console.ReadLine());

                imc = massa / (altura * altura);
            
                string resultado = verificaGrauObesidade(imc);
                Console.WriteLine("Seu IMC é: {0} - {1}",imc,resultado);

                Console.WriteLine("Deseja Continuar? [S/N]");
                continuar = Char.Parse(Console.ReadLine());

            } while(continuar == 'S'  || continuar == 's');

            foreach(char c in cont){
                if ( continuar == c){
                     mensagem =  "Obrigado por usar nosso sistema!";
                    break;
                }
                else{
                     mensagem = "Opção Inválida, encerrando o programa...";
                }
            }

            Console.WriteLine(mensagem);
        } 
    }
}