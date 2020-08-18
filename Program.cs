using System;
using System.Collections.Generic;

namespace AprendiendoCShard
{
    struct Estructura //Aqui se define una estructura básica
    {
        public int Entero;
        public string Cadena;
        public float Decimal; //Es SUPER IMPORTANTE que los atributos sean públicos si queremos acceder a ellos y modificarlos

        //Constructor de la estructura
        public Estructura(int Entero, string Cadena, float Decimal)
        {
            this.Entero = Entero;
            this.Cadena = Cadena;
            this.Decimal = Decimal;
        }

        //Método propio de la estructura
        public void Info() //VOID significa que no devuelve nada al llamar al método
        {
            Console.WriteLine("Entero:" + this.Entero);
            Console.WriteLine("Cadena:" + this.Cadena);
            Console.WriteLine("Decimal:" + this.Decimal); //No hace falta definir con el this. pero queda mas claro.
        }
    
    }
    //ESTRUCTURA para guardar un animal
    struct Animal
    {
        public string nombre;

        public Animal(string nombre)
        {
            this.nombre = nombre;
        }
        public void info()
        {
            Console.WriteLine("Nombre del animal ->" + nombre);
        }
    }
    //CLASE para guardar un animal
    class claseAnimal
    {
        public string nombre;

        public claseAnimal(string nombre)
        {
            this.nombre = nombre;
        }
        public void info()
        {
            Console.WriteLine("Nombre del animal ->" + nombre);
        }
    }
    
    
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

            var aleatorio = numero.Next(1, 11); //Genera un numero al azar entre 1 y 10, excluye el ultimo numero.

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

            //FOREACH
            /*
             foreach(char caracter in cadena){
                PASAN COSAS;
            }
             */

            //LISTAS
            //Arriba debe ir declarado using System.Collections.Generic
            List<int> listaDeNumeros = new List<int>();

            /*listaDeNumeros.Add(X)*///Esto sirve para añadir al final un numero, pero la lista puede ser de cualquier cosa, no solo numeros.
            // listaDeNumeros.AddRange(Array);
            // Se puede crear una lista a raiz de un array: List<int> listaDeNumeros = new List<int>(array);
            //Tambien se puede: List<int> listaDeNumeros = new List<int>(new int[] {1, 2, 3, 4}); de esta forma defines que quieres un array pero no defines el array como tal

            //listaDeNumeros.Insert(0, 14); esta funcion inserta el 14 en la posicion 0 de la lista SUSTITUYENDO lo que hubiera ahi.
            //listaDeNumeros.Remove(14); esta funcion busca los 14 de la lista y los borra para siempre.
            //listaDeNumeros.RemoveAt(0); esta funcion busca la posicion 0 de la lista y la borra para siempre.

            //Estructuras
            /* 
             Las estructuras se definen fuera del Main (como siempre), con la sintaxis struct nombre{COSAS}
                Se crea una estructura así -> [Nombre de la Estructura definida] [Nombre de la variable] = new [Nombre de la Estructura definida]*/
            Estructura prueba = new Estructura();//Ejemplo de creacion de una Estructura definida arriba.
            prueba.Entero = 0;//Se accede a sus atributos poniendo un puntito porque son PUBLICOS.
            //Las Estructuras tienen un CONSTRUCTOR de ESTRUCTURAS que se define (opcionalmente) dentro de la propia estructura
            Estructura prueba2 = new Estructura(12, "Segunda", 1.2f);
            //APARTE las estructuras pueden tener métodos internos propios que no son el constructor.
            prueba2.Info();//Llamamos al método.

            Estructura[] SuperEstructura =
            {
                new Estructura(1, "a", 1.0f),
                new Estructura(13, "f", 1.2f),
                new Estructura(56, "b", 2.3f),
            }; //Array de Estructuras

            List<Estructura> datos = new List<Estructura>(SuperEstructura); //Con esto creamos una lista a partir de un array de estructuras

            foreach(Estructura dato in datos)
            {
                dato.Info(); //Con este bucle recorremos la lista entera.
            }
            //CLASES
            //Arriba esta guardada la estructura de un animal.
            Animal sPerro = new Animal("Perro");
            Animal sPerroCopia = sPerro;

            sPerro.nombre = "Gato";
            
            sPerro.info();
            sPerroCopia.info();
            //Ejemplo de Estructuras, ahora se usa lo mismo con las clases para comprobar que no son objetos independientes.
            claseAnimal cPerro = new claseAnimal("Perro");
            claseAnimal cPerroCopia = cPerro;

            cPerro.nombre = "Gato";

            cPerro.info();
            cPerroCopia.info();//La diferencia entre las estructuras y las clases es que las estructuras son valores staticas mientras que las clases hacen referencia en memoria y heredan de otras, todos los cambios.

        }
    }
}
