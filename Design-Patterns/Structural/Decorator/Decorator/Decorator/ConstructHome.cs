using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConstructHome :IHome
    {
        protected IHome _home;

        public ConstructHome(IHome home)
        {
            _home = home;
        }

        public void BuildHome()
        {
            _home.BuildHome();
        }
    }
}
