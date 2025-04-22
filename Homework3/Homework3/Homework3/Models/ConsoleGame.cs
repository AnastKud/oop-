using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models
{
    /// <summary>
    /// Represents a console game.
    /// </summary>
    class ConsoleGame : Game
    {
        /// <summary>
        /// Method to play the console game.
        /// </summary>
        public override void Play()
        {
            Console.WriteLine("Playing a console game.");
        }
    }
}