using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class FootBall: Game
    {
        public override void initialize()
        {
            Console.WriteLine("Football Game Initialized with 11 players");
        }

        public override void startPlay()
        {
            Console.WriteLine("Football Game Started.  ");
        }

        public override void endPlay()
        {
            Console.WriteLine("Yehhh Arsenal Won the match");
        }

        public override void prizeDistribution()
        {
            Console.WriteLine("Man of the match goes to ADAMS, Tony");
        }
    }
}
