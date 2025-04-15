using Homework3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class App
    {
        private Game gameOne;
        private Game gameTwo;
        private Game gameThree;

        public App()
        {
            gameOne = new ConsoleGame();
            gameTwo = new MobileGame();
            gameThree = new PCGame();
        }

        public void Run()
        {
            gameOne.Play();
            gameTwo.Play();
            gameThree.Play();
        }
    }
}
