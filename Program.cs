using System;

namespace AprendiendoCShard
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Entradas de Usuario:*/
            // Mostrar por pantalla
            /* Console.WriteLine("Mostrar cosas"); //es como el printf

            //Recibir datos de teclado
            string nombre = Console.ReadLine(); //esto es el scanf, string es el tipo de variable y nombre es evidente lo que es.

            Console.WriteLine(nombre); //de esta forma mostramos por pantalla el valor de nombre, que es una string (un char[] vamos).*/

            //Ejemplo de uso:
            Console.WriteLine("Nombre?");
            string introducir = Console.ReadLine();
            Console.WriteLine("Hola " + introducir);

            //Tipos de datos:
            /*
             Booleanos      -> bool nombre = true/false;
             Caracteres     -> char nombre = 'A';
             Enteros        -> int nombre = 2;
             Largos         -> long nombre = 22222222;
             Flotantes      -> float nombre = 1.1f;
             Dobles         -> double nombre = 10.123132456246;
             Dinamico       -> dynamic nombre = cualquier cosa, puede cambiar sobre la marcha pero solo sirve para cosas en segundo plano, no para mostrarse ni nada.
             Variable       -> var nombre = cualquier cosa, genera una variable que corresponde al tipo de dato introducido, no puede variar sobre la marcha.

             Para saber que tipo de dato es una variable se puede usar esto:
             Console.WriteLine(variable.GetTypeCode());
             De esta forma nos dirá por pantalla el tipo de dato pero no el dato en si mismo.

             */



        }
    }
}
