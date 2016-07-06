using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Apartment : IPropertyConstruction
    {
        Property p = new Property();
        public void SetArea()
        {
            p.Area = 100;
        }

        public void SetName()
        {
            p.Name = "Aparna Sarovar";
        }

        public void SetModel()
        {
            p.Model = "Apartment";
        }

        public void SetLocation()
        {
            p.Location = "Hyderabad";
        }

        public void SetnoRooms()
        {
            p.noofRooms = 3;
        }
        public void SetAccessories()
        {
            p.Accessories.Add("Cement");
            p.Accessories.Add("Bricks");
            p.Accessories.Add("Furniture");
            p.Accessories.Add("Swimming Pool");
            p.Accessories.Add("Garden");
        }
        public Property GetProperty()
        {
            return p;
        }

    }
}
