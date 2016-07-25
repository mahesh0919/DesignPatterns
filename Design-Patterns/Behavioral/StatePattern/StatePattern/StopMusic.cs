using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class StopMusic: IState
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player is in stop state");
             context.setState(this);
        }

        public String toString()
        {
            return "Stop Music";
        }
    }
}
