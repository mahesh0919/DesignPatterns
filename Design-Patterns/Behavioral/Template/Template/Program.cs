﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.play();

            Console.WriteLine("\n\n***************\n");

            game = new FootBall();
            game.play();

            Console.Read();

        }
    }
}
