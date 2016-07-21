using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Memento
    {
        private string state;

        public Memento(string stateToSave)
        {
            state = stateToSave;
        }

        public String getSavedState()
        {
            return state;
        }
    }
}
