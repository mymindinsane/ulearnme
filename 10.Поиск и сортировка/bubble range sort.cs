using System;

namespace Bubble_range_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = BubbleSortRange(new[] { 4, 3, 2, 1 }, 1, 3);
            Console.WriteLine("{0} {1} {2} {3}",result[0], result[1], result[2], result[3]);
            Console.ReadKey();
        }
        public static int[] BubbleSortRange(int[] array, int left, int right)
        {
            for (int i = 0; i < array.Length; i++)
            for (int j = left; j < right; j++)
                if (array[j] > array[j + 1])
                {
                    var t = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = t;
                }
            return array;
        }
    }
}
