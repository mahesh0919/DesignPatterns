using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RedColor: IColor
    {
        public void GetColor() 
        {
            Console.WriteLine("******Red Color*****");
        }
    }

    public class GreenColor : IColor
    {
        public void GetColor()
        {
            Console.WriteLine("******Green Color*****");
        }
    }

    public class WhiteColor : IColor
    {
        public void GetColor()
        {
            Console.WriteLine("******White Color*****");
        }
    }
}
