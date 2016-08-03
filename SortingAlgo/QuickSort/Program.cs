using System;

namespace QuickSort
{
    class Program
    {
        static int[] _array = { 1, 5, 4, 8, 6 };

        static void Main()
        {
            Console.WriteLine("Quick Sort");
            Console.WriteLine();
            Console.WriteLine("Time Complexity: Best nlogn, Average nlogn, Worst n2");
            Console.WriteLine("Memory Complexity: Average logn, worst n");
            Console.WriteLine();

            DisplayArray();
            QuickSort(_array, 0, _array.Length - 1);
            DisplayArray();
            Console.ReadLine();
        }

        private static void DisplayArray()
        {
            foreach (int val in _array)
                Console.Write(val + " ");
            Console.WriteLine();
        }

        static private void QuickSort(int[] a, int left, int right)
        {
            if (a == null)
                return;
            int i = left;
            int j = right;
            int pivot = a[(left + right) / 2];
            while (i <= j)
            {
                while (a[i] < pivot)
                    i++;
                while (a[j] > pivot)
                    j--;
                if (i <= j)
                {
                    int tmp = a[i];
                    a[i++] = a[j];
                    a[j--] = tmp;
                }
            }
            if (j > left)
                QuickSort(a, left, j);

            if (i < right)
                QuickSort(a, i, right);
        }
    }
}
