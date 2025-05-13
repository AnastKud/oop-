using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_5
{
    /// <summary>
    /// Класс, представляющий упаковку.
    /// </summary>
    public class Packaging : WorkProcess
    {
        private int executionTime;
        /// <summary>
        /// Устанавливает время выполнения процесса упаковки.
        /// </summary>
        public void SetExecutionTime(int time)
        {
            executionTime = time;
        }
        /// <summary>
        /// Реализация выполнения процесса для упаковки.
        /// </summary>
        public override void ExecuteProcess()
        {
            Console.WriteLine("Packaging process executed.");
        }
    }
}
