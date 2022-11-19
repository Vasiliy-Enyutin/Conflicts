using System;

namespace Enyutin_Kononenko_GIT
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 9, 4, 6, 4, 1, 2, 3, 2, 8, 7, 7 };

            Console.WriteLine("Unsorted");
            foreach (int n in arr)
                Console.Write(n + " ");
            Console.WriteLine();

            QSort(arr);

            Console.WriteLine("Sorted");
            foreach (int n in arr)
                Console.Write(n + " ");
            Console.WriteLine();
        }

        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        static void QSort(int[] array, int firstIndex = 0, int lastIndex = -1)
        {
            if (lastIndex < 0)
                lastIndex = array.Length - 1;
            if (firstIndex >= lastIndex)
                return;
            int middleIndex = (lastIndex - firstIndex) / 2 + firstIndex, currentIndex = firstIndex;
            Swap(ref array[firstIndex], ref array[middleIndex]);
            for (int i = firstIndex + 1; i <= lastIndex; ++i)
            {
                if (array[i] <= array[firstIndex])
                {
                    Swap(ref array[++currentIndex], ref array[i]);
                }
            }
            Swap(ref array[firstIndex], ref array[currentIndex]);
            QSort(array, firstIndex, currentIndex - 1);
            QSort(array, currentIndex + 1, lastIndex);
        }
    }
}
