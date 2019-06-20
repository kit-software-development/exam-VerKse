using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServ
{
    class CodeDictionary
    {
        public Dictionary<int, string> action = new Dictionary<int, string>(6);

        public CodeDictionary()
        {
            action.Add(0, "write message");
            action.Add(1, "add contact");
            action.Add(2, "update contact");
            action.Add(3, "delete contact");
            action.Add(4, "log-check");
            action.Add(5, "other");
        }
    }
}
