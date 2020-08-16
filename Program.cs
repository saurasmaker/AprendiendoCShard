using System;

namespace AprendiendoCShard
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guardamos en memoria un T2.");

            
            T2 triangulo2 = new T2(); //Guardamos en memoria un objeto T2
            triangulo2.lados = 3;
            triangulo2.vertices = 3;
            Console.WriteLine(triangulo2.SumaLadoVertice());

        }
    }
}
