using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    /// <summary>
    /// Интерфейс обработчика нажатий клавиш
    /// </summary>
    public interface IKeyboardHandler
    {
        void Handle(ConsoleKey key);
    }
}
