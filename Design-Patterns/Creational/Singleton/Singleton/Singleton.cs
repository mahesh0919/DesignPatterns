using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        protected static Singleton _singleObject;

        // below constructor is to prevent creating new class object
        private Singleton()
        {

        }

        public static Singleton GetObject()
        {
            if (_singleObject == null)
            {
                _singleObject = new Singleton();
            }
            return _singleObject;
        }

        public void PrintMessage(string s)
        {
            Console.WriteLine(s);
        }

    }
}
