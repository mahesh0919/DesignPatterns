using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Apartment: IHome
    {
        public void BuildHome()
        {
            Console.WriteLine("Apartment constructed");
        }
    }
}
