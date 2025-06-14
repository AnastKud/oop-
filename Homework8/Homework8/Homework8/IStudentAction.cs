using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    /// <summary>
    /// Интерфейс действия над списком студентов
    /// </summary>
    public interface IStudentAction
    {
        void Execute(List<Student> students);
    }
}
