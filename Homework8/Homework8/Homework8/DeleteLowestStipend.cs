using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    /// <summary>
    /// Действие: удалить студента с минимальной стипендией
    /// </summary>
    public class DeleteLowestStipend : IStudentAction
    {
        public void Execute(List<Student> students)
        {
            var min = students.Min(s => s.Stipend);
            var toRemove = students.FirstOrDefault(s => s.Stipend == min);
            if (toRemove != null)
            {
                students.Remove(toRemove);
                Console.WriteLine($"[The student with the lowest scholarship has been removed: {toRemove.LastName}]");
            }
        }
    }
}
