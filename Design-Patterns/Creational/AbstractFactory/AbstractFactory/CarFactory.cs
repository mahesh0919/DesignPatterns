using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CarFactory: AbstractFactory
    {
        public override ICar GetCar(string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;

            if (string.Compare(name, "Ambassador", true) == 0)
                return new Ambassador();
            else if (string.Compare(name, "Nano", true) == 0)
                return new Nano();
            else if (string.Compare(name, "MercedesCar", true) == 0)
                return new MercedesCar();

            return null;

        }
        public override IColor GetColor(string name)
        {
            return null;
        }
    }
}
