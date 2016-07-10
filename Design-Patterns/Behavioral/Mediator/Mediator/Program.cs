using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            User mahesh = new User("Mahesh");
            User rakesh = new User("Rakesh");

            mahesh.sendMessage("Hi! John!");
            rakesh.sendMessage("Hello! Robert!");

            Console.Read();
        }
    }
}
