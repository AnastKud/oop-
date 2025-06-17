using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    /// <summary>
    /// Представляет подписчика с фамилией, адресом и списком подписанных журналов.
    /// </summary>
    public class Subscriber
    {
        /// <summary>Фамилия подписчика.</summary>
        public string LastName { get; set; }
        /// <summary>Адрес подписчика.</summary>
        public string Address { get; set; }
        /// <summary>Список журналов, на которые подписан пользователь.</summary>
        public List<Magazine> SubscribedMagazines { get; set; }
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Subscriber"/>.
        /// </summary>
        /// <param name="lastName">Фамилия подписчика.</param>
        /// <param name="address">Адрес подписчика.</param>
        /// <param name="magazines">Список подписанных журналов.</param>
        public Subscriber(string lastName, string address, List<Magazine> magazines)
        {
            LastName = lastName;
            Address = address;
            SubscribedMagazines = magazines;
        }
        /// <summary>
        /// Возвращает строковое представление подписчика.
        /// </summary>
        /// <returns>Строка с фамилией, адресом и журналами.</returns>
        public override string ToString()
        {
            string others = string.Join(", ", SubscribedMagazines);
            return $"{LastName}\t{Address}\t{others}";
        }
    }
}
