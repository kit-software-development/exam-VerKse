using System;
using System.Net.Sockets;
using System.Text;

namespace ConsoleServ
{
    //включает в себя все действия по работе с отдельным подключением
    public class ClientObject
    {

        public TcpClient client;
        public ClientObject(TcpClient tcpClient)
        {
            client = tcpClient;
        }
        private static readonly Method.MainDbContext context = new Method.MainDbContext();

        public void Process()
        {
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                //буфер для получаемых данных
                byte[] buffer = new byte[256];

                while (true)
                {
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(buffer, 0, buffer.Length);
                        builder.Append(Encoding.ASCII.GetString(buffer, 0, buffer.Length));

                    } while (stream.DataAvailable);

                    string message = builder.ToString();

                   
                    //обработка дейсвтия и отправка ответа на клиент
                    message = GiveMeAction(message);
                    buffer = Encoding.ASCII.GetBytes(message);
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception ex)
            {
                if (stream != null) stream.Close();
                if (client != null) client.Close();
                Console.WriteLine(DateTime.Now + ":  Connection ended");
            }
        }

        public string GiveMeAction(string message)
        {
            DBConnect db = new DBConnect();

            message = message.Replace("\0", "");
            int code = Convert.ToInt32(message.Substring(message.Length - 1, 1));
            message = message.Substring(0, message.Length - 1 - 1);
            Console.WriteLine(DateTime.Now + ":");

            CodeDictionary codes = new CodeDictionary();
            if (code != 0) { Console.Write(codes.action[code]); }

            switch (code)
            {
                case 0: //write message
                    Console.WriteLine(message);
                    Console.WriteLine();
                    break;
               case 1://add contact
                    try
                    {
                        Console.WriteLine(DateTime.Now + ":  Add-contact operation start");
                        Method.Contact c = new Method.Contact();
                        //
                        context.AddNewContact(c);
                        
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(DateTime.Now + ":  Add-contact operation failed");
                    }
                    break;
                case 2://update contact
                    try
                    {
                        Console.WriteLine(DateTime.Now + ":  Update-contact operation start");
                        string[] words = message.Split('|');
                        if (db.Update(words[0], words[1], words[2], words[3], words[4], words[5],words[6], words[7], words[8], words[9]))
                            Console.WriteLine(DateTime.Now + ":  Update-contact operation sucsessfuly ended");
                        else Console.WriteLine(DateTime.Now + ":  Delete-contact operation failed");

                    }
                    catch (Exception)
                    {
                        Console.WriteLine(DateTime.Now + ":  Update-contact operation failed");
                    }
                    break;
                case 3://delete contact
                    try
                    {
                        Console.WriteLine(DateTime.Now + ":  Delete-contact operation start");
                        string[] words = message.Split('|');
                        if (db.Delete(words[0], words[1], words[2], words[3], words[4]))
                            Console.WriteLine(DateTime.Now + ":  Delete-contact operation sucsessfuly ended");
                        else Console.WriteLine(DateTime.Now + ":  Delete-contact operation failed");

                    }
                    catch (Exception)
                    {
                        Console.WriteLine(DateTime.Now + ":  Delete-contact operation failed");
                    }
                    break;
                case 4://log-check
                    try
                    {
                        string[] words = message.Split('|');
                        if (db.CheckLogin(ref words[0], ref words[1]))
                        {
                            Console.WriteLine(DateTime.Now + ":  User was logged");
                            return "true";
                        }
                        else
                        {
                            Console.WriteLine(DateTime.Now + ":  Log-in operation was failed.");
                            return "false";
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(DateTime.Now + ":  User-log operation failed");
                    }
                    break;
                case 5://upload contacts
                    Console.WriteLine(DateTime.Now + ":  Server upload contacts");
                    break;
                    
            }
            return " ";


}


    }
}
