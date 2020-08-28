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
        }
    }
}
