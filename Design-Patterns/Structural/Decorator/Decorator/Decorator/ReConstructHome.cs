using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ReConstructHome  : ConstructHome
    {
        public ReConstructHome(IHome home) :base(home)
        {
        }

        public void  BuildHome()
        {
            _home.BuildHome();
            Addfallceiling();
        }

        private void Addfallceiling()
        {
            Console.WriteLine("Add fall ceiling to house");
        }
    }
}
