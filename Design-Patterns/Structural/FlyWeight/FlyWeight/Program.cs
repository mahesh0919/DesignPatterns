using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        private static String[] images = { "Redimage1", "Greenimag1", "Blueimage", "Whiteimage", "Blackimage" };
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; ++i)
            {
                Image image = (Image)ImageFactory.getimage((getRandomImage()));
                image.setX(getRandomX());
                image.setY(getRandomY());
                image.Draw();
            }

            Console.Read();
        }
        private static String getRandomImage()
        {
            Random r = new Random();
            int index = r.Next(0, images.Length);
            return images[index];
        }
        private static int getRandomX()
        {
            Random r = new Random();
            return (int)(r.Next(0,100));
        }
        private static int getRandomY()
        {
            Random r = new Random();
            return (int)(r.Next(0,100));
        }
    }
}
