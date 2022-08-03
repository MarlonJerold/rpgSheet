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

        public CharacterSheet(int Anthropology, decimal FireArms, decimal Archeology, decimal Keychain, decimal Science, decimal ElectricalConcert, decimal Mechanical, decimal Meet, decimal ToListen, decimal Dodge, decimal Story, decimal Fight, decimal Medicine){
           this._anthropology = Anthropology;
           this._fireArms = FireArms;
           this._archeology = Archeology;
           this._keychain = Keychain;
           this._science = Science;
           this._electricalConcert = ElectricalConcert;
           this._mechanical = Mechanical;
           this._meet = Meet;
           this._toListen = ToListen;
           this._dodge = Dodge;
           this._story = Story;
           this._fight = Fight;
           this._medicine = Medicine;
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