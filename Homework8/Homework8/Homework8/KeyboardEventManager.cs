using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    /// <summary>
    /// Обработчик событий клавиатуры
    /// </summary>
    public class KeyboardEventManager : IKeyboardHandler
    {
        private readonly Dictionary<ConsoleKey, IStudentAction> _actions;
        private readonly List<Student> _students;
        private readonly Action _printCallback;

        public KeyboardEventManager(Dictionary<ConsoleKey, IStudentAction> actions, List<Student> students, Action printCallback)
        {
            _actions = actions;
            _students = students;
            _printCallback = printCallback;
        }

        /// <summary>
        /// Обработка нажатия клавиш
        /// </summary>
        public void Handle(ConsoleKey key)
        {
            if (_actions.ContainsKey(key))
            {
                _actions[key].Execute(_students);
                _printCallback();
            }
            else if (key == ConsoleKey.Escape)
            {
                Console.WriteLine("[Exiting the program]");
            }
        }
    }
}
