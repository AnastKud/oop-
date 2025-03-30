using ArrayProces;
using System;

class Program
{
    static void Main()
    {
        int size = ReadArraySize();
        Massiv massiv = new Massiv(size);
        massiv.InputArray();
        massiv.PrintArray();
        int a = massiv.ProductPositiveAfterLastNegative();
        Console.WriteLine($"The value of `a` from the array will be: {a}");

        int size1 = ReadArraySize();
        Massiv massiv1 = new Massiv(size1);
        massiv1.InputArray();
        massiv1.PrintArray();
        int b = (massiv1.ProductPositiveAfterLastNegative()) * 2;
        Console.WriteLine($"The value of `b` from the array will be: {b}");

        int size2 = ReadArraySize();
        Massiv massiv2 = new Massiv(size2);
        massiv2.InputArray();
        massiv2.PrintArray();
        int c = (massiv2.ProductPositiveAfterLastNegative()) / 2;
        Console.WriteLine($"The value of `c` from the array will be: {c}");

        double result = FunctionCalculator.Calculate(a, b, c);
        Console.WriteLine($"Function calculation result: {result}");
    }
    private static int ReadArraySize()
    {
        int size;
        while (true)
        {
            Console.Write("Enter array size: ");
            if (int.TryParse(Console.ReadLine(), out size) && size > 0)
                return size;
            Console.WriteLine("Input error! Array size must be a positive number.");
        }
    }
}
