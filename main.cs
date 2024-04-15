/* 
PUCMINAAS-CONTAGEM-DISCIPLINA-ATP
PROGRAMADOR: RAPHAEL DINIZ
DESCRIÇÃO: programa que leia o peso (em kg) e altura (em metros) e em seguida calcule o IMC e mostre qual a situação do adulto
ENTRADA: o peso (em kg) e altura (em metros)
SAÍDA: calcule o IMC e mostre qual a situação do adulto
*/










using System;

class Program
{
    public static void Main(string[] args)
    {

        //VARIAVEIS
        double peso, altura,case2;

        //processo
        Console.WriteLine("Digite o seu peso: ");
        peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a sua altura: ");
        altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        if(imc <= 20){
          case2 = 1; 
        }
        if(imc>=20 && imc<25){
          case2 = 2;
        
        if(imc>=25 && imc<30){
          case2 = 3;
        }
        if(imc>=30 && imc<34){
        case2 = 4;
        }
        if(imc>34){
        case2 = 5;
        }

          switch(case2){

              case 1:
                  Console.WriteLine("Abaixo do peso");
                  break;
          
              case 2:
                      Console.WriteLine("Peso normal");
                      break;
              case 3:
                       Console.WriteLine("Acima do Peso");
                       break;
              case 4:
                       Console.WriteLine("Obeso");
                       break;
              case 5:
                      Console.WriteLine("Muito obeso");
                      break;
              }
      



        
        

        }
    }
}