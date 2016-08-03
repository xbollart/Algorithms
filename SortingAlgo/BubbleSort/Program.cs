using System;
using System.Linq;


namespace BubbleSort
{
    class Program
    {
        private static readonly int[] array = { 1, 5, 4, 7, 3, 9, 8, 2, 6 };

        private static void Main()
        {
            Console.WriteLine("Bubble Sort");
            Console.WriteLine();
            Console.WriteLine("Time Complexity: Best n, Average n2, Worst n2");
            Console.WriteLine("Memory Complexity: 1");
            Console.WriteLine();
            DisplayArray();
            BubbleSort();
            DisplayArray();

            Console.ReadLine();
        }

        private static void BubbleSort()
        {
            bool sorted;
            do
            {
                sorted = true;
                for (int i = 1; i < array.Count(); i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        int temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                        sorted = false;
                    }
                }
            } while (!sorted);
        }

        private static void DisplayArray()
        {
            foreach (int val in array)
                Console.Write(val + " ");
            Console.WriteLine();
        }
    }
}
