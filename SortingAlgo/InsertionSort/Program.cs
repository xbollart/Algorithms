using System;
using System.Linq;

namespace InsertionSort
{
    class Program
    {
        static int[] _array = { 1, 5, 4, 7, 3, 9, 8, 2, 6 };

        static void Main()
        {
            Console.WriteLine("Insertion Sort");
            Console.WriteLine();
            Console.WriteLine("Time Complexity: Best n, Average n2, Worst n2");
            Console.WriteLine("Memory Complexity: 1");
            Console.WriteLine();

            DisplayArray();
            InsertionSort();
            DisplayArray();
            Console.ReadLine();
        }

        static private void InsertionSort()
        {
            for (int i = 1; i < _array.Count(); i++)
            {
                if (_array[i - 1] > _array[i])
                {
                    int value = _array[i];
                    for (int j = i; j >= 1; j--)
                    {
                        _array[j] = _array[j - 1];
                        if (value > _array[j - 2])
                        {
                            _array[j - 1] = value;
                            break;
                        }
                    }
                }
            }
        }

        private static void DisplayArray()
        {
            foreach (int val in _array)
                Console.Write(val + " ");
            Console.WriteLine();
        }
    }
}
