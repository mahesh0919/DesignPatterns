using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Property
    {
        public string Model { get; set; }
        public int Area { get; set; }
        public string Location { get; set; }
        public int noofRooms { get; set; }
        public string Name { get; set; }
        public List<string> Accessories { get; set; }

        public Property()
        { 
            Accessories =new List<string>();
        }

        public void GetPropertyDetails()
        {
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Area in sft: " + Area);
            Console.WriteLine("Location: " + Location);
            Console.WriteLine("Num of Rooms: " + noofRooms);
            Console.WriteLine("Name: "+ Name);

            Console.WriteLine("*****List of Accessories*******");
            foreach (string str in Accessories)
            {
                Console.WriteLine(str);
            }
        }

    }
}
