using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Now this class is laptop, in future it may be a mediaplayer or mobile devise
            ILaptop laptop = new CardReader();
            Laptop client = new Laptop(laptop);
            client.PlayAlbums();

            Console.Read();
        }
    }
}
