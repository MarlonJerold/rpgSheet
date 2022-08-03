using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG
{  
    public class CharacterSheet
    {
 
        private int _anthropology {get; set;}
        private decimal _fireArms {get; set;}
        private decimal _archeology {get; set;}
        private decimal _keychain {get; set;}
        private decimal _science {get; set;}
        private decimal _electricalConcert {get; set;}
        private decimal _mechanical {get; set;}
        private decimal _meet {get; set;}
        private decimal _toListen{get; set;}
        private decimal _dodge {get; set;}
        private decimal _story {get;set;}
        private decimal _fight {get;set;}
        private decimal _medicine{get;set;}

        public CharacterSheet(int _Anthropology){
           this._anthropology = _Anthropology;
        }

        public decimal GetAnthropology()
        {
            return _anthropology;
        }

        public void SetAnthropology(int NovoNumber)
        {
          _anthropology = NovoNumber; 
        }
    }
}