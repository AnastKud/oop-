using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    /// <summary>
    /// Менеджер событий клавиатуры, обрабатывающий действия по нажатию клавиш.
    /// </summary>
    public class KeyboardEventManager : IKeyboardHandler
    {
        private readonly Dictionary<ConsoleKey, Action> _keyActions;

        public KeyboardEventManager(Dictionary<ConsoleKey, Action> keyActions)
        {
            _keyActions = keyActions;
        }

        public void Handle(ConsoleKey key)
        {
            if (_keyActions.ContainsKey(key))
            {
                _keyActions[key].Invoke();
            }
            else if (key == ConsoleKey.Escape)
            {
                Console.WriteLine("[Exiting the program]");
            }
        }
    }
}
