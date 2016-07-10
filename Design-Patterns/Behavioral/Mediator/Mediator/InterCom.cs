using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class InterCom
    {
        public static void SendMessage(User user,String message)
        {
            Console.WriteLine(DateTime.Now.ToString() + " : " + user);
        }
    }
}
