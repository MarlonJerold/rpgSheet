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

        // Membro de uma classe que fornece um mecanismo flexível 
        // para ler, gravar ou calcular o valor de um dado em particular.
        // As propriedades permitem que uma classe exponha de uma maneira pública a obtenção e definição destes valores.
        public int Teste{
            get{return _anthropology;}
            set{if (value != 0 ){
                    _anthropology = value;
                } 
            }
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

/*
 Struct s são usadas para criar estruturas de dados cujas instâncias (os objetos)
 sejam pequenas (no máximo 16 bytes), sejam imutáveis, representem um valor único, ou seja, 
 que não contenha diversas características, e não precise ser encapsulado (boxing) em objetos por referência com frequência
*/