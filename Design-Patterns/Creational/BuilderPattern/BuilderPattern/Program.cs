using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PropertyBuilder pb1 = new PropertyBuilder(new Apartment());
            pb1.CreateProperty();
            Property apartment = pb1.GetPropertyDetails();
            apartment.GetPropertyDetails();

            Console.WriteLine("\n\n");

            PropertyBuilder pb2 = new PropertyBuilder(new IndependentHouse());
            pb2.CreateProperty();
            Property independentHouse = pb2.GetPropertyDetails();
            independentHouse.GetPropertyDetails();

            Console.Read();

        }
    }
}
