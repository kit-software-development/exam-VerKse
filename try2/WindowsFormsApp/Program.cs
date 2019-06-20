using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    static class Program
    {
        const int port = 8888;
        const string address = "127.0.0.1";
        static NetworkStream stream;
        static TcpClient client;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            client = null;

            try
            {
                client = new TcpClient(address, port);

                stream = client.GetStream();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Auth());

                while (true)
                {
                    //отправляем сообщение
                    string message = "Test message";
                    byte[] buffer = Encoding.ASCII.GetBytes(message);
                    stream.Write(buffer, 0, buffer.Length);

                    // получаем ответ
                    buffer = new byte[256];
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(buffer, 0, buffer.Length);
                        builder.Append(Encoding.ASCII.GetString(buffer, 0, bytes));
                    } while (stream.DataAvailable);

                    message = builder.ToString();
                }
            }
            catch (Exception ex) {
                //Console.WriteLine(DateTime.Now + ":  Unpredictable exception");
            }
            finally { client.Close(); }
        }

        //sотправляем сообщение
        public static void SendMessage(string mes)
        {
            while (true)
            {
                
                byte[] buffer = Encoding.ASCII.GetBytes(mes);
                stream.Write(buffer, 0, buffer.Length);
            }
        }

        //получаем сообщение
        public static string ReceiveMessage()
        {
            while (true)
            { try {
                    byte[] buffer = new byte[256];
                    StringBuilder builder = new StringBuilder();

                    int bytes = 0;

                        bytes = stream.Read(buffer, 0, buffer.Length);
                        builder.Append(Encoding.ASCII.GetString(buffer, 0, buffer.Length));

                    return builder.ToString();
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
