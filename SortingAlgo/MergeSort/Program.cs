using System;

namespace MergeSort
{
    class Program
    {
        private static readonly int[] _array = { 8, 1, 6, 9, 8, 4, 2, 5, 3, 9 };

        static void Main()
        {
            Console.WriteLine("Merge Sort");
            Console.WriteLine();
            Console.WriteLine("Time Complexity: Best nlogn, Average nlogn, Worst n2");
            Console.WriteLine("Memory Complexity: 1");
            Console.WriteLine();
            DisplayArray();
            MergeSort(_array, 0, 9);
            DisplayArray();
            Console.ReadLine();
        }

        public static void MergeSort(int[] tab, int bgn, int end)
        {
            if (bgn < end)
            {
                int middle = (bgn + end) / 2;
                MergeSort(tab, bgn, middle);
                MergeSort(tab, middle + 1, end);
                Merge(tab, bgn, middle, end);
            }
        }

        public static void Merge(int[] tab, int bgn, int middle, int end)
        {
            int[] old_tab = (int[])tab.Clone();

            int i1 = bgn; //indice dans la première moitié de old_tab
            int i2 = middle + 1; // indice dans la deuxième moitié de old_tab
            int i = bgn; //indice dans le tableau tab

            while (i1 <= middle && i2 <= end)
            {
                //quelle est la plus petite tête de liste?
                if (old_tab[i1] <= old_tab[i2])
                {
                    tab[i] = old_tab[i1];
                    i1++;
                }
                else
                {
                    tab[i] = old_tab[i2];
                    i2++;
                }
                i++;
            }
            if (i <= end)
            {
                while (i1 <= middle)  // le reste de la première moitié
                {
                    tab[i] = old_tab[i1];
                    i1++;
                    i++;
                }
                while (i2 <= end) // le reste de la deuxième moitié
                {
                    tab[i] = old_tab[i2];
                    i2++;
                    i++;
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
