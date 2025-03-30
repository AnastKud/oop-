using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProces
{
    internal class Massiv
    {
        private int[] array;

        public Massiv(int size)
        {
            array = new int[size];
        }
        public void InputArray()
        {
            Console.WriteLine("Enter Array Elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ReadInteger($"Element: {i + 1}: ");
            }
        }

        public void PrintArray()
        {
            Console.WriteLine("Array: " + string.Join(", ", array));
        }

        public int ProductPositiveAfterLastNegative()
        {
            int lastNegativeIndex = FindLastNegativeIndex();
            if (lastNegativeIndex == -1)
            {
                Console.WriteLine("No negative elements found.");
                return 0;
            }
            return CalculateProduct(lastNegativeIndex);
        }

        private int FindLastNegativeIndex()
        {
            int lastNegativeIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    lastNegativeIndex = i;
            }
            return lastNegativeIndex;
        }

        private int CalculateProduct(int startIndex)
        {
            int product = 1;
            bool foundPositive = false;

            for (int i = startIndex + 1; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    product *= array[i];
                    foundPositive = true;
                }
            }

            if (!foundPositive)
            {
                Console.WriteLine("No positive elements found after the last negative.");
                return 0;
            }

            return product;
        }

        private int ReadInteger(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.WriteLine("Input error! Please enter an integer.");
            }
        }
    }

}
