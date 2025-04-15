using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models
{
    class ConsoleGame : Game
    {
        public override void Play()
        {
            Console.WriteLine("Playing a console game.");
        }
    }
}