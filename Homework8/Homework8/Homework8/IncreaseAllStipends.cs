using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    /// <summary>
    /// Действие: увеличить стипендии всем студентам
    /// </summary>
    public class IncreaseAllStipends : IStudentAction
    {
        public void Execute(List<Student> students)
        {
            foreach (var student in students)
            {
                student.IncreaseStipend(Config.IncreasePercent);
            }
            Console.WriteLine("[Scholarships have been increased for all students]");
        }
    }
}
