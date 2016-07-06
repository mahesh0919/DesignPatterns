using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MercedesCar : ICar
    {
        public void GetSpecifications()
        {
            Console.WriteLine("*********Mercedes-Benz*******");
        }
    }

    public class Ambassador : ICar
    {
        public void GetSpecifications()
        {
            Console.WriteLine("*********Ambassador*******");
        }
    }

    public class Nano : ICar
    {
        public void GetSpecifications()
        {
            Console.WriteLine("*********Tata Nano*******");
        }
    }
}
