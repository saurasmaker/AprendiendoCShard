using System;
using System.Collections.Generic;
using System.Text;

namespace AprendiendoCShard
{
    class Po3
    {
        public int lado;

        public Po3() { }

        public Po3(int lado) {
            this.lado = lado;
        }

        int DobleLado() {
            return (this.lado * 2);
        }

        static void ChorroPalabras()
        {
            Console.WriteLine("Esto es un chorro de palabras que uso para definir una estatic porque tengo que practicar, pero no confundir con el Puñal de Statikk que eso hace cosas y esto no\nComprendes?");
        }
    }
}
