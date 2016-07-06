using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CarFactory
    {
        public ICar GetCar(string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;

            if (string.Compare(name, "Nano", true) == 0)
                return new NanoCar();

            if (string.Compare(name, "Figo", true) == 0)
                return new FigoCar();

            if (string.Compare(name, "I10", true) == 0)
                return new I10Car();

            return null;

        }
    }
}
