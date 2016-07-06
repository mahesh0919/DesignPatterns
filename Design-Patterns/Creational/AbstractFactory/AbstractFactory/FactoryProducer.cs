using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choise)
        {
            if (string.Compare(choise,"CAR",true)== 0)
                return new CarFactory();

            if(string.Compare(choise,"color",true) == 0)
                return new ColorFactory();

            return null;
        }
    }
}
