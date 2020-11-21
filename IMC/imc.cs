using System;

namespace calculadoraIMC{

    class teste{
        public grau(){
            if(imc < 18.5){
                res = "Abaixo do peso!";
            } else if(imc >= 18.5 && imc < 25){
                res = "Peso normal!";
            } else if(imc >= 25 && imc < 30 ){
                res = "Sobrepeso!";
            } else if(imc >= 30 && imc < 35){
                res = "Obesidade I";
            } else if(imc >= 35 && imc < 40){
                res = "Obesidade II";
            } else{
                res = "Obesidade III";
            }
        }
    }
    class IMC {
        static void Main(){
            // IMC == PESO(kg) / ALTURA ^ 2
            float massa, altura, imc;
            string res;
            
            Console.Write("Digite seu peso(kg): ");
            massa = float.Parse(Console.ReadLine());
            Console.Write("Digite sua altura(m): ");
            altura = float.Parse(Console.ReadLine());

            imc = massa / (altura * altura);
            if(imc < 18.5){
                res = "Abaixo do peso!";
            } else if(imc >= 18.5 && imc < 25){
                res = "Peso normal!";
            } else if(imc >= 25 && imc < 30 ){
                res = "Sobrepeso!";
            } else if(imc >= 30 && imc < 35){
                res = "Obesidade I";
            } else if(imc >= 35 && imc < 40){
                res = "Obesidade II";
            } else{
                res = "Obesidade III";
            }

            Console.WriteLine("Seu IMC é: {0} - {1}",imc,res);
        
            
        }
    }
}