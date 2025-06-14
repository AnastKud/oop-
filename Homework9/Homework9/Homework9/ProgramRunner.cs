using Homework9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class ProgramRunner
    {
        /// <summary>
        /// Класс, запускающий программу и обрабатывающий логику клавиш.
        /// </summary>
        public void Run()
        {
            var repository = new StudentRepository(Config.FileName);
            repository.Load();
            var students = repository.GetStudents();

            // Добавляем действия по клавишам
            var keyActions = new Dictionary<ConsoleKey, Action>
            {
                { ConsoleKey.PageUp, () => { new IncreaseAllStipends().Execute(students); repository.PrintAll(); } },
                { ConsoleKey.PageDown, () => { new IncreaseExcellentStipends().Execute(students); repository.PrintAll(); } },
                { ConsoleKey.Delete, () => { new DeleteLowestStipend().Execute(students); repository.PrintAll(); } },
                { ConsoleKey.F1, () => { repository.ToggleSortOrder(); repository.PrintAll(); } },
                { ConsoleKey.F2, () => {
                    Console.Write("Please enter the minimum acceptable rating: ");
                    if (int.TryParse(Console.ReadLine(), out int threshold))
                    {
                        Console.WriteLine($"\nStudents with grades below {threshold}:");
                        repository.PrintStudentsBelowGrade(threshold);
                    }
                    else Console.WriteLine("Incorrect input.");
                }},
                { ConsoleKey.F3, () => {
                    Console.Write("Enter the faculty name: ");
                    string faculty = Console.ReadLine();
                    Console.WriteLine($"\nStudents of the faculty {faculty}:");
                    repository.PrintStudentsFromFaculty(faculty);
                }}
            };

            // Вывод инструкции
            Console.WriteLine("=== Program Management ===");
            Console.WriteLine("PageUp     - Increase scholarships for all students");
            Console.WriteLine("PageDown   - Increase stipends for excellent students");
            Console.WriteLine("Delete     - Remove the student with the lowest scholarship");
            Console.WriteLine("F1         - Change sort order by faculty");
            Console.WriteLine("F2         - Show students with grades below the given level");
            Console.WriteLine("F3         - Show students of the specified faculty");
            Console.WriteLine("Escape     - Complete the program");
            Console.WriteLine("==============================\n");

            var keyboard = new KeyboardEventManager(keyActions);
            repository.PrintAll();

            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                keyboard.Handle(key);
            } while (key != ConsoleKey.Escape);
        }
    }
}
