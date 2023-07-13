using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SocketDemo
{
    class MainClass
    {
        static Socket socketListener;

        public static void Main(string[] args)
        {
            ServerEnd(60000, 10);
            Thread th = new Thread(ServerCommunity);
            th.Start(socketListener);
        }

        private static void ServerEnd(int myPort, int allowNum)
        {
            socketListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ip = IPAddress.Any;

            int port = myPort;

            IPEndPoint point = new IPEndPoint(ip, port);

            socketListener.Bind(point);

            ShowMsg("Listening...");

            socketListener.Listen(allowNum);
        }

        private static void ServerCommunity(object obListener)
        {
            Socket temp = (Socket)obListener;

            while (true)
            {
                Socket socketSender = temp.Accept();

                ShowMsg(("Client IP = " + socketSender.RemoteEndPoint.ToString()) + " Connect Succese!");

                Thread ReceiveMsg = new Thread(ReceiveClient);

                ReceiveMsg.IsBackground = true;

                Thread SendToClient = new Thread(SendMsgToClient);

                SendToClient.Start(socketSender);

                ReceiveMsg.Start(socketSender);
            }

        }

        private static void SendMsgToClient(object mySocketSender)
        {
            Socket socketSender = mySocketSender as Socket;

            while (true)
            {
                if (socketSender.RemoteEndPoint == null)
                {
                    ShowMsg("socketSender.RemoteEndPoint == null");
                    break;
                }
                string msg = Console.ReadLine();

                byte[] buffer = Encoding.UTF8.GetBytes(msg);

                socketSender.Send(buffer);
            }

        }

        private static void ReceiveClient(object mySocketSender)
        {
            Socket socketSender = mySocketSender as Socket;

            while (true)
            {

                byte[] buffer = new byte[1024];

                int rece = socketSender.Receive(buffer);

                if (rece == 0)
                {
                    ShowMsg(string.Format("Client : {0} + 下線了", socketSender.RemoteEndPoint.ToString()));
                    break;
                }
                string clientMsg = Encoding.UTF8.GetString(buffer, 0, rece);
                ShowMsg(string.Format("Client : {0}", clientMsg));
            }
        }


        private static void ShowMsg(string s)
        {
            Console.WriteLine(s);
        }

    }

}