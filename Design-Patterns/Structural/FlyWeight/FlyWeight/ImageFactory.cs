using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FlyWeight
{
    public class ImageFactory
    {
        private static Dictionary<string,Image> images = new Dictionary<string,Image>();

        public static Image getimage(String imageName)
        {
            Image image = null;
            if(images.ContainsKey(imageName))
                 image = (Image)images[imageName];

            if (image == null)
            {
                image = new Image(imageName);
                images.Add(imageName, image);
                Console.WriteLine(imageName);
            }
            return image;
        }
    }
}
