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
        string name = "guest_user";
        string myName = "gest_user";

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
            Socket send = (Socket)o;
            byte[] infoSend = new byte[255];
            string a;
            int endIndex;

            Console.WriteLine("Introduce tu nombre: ");
            string myName = Console.ReadLine();

            while ((a = " -" + myName + ": " + Console.ReadLine()) != null)
            {
                infoSend = Encoding.ASCII.GetBytes(a);
                send.Send(infoSend, 0, infoSend.Length, 0);
                //Console.WriteLine("Enviar: " + Encoding.Default.GetString(byRec)); //Mostramos lo recibido
            }

            return;
        }

        private static void ReceiveMsg(object o)
        {
            Socket receive = (Socket) o;
            byte[] byRec = new byte[255];
            int a;
            string msg;
            int endIndex;

            while ((a = receive.Receive(byRec, 0, byRec.Length, 0)) != 0)
            {
                Array.Resize(ref byRec, a);
                msg = Encoding.ASCII.GetString(byRec);
                endIndex = msg.IndexOf('\0');
                if (endIndex > 0)
                    msg = msg.Substring(0,endIndex);

                Console.WriteLine(msg); //Mostramos lo recibido
            }

            return;
        }
    }

    
}
