using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    /// <summary>
    /// Класс представляет сущность Студента
    /// </summary>
    public class Student
    {
        public string LastName { get; set; } // Фамилия
        public List<int> Grades { get; set; } // Список оценок
        public string Faculty { get; set; } // Название факультета
        public string Dean { get; set; } // Имя декана
        public int Stipend { get; set; } // Размер стипендии

        /// <summary>
        /// Проверка, является ли студент отличником
        /// </summary>
        public bool IsExcellent()
        {
            return Grades.All(g => g >= 4);
        }

        /// <summary>
        /// Увеличение стипендии на заданный процент
        ///</summary>
        public void IncreaseStipend(double percent)
        {
            Stipend += (int)(Stipend * percent);
        }

        /// <summary>
        /// Вывод информации о студенте
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine($"{LastName,-10} {string.Join(" ", Grades),-10} {Faculty,-10} {Dean,-10} {Stipend}");
        }
    }
}
