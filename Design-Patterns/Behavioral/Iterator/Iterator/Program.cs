using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            NameRepository namesRepository = new NameRepository();

            for (Iterator iter = namesRepository.getIterator(); iter.hasNext(); )
            {
                String name = (String)iter.next();
                Console.WriteLine("Name : " + name);
            }

            Console.Read();
        }
    }
}
