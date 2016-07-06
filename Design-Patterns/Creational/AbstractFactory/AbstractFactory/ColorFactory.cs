using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ColorFactory: AbstractFactory
    {
        public override IColor GetColor(string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;

            if (string.Compare(name, "Red", true) == 0)
                return new RedColor();
            else if (string.Compare(name, "Green", true) == 0)
                return new GreenColor();
            else if (string.Compare(name, "White", true) == 0)
                return new WhiteColor();

            return null;

        }
        public override ICar GetCar(string name)
        {
            return null;
        }

    }
}
