using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // get nano car
            AbstractFactory carFactory = FactoryProducer.GetFactory("car");
            ICar nanoCar = carFactory.GetCar("nano");
            nanoCar.GetSpecifications();

            // get white color
            AbstractFactory colorFactory = FactoryProducer.GetFactory("color");
            IColor color = colorFactory.GetColor("white");
            color.GetColor();

            Console.Read();

        }
    }
}
