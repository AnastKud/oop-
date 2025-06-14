using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    /// <summary>
    /// Класс студента с необходимыми свойствами и методами.
    /// </summary>
    public class Students
    {
        public string LastName { get; set; }
        public List<int> Grades { get; set; }
        public string Faculty { get; set; }
        public string Dean { get; set; }
        public int Stipend { get; set; }

        /// <summary>
        /// Проверка, является ли студент отличником.
        /// </summary>
        public bool IsExcellent() => Grades.All(g => g >= 4);

        /// <summary>
        /// Увеличение стипендии на заданный процент.
        /// </summary>
        public void IncreaseStipend(double percent)
        {
            Stipend += (int)(Stipend * percent);
        }

        /// <summary>
        /// Получение среднего балла.
        /// </summary>
        public double GetAverageGrade() => Grades.Average();

        /// <summary>
        /// Печать информации о студенте.
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine($"{LastName,-10} {string.Join(" ", Grades),-10} {Faculty,-10} {Dean,-10} {Stipend}");
        }
    }
}
