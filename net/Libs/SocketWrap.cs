using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    public class SocketWrap
    {

        Socket serverSocket;
        Socket clientSocket;

        int port;

        IPAddress ip;
        IPEndPoint ipe;



        public SocketWrap()
        {



        }


        public void CreateClientSocket(string strIP, string strPort)
        {

            ip = IPAddress.Parse(strIP);

            this.port = Convert.ToInt32(strPort);

            ipe = new IPEndPoint(ip, port);

            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            clientSocket.Connect(ipe);

        }



        public void CreateServerSocket(string strIP, string strPort)
        {
            //ip = IPAddress.Parse(strIP);

            this.port = Convert.ToInt32(strPort);

            ipe = new IPEndPoint(IPAddress.Any, port);

            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream ,ProtocolType.Tcp);

            serverSocket.Bind(ipe);

            serverSocket.Listen(1);


            clientSocket = serverSocket.Accept();
        }


        public void send2client(string msg)
        {
            byte[] sendData = new byte[1024];
            sendData = Encoding.ASCII.GetBytes(msg);
            clientSocket.Send(sendData);
        }


        public string recvFromClient()
        {

            string recvMsg = null;


            if(clientSocket.Available >0)
            {
                int bytesricv;
                byte[] recvData = new byte[1024];


                bytesricv = clientSocket.Receive(recvData);
                recvMsg = Encoding.ASCII.GetString(recvData, 0, bytesricv);

            }

            return recvMsg;

        }


        public void closeSockets()
        {
            if (this.clientSocket != null) this.clientSocket.Close();
            if (this.serverSocket != null) this.serverSocket.Close();
        }



    }
}
