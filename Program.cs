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

            /*
             Existen diferentes funciones que son útiles:
            ->Valor Absoluto:   Math.Abs(a);    Calcula el valor absoluto de un numero.
            ->Redondeo clásico  Math.Round(a);  Redondea para arriba si el decimal es mayor que 5 y para abajo si es menor, vamos igual que en los examenes del insti.
            ->Redondeo al alza  Math.Ceiling(a);Redondea siempre para arriba.
            ->Redondeo a la bajaMath.Floor(a);  Redondea siempre para abajo.
            ->Numero grande     Math.Max(a,b);  Compara dos numeros y muestra el mas alto.
            ->Numero peque      Math.Min(a,b);  Compara dos numeros y muestra el mas bajo.
            ->Potencia          Math.Pow(a,X);  Eleva el numero a la potencia X.
            ->Raiz cuadrada     Math.Sqrt(a);   Hace la raiz cuadrada del numero.
             */

            //Numero Aleatorio
            Random numero = new Random();

            var aleatorio = numero.Next(1,11); //Genera un numero al azar entre 1 y 10, excluye el ultimo numero.

            //Condicionales y Bucles:
            //Operadores relacionales [< > <= >= == !=] [Menor, Mayor, Menor o Igual, Mayor o Igual, Igual, Distinto]
            //Operadores lógicos [&& || ^ !] [And, Or, Or exclusivo, Not]

            //IF
            /*
            if (){
            }
            else if(){
            }
            else(){
            }
            */

            //Operador Ternario
            //bool a = (Condicion) ? true : false; Si se cumple dice true y si no dice false, sencillo, facil, logico.

            //Switch
            /*
            switch(opcion){
                case "cadena"/numero:
                    *Pasan cosas here*
                    break;
                default:
                    Cosas
                    break;
            }                                   Es igual que el de C, no tiene mayor complicacion. (Por algo el lenguaje se llama C#)
            */

            //WHILE
            /*
             While(){
             pasan cosas
             }
             */

            //DO WHILE
            /*
             do{
            }while (condicion); LA CONDICION DEBE SER TRUE.
            */

            //FOR
            /*
             for(int i=0; condicion; i++){
            }
             ES UN FOR DE TODA LA VIDA
             
             */

            




        }
    }
}
