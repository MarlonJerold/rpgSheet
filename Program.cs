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
           CharacterSheet carac = new CharacterSheet(10);
           System.Console.WriteLine(carac.GetAnthropology());
           carac.SetAnthropology(21);
           System.Console.WriteLine(carac.GetAnthropology()); 
    
    }
               
    }
}
