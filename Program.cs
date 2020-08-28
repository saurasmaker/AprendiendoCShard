using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;


namespace AprendiendoCShard
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread HILO = new Thread(()=>GO("Cosita","Pasan"));
            HILO.Start();
            HILO.Join();
            Thread.Sleep(2000);
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine("x");
            }
        }

        static void Metodo(object o)
        {
            Console.WriteLine(o.ToString());
            for (int i= 0; i<1000; i++)
            {
                Console.WriteLine("y");
            }
        }

        static void GO(string s1, string s2)
        {
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
