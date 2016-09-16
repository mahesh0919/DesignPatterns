using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class NanoCar : ICar
    {
        public string GetSpecifications()
        {
            Console.WriteLine("This is Nano Car");
            return "NanoCar";
        }
    }

    public class FigoCar : ICar
    {
        public string GetSpecifications()
        {
            Console.WriteLine("This is Figo Car");
            return "FigoCar";
        }
    }                                   

    public class I10Car : ICar
    {
        public string GetSpecifications()
        {
            Console.WriteLine("This is I10 Car");
            return "I10Car";
        }
    }
}
