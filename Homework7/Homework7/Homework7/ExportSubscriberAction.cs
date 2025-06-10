using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    /// <summary>
    /// Действие для экспорта подписчиков каждого журнала в отдельный файл.
    /// </summary>
    public class ExportSubscribersAction : ISubscriberAction
    {
        /// <summary>
        /// Выполняет экспорт подписчиков по журналам в текстовые файлы.
        /// </summary>
        /// <param name="subscribers">Список подписчиков.</param>
        public void Execute(List<Subscriber> subscribers)
        {
            foreach (Magazine mag in Enum.GetValues(typeof(Magazine)))
            {
                var list = subscribers
                    .Where(s => s.SubscribedMagazines.Contains(mag))
                    .OrderBy(s => s.LastName)
                    .ToList();

                string fileName = $"{mag}_subscribers.txt";
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    if (list.Count == 0)
                    {
                        writer.WriteLine($"No subscribers to {mag}");
                        continue;
                    }

                    writer.WriteLine($"Subscribers to the magazine {mag}:");
                    writer.WriteLine("№\tLastName\tAdress\tOther");
                    int num = 1;
                    foreach (var s in list)
                    {
                        var other = s.SubscribedMagazines.Where(m => m != mag);
                        string others = string.Join(", ", other);
                        writer.WriteLine($"{num++}\t{s.LastName}\t{s.Address}\t{others}");
                    }
                }
            }
        }
    }
}
