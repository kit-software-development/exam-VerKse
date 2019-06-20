using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleServ
{
    class Program
    {
        const int port = 8888;
        static TcpListener listener;
        static void Main(string[] args)
        {
            try
            {
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
                listener.Start();
                Console.WriteLine(DateTime.Now + ":  Waiting for connection...");

                while (true)
                {
                    //подключение нового клиента
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine(DateTime.Now + ":  New client connected");
                    ClientObject clientObject = new ClientObject(client);

                    //создаём новый поток для обслуживания нового клиента
                    Thread clientThread = new Thread(new ThreadStart(clientObject.Process));
                    Console.WriteLine(DateTime.Now + ":  New thread was made");
                    clientThread.Start();
                }
            }
            catch(Exception ex)
            { Console.WriteLine("Exception in Server.Program.cs."); }
        }
       
    }


}
