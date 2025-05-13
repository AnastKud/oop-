using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_5
{
    /// <summary>
    /// Абстрактный базовый класс, представляющий рабочий процесс.
    /// Содержит общее свойство Duration и абстрактный метод ExecuteProcess.
    /// </summary>
    public abstract class WorkProcess
    {
        private int _duration;
        /// <summary>
        /// Продолжительность процесса в минутах.
        /// </summary>

        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        /// <summary>
        /// Абстрактный метод, реализуемый в дочерних классах.
        /// </summary>
        public abstract void ExecuteProcess();
    }
}
