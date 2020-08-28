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

        public static void connection()
        {
            Socket firstSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint direction = new IPEndPoint(IPAddress.Parse("192.168.1.2"), 1414);


            firstSocket.Bind(direction);
            firstSocket.Listen(5);

            Console.WriteLine("Escuchando...");

            Socket listen = firstSocket.Accept();
            Console.WriteLine("Conectado con éxito");

            Thread receive = new Thread(ReceiveMsg);
            receive.Start(listen);

            Thread send = new Thread(SendMsg);
            send.Start(listen);


            /*firstSocket.Close();
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();*/
        }


        private static void SendMsg(object o)
        {
            Socket send = (Socket) o;           
            string msg;

            Console.WriteLine("Introduce tu nombre: ");
            string myName = Console.ReadLine();

            while (true)
            {
                byte[] byteMsg = new byte[1024];
                msg = " -" + myName + ": " + Console.ReadLine();
                byteMsg = Encoding.ASCII.GetBytes(msg);
                send.Send(byteMsg, 0, byteMsg.Length, 0);
            }
        }

        private static void ReceiveMsg(object o)
        {
            Socket receive = (Socket) o;
            
            int a;
            string msg;
            int endIndex;

            while (true)
            {
                byte[] buffer = new byte[1024];
                receive.Receive(buffer);
                msg = Encoding.ASCII.GetString(buffer);
                endIndex = msg.IndexOf('\0');
                if (endIndex > 0)
                    msg = msg.Substring(0, endIndex);

                Console.WriteLine(msg); //Mostramos lo recibido
            }
        }
    }

    
}
