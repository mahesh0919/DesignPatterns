using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract ICar GetCar(string carName);
        public abstract IColor GetColor(string colorName);
    }
}
