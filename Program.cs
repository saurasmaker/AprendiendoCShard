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

            //Operaciones y cosas:
            var a = 1;
            var b = 2;
            var c = a + b;
            //Esto es una suma, usando var te quitas el problema de la compatibilidad de datos entre int, float y esas mierdas.
            c = a - b;
            c = a / b;
            c = a * b;
            c = a % b; //Esto es el módulo, es decir, el resto de la división entera.
            //Se puede hacer lo tipico del i++//i--//++i//--i que es igual que en C y todos sabemos para que sirve.
            //Hay una variación que es poniendo i+=X, donde x es un valor, y cambia en ese valor, válido para las combinaciones previas.





        }
    }
}
