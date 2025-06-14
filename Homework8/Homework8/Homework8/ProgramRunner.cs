using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    /// <summary>
    /// Класс запуска основной логики приложения
    /// </summary>
    public class ProgramRunner
    {
        public void Run()
        {
            var repository = new StudentRepository(Config.FileName);
            repository.Load();
            var students = repository.GetStudents();
            var actions = new Dictionary<ConsoleKey, IStudentAction>
            {
                { ConsoleKey.PageUp, new IncreaseAllStipends() },
                { ConsoleKey.PageDown, new IncreaseExcellentStipends() },
                { ConsoleKey.Delete, new DeleteLowestStipend() }
            };

            var keyboard = new KeyboardEventManager(actions, students, repository.PrintAll);
            repository.PrintAll();
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                keyboard.Handle(key);
            }
            while (key != ConsoleKey.Escape);
        }
    }
}
