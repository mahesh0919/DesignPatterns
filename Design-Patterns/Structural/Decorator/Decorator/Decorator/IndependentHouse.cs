using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class IndependentHouse : IHome
    {
        public void BuildHome()
        {
            Console.Write("Independent House Constructed");
        }
    }
}
