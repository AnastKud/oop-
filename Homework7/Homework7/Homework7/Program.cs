using Homework7;
/// <summary>
/// Основной класс программы.
/// </summary>
class Program
{
    static void Main()
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        var manager = new MagazineManager();
        manager.LoadFromFile("input.txt");

        manager.RunAction(new InteractiveMenuAction());
        manager.RunAction(new ExportSubscribersAction());

        Console.WriteLine("\nComplete.");
    }
}