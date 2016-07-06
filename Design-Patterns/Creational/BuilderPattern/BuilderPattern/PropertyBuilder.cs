using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class PropertyBuilder
    {
        private readonly IPropertyConstruction objProperty;

        public PropertyBuilder(IPropertyConstruction property)
        {
            objProperty = property;
        }

        public void CreateProperty()
        {
            objProperty.SetModel();
            objProperty.SetLocation();
            objProperty.SetName();
            objProperty.SetnoRooms();
            objProperty.SetAccessories();
            objProperty.SetArea();
        }

        public Property GetPropertyDetails()
        {
            return objProperty.GetProperty();
        }
    }
}
