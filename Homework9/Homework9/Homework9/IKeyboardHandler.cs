using Homework9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    /// <summary>
    /// Интерфейс для обработки нажатия клавиш.
    /// </summary>
    public interface IKeyboardHandler
    {
        void Handle(ConsoleKey key);
    }
}
