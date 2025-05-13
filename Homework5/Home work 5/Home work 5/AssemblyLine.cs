using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_5
{
    /// <summary>
    /// Класс, представляющий сборочную линию.
    /// </summary>
    internal class AssemblyLine : WorkProcess
    {
        private int executionTime;
        /// <summary>
        /// Устанавливает время выполнения процесса.
        /// </summary>

        public void SetExecutionTime(int time)
        {
            executionTime = time;
        }

        /// <summary>
        /// Реализация выполнения процесса для сборочной линии.
        /// </summary>
        public override void ExecuteProcess()
        {
            Console.WriteLine("Assembly complete");
        }
    }
}
