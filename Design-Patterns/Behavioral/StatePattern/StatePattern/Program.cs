using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Context context = new Context();
            PlayMusic startState = new PlayMusic();
            startState.doAction(context);
            Console.WriteLine(context.getState().toString());

            StopMusic stopState = new StopMusic();
            stopState.doAction(context);
            Console.WriteLine(context.getState().toString());

            Console.Read();

        }
    }
}
