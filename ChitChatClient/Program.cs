using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using ProtoBuf;
using ChitChat.Events;
using System.Windows.Forms;


namespace ChitChatClient
{
    public static class ClientInfo //Global class to be accessed throughout the life of the program
    {
        public static string clientUsername;
        public static string clientPassword;
        public static string roomName;
        public static List<string> friendsList = new List<string>();
        public static Client c = null;
    }

    public class ReceivedMessage
    {
        public string sender;
        public string message;
    }

    public class Client
    {
        public  TcpClient _client;
        public  NetworkStream stream;
        public  pbUserInfo _userInfo;

        public  Client()
        {
            _client = new TcpClient("144.37.220.240", 27015);
            stream = _client.GetStream();
            _userInfo = new pbUserInfo();

            Console.WriteLine("Client initialized");
        }

        public void StartClient()
        {
            Console.WriteLine("Starting Client....");
        }

        //MAIN
        [STAThread]
        static int Main(String[] args)
        {
            
            Application.EnableVisualStyles();
            Application.Run(new LoginForm());
           // Application.Run(new Form1());

            return (0);
        }
    }
}

