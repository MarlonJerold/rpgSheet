using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using System;
using static System.Console;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           CharacterSheet carac = new CharacterSheet(0,0,0,0,0,0,0,0,0,0,0,0,0);
           System.Console.WriteLine(carac.GetAnthropology());
           carac.SetAnthropology(21);
           System.Console.WriteLine(carac.GetAnthropology()); 
           carac.Teste = 12;
           System.Console.WriteLine($"Valor passado pela propeties = {carac.Teste}");
           System.Console.WriteLine("Digite q quantidade de Caixas"); 
           int quantidade = int.Parse(Console.ReadLine()); 


           double[] vetor = new double[quantidade];
    
           for (int i = 0; i < quantidade; i++)
           {
                System.Console.WriteLine($"valor da caixa {i}");
                vetor[i] = int.Parse(Console.ReadLine()); 
           }
           double s = 0.00;
           for (int i = 0; i < quantidade; i++)
           {
                s += vetor[i];
           }
           double media = s / quantidade;
        System.Console.WriteLine($"a media é {media}");

        Produto[] bet = new Produto[quantidade];
        for(int i = 0; i < quantidade; i++){
            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            bet[i] = new Produto{ Name = name, Preco = price };   
        }

        double soma = 0.00;
        for(int i = 0 ; i < quantidade; i++)
        {
            soma += bet[i].Preco;
        }

        double mediia = soma / quantidade;
        System.Console.WriteLine($"A média dos valores é {mediia}");
*/
        Quartos[] aluguel = new Quartos[3];

        for(int i = 0; i < 3; i++ ){
            string nome = Console.ReadLine();
            string email = Console.ReadLine();
            int lugar = int.Parse(Console.ReadLine());
            aluguel[lugar] = new Quartos{Nome = nome, Email = email};
        }

        for(int i = 0; i < 3; i++){
          
            System.Console.WriteLine(i + ": " + aluguel[i]);
            
        }
        
       
 
    }
            class Produto
        {
            public string Name {get; set;}
            public double Preco{get;set;}

        }
               
        class Quartos{
            public string Nome {get;set;}
            public string Email{get;set;}
            
            public override string ToString() {
            return Nome + ", " + Email;
                }   

            public int Posi{get; set;}     
        }       
    }
}
