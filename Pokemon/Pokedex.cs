using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace AprendiendoCShard.Pokemon
{
    class Pokedex
    {

        private List<Pokemon> pokemons;

        public void Load()
        {
            XmlDocument xDoc = new XmlDocument();

            try
            {
                xDoc.Load("c:/personas.xml");

                XmlNodeList nodesPersonas = xDoc.GetElementsByTagName("personas");
                XmlNodeList xLista = ((XmlElement)nodesPersonas[0]).GetElementsByTagName("nombre");

                foreach (XmlElement nodo in xLista)
                {
                    string xEdad = nodo.GetAttribute("edad");
                    string xNombre = nodo.InnerText;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Can not Load Pokedex.");
            }
            

            return;
        }


        public void Save()
        {


        }

    }
}
