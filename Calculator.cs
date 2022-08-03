using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG
{
    public class Calculator : CharacterSheet
    {
        public Calculator(int _Anthropology) : base(_Anthropology)
        {
        }

        public decimal addition(decimal a , decimal b )
        {
            return a + b;
        }
        public decimal subtraction(decimal a , decimal b )
        {
            return a - b;
        }
    }
}