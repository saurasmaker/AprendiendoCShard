using System;
using System.Collections.Generic;
using System.Text;

namespace AprendiendoCShard
{
    class T2
    {

        public int lados, vertices, longitudHipotenusa;
        public T2 t2;

        //Método Constructor. Los constructores tienen como nombre el nombre de la clase y no tienen tipo de variable a devolver.
        public T2()
        { 
        
        }

        //Contructor sobrecargado. Ahora puedes declarar un T2 con dos tipos de contructores distintos
        public T2(int lados, int vertices, int longitudHipotenusa)
        {
            this.lados = lados;
            this.vertices = vertices;
            this.longitudHipotenusa = longitudHipotenusa;
        }

        
        public int SumaLadoVertice() {
            return (this.lados + this.vertices); //this.lados significa que "lados" pertenece a la variable que hemos declarado arriba y no a cualquier otra variable declarada en otro lugar.
        }

        public static void MiNombreEs()
        {
            Console.WriteLine("Mi nombre es T2");

            return;
        }

    }
}
