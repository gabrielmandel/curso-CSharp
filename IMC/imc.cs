using System;

namespace calculadoraIMC{

    class Teste
    {
    }
    class IMC 
    {
        static string grau(double c){
            string res;
            if(c < 18.5){
                res = "Abaixo do peso!";
            } else if(c >= 18.5 && c < 25){
                res = "Peso normal!";
            } else if(c >= 25 && c < 30 ){
                res = "Sobrepeso!";
            } else if(c >= 30 && c < 35){
                res = "Obesidade I";
            } else if(c >= 35 && c < 40){
                res = "Obesidade II";
            } else{
                res = "Obesidade III";
            }
            return res;
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
            
                string resultado = grau(imc);
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