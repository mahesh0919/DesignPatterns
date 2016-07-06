using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IPropertyConstruction
    {
        void SetModel();
        void SetArea();
        void SetLocation();
        void SetnoRooms();
        void SetName();
        void SetAccessories();

        Property GetProperty();
    }
}
