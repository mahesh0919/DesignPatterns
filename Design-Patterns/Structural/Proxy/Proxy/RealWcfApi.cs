using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RealWcfApi : IWCFApi
    {
        public void PerformAction()
        {
            Console.WriteLine("Real API actions called from Proxy class");
        }
    }
}
