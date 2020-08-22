using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using AprendiendoCSharp.Pokemon;

namespace AprendiendoCSharp
{     
    class Program
    {
        static void Main(string[] args)
        {
            OPokemon pokemon = Pokedex.LoadPokemonFromXML("2");
            pokemon.Show();

            return;
        }
    }
}
