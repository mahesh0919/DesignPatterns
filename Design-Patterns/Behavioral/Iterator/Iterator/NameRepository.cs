using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class NameRepository : IContainer
    {
        public static String[] names = { "Mahesh", "Rakesh", "Rajesh", "Suresh" };

        public Iterator getIterator()
        {
            return new NameIterator();
        }

        public class NameIterator : Iterator
        {
            int index;
            public bool hasNext()
            {
                if (index < names.Length)
                {
                    return true;
                }
                return false;
            }

            public object next()
            {
                if (this.hasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }

    }


}
