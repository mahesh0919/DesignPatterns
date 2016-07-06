using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class Image: IImage
    {
        private string name;
        private int height;
        private int width;
        private int x;
        private int y;

        public Image(string name)
        {
            this.name = name;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public void setHeight(int height)
        {
            this.height = x;
        }

        public void setWidth(int width)
        {
            this.width = y;
        }
        public void Draw()
        {
            Console.WriteLine("X coordinate: "+ x + " Y-co-ordinate: " + y);
            Console.WriteLine("Height: " + height + " Width: " + width);
        }
    }
}
