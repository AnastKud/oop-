using Homework7;
/// <summary>
/// Класс для управления списком подписчиков и выполнением действий с ними.
/// </summary>
public class MagazineManager
{
    /// <summary>
    /// Список подписчиков.
    /// </summary>
    public List<Subscriber> Subscribers { get; private set; } = new List<Subscriber>();
    /// <summary>
    /// Загружает подписчиков из файла.
    /// Формат файла: LastName, AddressPart1, AddressPart2, Magazine1;Magazine2;...
    /// </summary>
    /// <param name="path">Путь к файлу с данными.</param>
    public void LoadFromFile(string path)
    {
        foreach (var line in File.ReadLines(path))
        {
            var parts = line.Split(',');
            if (parts.Length < 3) continue;

            string lastName = parts[0].Trim();
            string address = parts[1].Trim() + ", " + parts[2].Trim();

            List<Magazine> mags = new List<Magazine>();
            if (parts.Length > 3)
            {
                var names = parts[3].Split(';');
                foreach (var name in names)
                {
                    if (Enum.TryParse(name.Trim(), out Magazine m))
                        mags.Add(m);
                }
            }

            Subscribers.Add(new Subscriber(lastName, address, mags));
        }
    }
    /// <summary>
    /// Запускает действие, реализующее интерфейс <see cref="ISubscriberAction"/>.
    /// </summary>
    /// <param name="action">Действие для выполнения.</param>
    public void RunAction(ISubscriberAction action)
    {
        action.Execute(Subscribers);
    }
}