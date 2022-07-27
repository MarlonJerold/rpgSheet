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
          CharacterSheet characterSheet = new CharacterSheet();            
          Calculator calculator = new Calculator();
          //Player teste = new Player();
        
         // teste.value = calculator.addition(teste.valor1, teste.valor2);

        // WriteLine(teste.value);
            
            calculator.anthropology = 10;
            decimal value = calculator.addition(calculator.anthropology, 10);
            Write(value);
        }
    }
}
