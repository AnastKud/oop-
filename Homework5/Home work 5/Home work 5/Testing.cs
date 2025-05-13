using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_5
{
    /// <summary>
    /// Класс, представляющий тестирование.
    /// </summary>
    public class Testing : WorkProcess
    {
        private int executionTime;

        /// <summary>
        /// Устанавливает время выполнения процесса тестирования.
        /// </summary>
        public void SetExecutionTime(int time)
        {
            executionTime = time;
        }
        /// <summary>
        /// Реализация выполнения процесса для тестирования.
        /// </summary>
        public override void ExecuteProcess()
        {
            Console.WriteLine("Testing process executed.");
        }
    }
}
