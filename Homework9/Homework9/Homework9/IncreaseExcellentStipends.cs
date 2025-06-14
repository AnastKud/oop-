using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    /// <summary>
    /// Действие: увеличение стипендии у отличников.
    /// </summary>
    public class IncreaseExcellentStipends : IStudentAction
    {
        public void Execute(List<Students> students)
        {
            foreach (var student in students.Where(s => s.IsExcellent()))
            {
                student.IncreaseStipend(Config.IncreasePercent);
            }
            Console.WriteLine("[Scholarships increased for excellent students]");
        }
    }
}
