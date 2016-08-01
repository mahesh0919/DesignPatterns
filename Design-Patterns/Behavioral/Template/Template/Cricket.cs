using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class Cricket : Game
    {
        public override void initialize()
        {
            Console.WriteLine("Cricket Game Initialized with 16 players");
        }

        public override void startPlay()
        {
            Console.WriteLine("Cricket Game Started with 11 players. India Batting ");
        }

        public override void endPlay()
        {
            Console.WriteLine("Yehhh India Won the match");
        }

        public override void prizeDistribution()
        {
            Console.WriteLine("Man of the match goes to Sachin tendulkar");
        }

    }
}
