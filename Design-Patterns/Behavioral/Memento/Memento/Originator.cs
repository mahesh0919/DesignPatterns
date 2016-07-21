using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Originator
    {
        private string state;
        public void setState(string state)
        {
            Console.WriteLine("Originator: Setting state to " + state);
            this.state = state;
        }

        public Memento saveStateToMemento()
        {
            Console.WriteLine("Originator: Saving to Memento.");
            return new Memento(state);
        }

        public void restoreFromMemento(Memento memento) 
        {
            Console.WriteLine("Originator: State after restoring from Memento: " + state);
            this.state = memento.getSavedState();
        }
    }

}
