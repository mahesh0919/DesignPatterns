using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();
            ICar nano = carFactory.GetCar("nano");
            nano.GetSpecifications();

            I10Car i10 = (I10Car)carFactory.GetCar("i10");
            i10.GetSpecifications();

            Console.Read();

        }
    }
}
