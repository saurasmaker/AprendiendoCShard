using System;
using System.Collections.Generic;
using System.Text;

namespace AprendiendoCShard.Pokemon
{
    class Pokemon
    {
        
        
        //Static Attributes
        public static int GivesHealthEvs = 0, GivesAttackEvs = 1, GivesEspAEvs = 2, GivesDefEvs = 3, GivesEspDEvs = 4, GivesVelEvs = 5;
        

        public static string[] StatNames = new string[]{"health", "attack", "specialAttack", "defense", "specialDefense", "velocity" };
        public static string[] TypeNames = new string[] { 
            "normal", "fighting", "flying", "poison", "ground", "rock", "bug", "ghost", "steel", "fire", "water",
            "grass", "electric", "psychic", "ice", "dragon", "dark", "fairy" 
        };
        
        
        
        //Attributes
        private string name, kind;
        private int healthPoints, attack, specialAttack, defense, specialDefense, velocity;
        private int experienceGives;

        private byte[] iVs; 

        private int level;

        bool shiny;

        private Pokemon prevolution, evolution;


        //Constructors
        public Pokemon()
        {
            iVs = new byte[6];
        }


        //Getters && Setters
        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }

        public byte[] IVs
        {
            get { return iVs; }
            set {
                for (byte i = 0; 0 < 5; ++i){
                    if (value[i] > 31)
                    {
                        Console.WriteLine("Not valid IVs {0} in position {1}", StatNames[i], i);
                        return;
                    }
                }

                iVs = value;

                return;
            }
        }
    }
}
