using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework8
{
    /// <summary>
    /// Действие: увеличить стипендии только у отличников
    /// </summary>
    public class IncreaseExcellentStipends : IStudentAction
    {
        public void Execute(List<Student> students)
        {
            foreach (var s in students.Where(st => st.IsExcellent()))
            {
                s.IncreaseStipend(Config.IncreasePercent);
            }
            Console.WriteLine("[Scholarships increased for excellent students]");
        }
    }
}
