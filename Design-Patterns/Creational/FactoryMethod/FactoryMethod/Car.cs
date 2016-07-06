using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class NanoCar : ICar
    {
        public void GetSpecifications()
        {
            Console.WriteLine("This is Nano Car");
        }
    }

    public class FigoCar : ICar
    {
        public void GetSpecifications()
        {
            Console.WriteLine("This is Figo Car");
        }
    }                                   

    public class I10Car : ICar
    {
        public void GetSpecifications()
        {
            Console.WriteLine("This is I10 Car");
        }
    }
}
