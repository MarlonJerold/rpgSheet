 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks;
 namespace RPG
 {
     public class  Player : CharacterSheet
    {
        public Player(int _Anthropology) : base(_Anthropology)
        {
        }

        public string name {get; set;}
        public int age {get; set;}
        public string academicFormation {get; set;}
        public string birthplace {get;set;}


    }
     
 }