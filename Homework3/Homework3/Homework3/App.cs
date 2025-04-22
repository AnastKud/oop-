using Homework3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    /// <summary>
    /// The main application class that initializes and runs different types of games.
    /// </summary>
    class App
    {
        private Game gameOne;
        private Game gameTwo;
        private Game gameThree;

        /// <summary>
        /// Constructor that initializes the game objects.
        /// </summary>
        public App()
        {
            gameOne = new ConsoleGame();
            gameTwo = new MobileGame();
            gameThree = new PCGame();
        }

        /// <summary>
        /// Method to run the games.
        /// </summary>
        public void Run()
        {
            gameOne.Play();
            gameTwo.Play();
            gameThree.Play();
        }
    }
}
