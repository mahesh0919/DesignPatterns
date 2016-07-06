using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class IndependentHouse: IPropertyConstruction
    {
        Property p = new Property();
        public void SetArea()
        {
            p.Area = 100;
        }

        public void SetName()
        {
            p.Name = "Praneethi";
        }

        public void SetModel()
        {
            p.Model = "Independent House";
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
        }
        public Property GetProperty()
        {
            return p;
        }

    }
}
