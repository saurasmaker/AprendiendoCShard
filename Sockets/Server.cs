using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace AprendiendoCShard.Sockets
{
    class Server
    {

        public void conection()
        {
            Socket firstSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint direction = new IPEndPoint(IPAddress.Parse("localhost"), 1414);


            firstSocket.Bind(direction);
            firstSocket.Listen(5);

            Console.WriteLine("Escuchando...");

            Socket Listen = firstSocket.Accept();
            Console.WriteLine("Conectado con éxito");

            byte[] byRec = new byte[255];
            int a = Listen.Receive(byRec, 0, byRec.Length, 0);

            Array.Resize(ref byRec, a);
            Console.WriteLine("Cliente dice: "+ Encoding.Default.GetString(byRec)); //Mostramos lo recibido
            firstSocket.Close();
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
