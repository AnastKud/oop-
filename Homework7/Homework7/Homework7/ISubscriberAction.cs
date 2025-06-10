using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    /// <summary>
    /// Интерфейс действия, которое может выполняться над списком подписчиков.
    /// </summary>
    public interface ISubscriberAction
    {
        /// <summary>
        /// Выполняет действие над списком подписчиков.
        /// </summary>
        /// <param name="subscribers">Список подписчиков.</param>
        void Execute(List<Subscriber> subscribers);
    }
}
