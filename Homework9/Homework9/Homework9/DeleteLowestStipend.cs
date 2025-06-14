using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    /// <summary>
    /// Действие: удаление студента с наименьшей стипендией.
    /// </summary>
    public class DeleteLowestStipend : IStudentAction
    {
        /// <summary>
        /// Выполнение действия удаления.
        /// </summary>
        public void Execute(List<Students> students)
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
