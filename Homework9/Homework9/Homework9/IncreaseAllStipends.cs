using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    /// <summary>
    /// Действие: увеличение стипендии у всех студентов.
    /// </summary>
    public class IncreaseAllStipends : IStudentAction
    {
        public void Execute(List<Students> students)
        {
            foreach (var student in students)
            {
                student.IncreaseStipend(Config.IncreasePercent);
            }
            Console.WriteLine("[Scholarships have been increased for all students]");
        }
    }
}
