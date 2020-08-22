using System;
using AprendiendoCSharp.Pokemon;
using System.Windows;

namespace AprendiendoCSharp
{     

    class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OPokemon pokemon = Pokedex.LoadPokemonFromXML("2");
            pokemon.Show();

            return;
        }
    }
}
