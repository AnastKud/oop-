using Home_work_5;
using System.Reflection.Emit;
/// <summary>
/// Точка входа в программу.
/// </summary>
class Program
{
    static void Main()
    {
        /// Создание и выполнение сборочной линии
        WorkProcess assemblyLine = new AssemblyLine();
        assemblyLine.Duration = 120;
        ((AssemblyLine)assemblyLine).SetExecutionTime(100);
        assemblyLine.ExecuteProcess();
        /// Создание и выполнение упаковки
        WorkProcess packaging = new Packaging();
        packaging.Duration = 60;
        ((Packaging)packaging).SetExecutionTime(50);
        packaging.ExecuteProcess();
        /// Создание и выполнение тестирования
        WorkProcess testing = new Testing();
        testing.Duration = 30;
        ((Testing)testing).SetExecutionTime(20);
        testing.ExecuteProcess();
    }
}
///   Конец!