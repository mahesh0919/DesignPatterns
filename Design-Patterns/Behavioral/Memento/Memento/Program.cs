using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator orig = new Originator();
            CareTaker careTaker = new CareTaker();

            orig.setState("State1");
            orig.setState("State2");
            careTaker.add(orig.saveStateToMemento());
            
            orig.setState("State3");
            careTaker.add(orig.saveStateToMemento());

            careTaker.get(0);
            orig.restoreFromMemento(careTaker.get(1));

            Console.Read();

        }
    }
}
