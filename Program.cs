using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using AprendiendoCShard.Pokemon;

namespace AprendiendoCShard
{     
    class Program
    {
        static void Main(string[] args)
        {
            OPokemon pokemon = Pokedex.LoadPokemonFromXML("0");
            Console.WriteLine(Directory.GetCurrentDirectory() + "/Saves/pokedex.xml");
            return;
        }
    }
}
