using System;
using System.Collections.Generic;
using System.Text;

namespace AprendiendoCShard
{
    /*
     * Clase padre de todos los polígonos. Cualquier polígono (triangulo, cuadrado, pentagono, etc) deberá heredar
     * de esta clase.
     */
    class Poligono
    {
        //Atributos
        private int lados, vertices;

        //Getters & Setters
        public int Lados { get => lados; set => lados = value; }
        public int Vertices { get => vertices; set => vertices = value; }

        //Constructores
        public Poligono()
        {

        }

        public Poligono(int lados, int vertices)
        {
            this.lados = lados;
            this.vertices = vertices;
        }

        
        //Métodos
        public void MostrarLados()
        {
            Console.WriteLine("Tengo {0} lados.", this.lados);

            return;
        }

        public void MostrarVertices()
        {
            Console.WriteLine("Tengo {0} vertices.", this.vertices);

            return;
        }



        //Métodos Státicos
        public static void MostrarNombre()
        {

            Console.WriteLine("Soy un polígono.");

            return;
        }
    }
}
