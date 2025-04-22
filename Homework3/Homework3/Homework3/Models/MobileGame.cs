using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models
{
    /// <summary>
    /// Represents a mobile game.
    /// </summary>
    class MobileGame : Game
    {
        /// <summary>
        /// Method to play the mobile game.
        /// </summary>
        public override void Play()
        {
            Console.WriteLine("Playing a mobile game.");
        }
    }
}
