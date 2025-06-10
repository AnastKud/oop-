using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    /// <summary>
    /// Действие для отображения подписчиков, подписанных на определённый журнал.
    /// </summary>
    public class DisplaySubscribersAction : ISubscriberAction
    {
        private Magazine targetMagazine;
        /// <summary>
        /// Инициализирует новое действие для отображения подписчиков указанного журнала.
        /// </summary>
        /// <param name="magazine">Журнал для фильтрации подписчиков.</param>
        public DisplaySubscribersAction(Magazine magazine)
        {
            targetMagazine = magazine;
        }
        /// <summary>
        /// Выполняет отображение подписчиков на выбранный журнал.
        /// </summary>
        /// <param name="subscribers">Список подписчиков.</param>
        public void Execute(List<Subscriber> subscribers)
        {
            var filtered = subscribers
                .Where(s => s.SubscribedMagazines.Contains(targetMagazine))
                .OrderBy(s => s.LastName);

            Console.WriteLine($"\nSubscribers to the magazine {targetMagazine}:\n");
            foreach (var sub in filtered)
                Console.WriteLine(sub);
        }
    }
}
