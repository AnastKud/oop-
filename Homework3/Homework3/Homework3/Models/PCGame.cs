using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models
{
    /// <summary>
    /// Represents a PC game.
    /// </summary>
    class PCGame : Game
    {
        /// <summary>
        /// Method to play the PC game.
        /// </summary>
        public override void Play()
        {
            Console.WriteLine("Playing a PC game.");
        }
    }
}
