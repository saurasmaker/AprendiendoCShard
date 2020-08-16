using System;
using System.Collections.Generic;
using System.Text;

namespace AprendiendoCShard
{
    class T2
    {

        public int lados, vertices, longitudHipotenusa;

        //Método Constructor. Los constructores tienen como nombre el nombre de la clase y no tienen tipo de variable a devolver.
        public T2()
        {

        }
        public int SumaLadoVertice() {
            return (this.lados + this.vertices); //this.lados significa que "lados" pertenece a la variable que hemos declarado arriba y no a cualquier otra variable declarada en otro lugar.
        }

    }
}
