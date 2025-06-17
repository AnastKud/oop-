using Homework7;
/// <summary>
/// Действие, реализующее интерактивное меню для просмотра подписчиков по журналам.
/// </summary>
public class InteractiveMenuAction : ISubscriberAction
{
    /// <summary>
    /// Выполняет интерактивное меню с возможностью выбора журнала.
    /// </summary>
    /// <param name="subscribers">Список подписчиков.</param>
    public void Execute(List<Subscriber> subscribers)
    {
        Magazine[] magazines = (Magazine[])Enum.GetValues(typeof(Magazine));
        int index = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\r\nSelect log ( left/right, Esc - exit):");
            Console.WriteLine($">>> {magazines[index]} <<<\n");

            new DisplaySubscribersAction(magazines[index]).Execute(subscribers);

            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.Escape) break;
            if (key == ConsoleKey.LeftArrow) index = (index - 1 + magazines.Length) % magazines.Length;
            if (key == ConsoleKey.RightArrow) index = (index + 1) % magazines.Length;
        }
    }
}