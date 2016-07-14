using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IHome apartment = new Apartment();
            ConstructHome home = new ConstructHome(apartment);
            home.BuildHome();

            Console.WriteLine("\n\n");

            ReConstructHome modifiedHome = new ReConstructHome(apartment);
            modifiedHome.BuildHome();

            Console.Read();
        }
    }
}
