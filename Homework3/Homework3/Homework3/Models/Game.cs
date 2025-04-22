using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Models
{
    /// <summary>
    /// Base class representing a generic game.
    /// </summary>
    class Game
    {
        /// <summary>
        /// Method to play the game.
        /// </summary>
        public virtual void Play()
        {
            Console.WriteLine("Playing a game.");
        }
    }
}
