using System;

namespace Recursive_binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = { -1, 2, 4, 4, 6, 8, 11, 11, 16, 20, 22 };
            int result;
            long desiredNumber;
            for (desiredNumber = 1; desiredNumber < 23; desiredNumber++)
            { 
                result = FindLeftBorder(arr, desiredNumber);
                Console.WriteLine("{0} {1}",(int)desiredNumber, result);
            }
            long[] array = new long[] { };
            desiredNumber = 1;
            result = FindLeftBorder(array, 1);
            Console.WriteLine("{0} {1}", (int)desiredNumber, result);
            Console.ReadKey();
        }
        
        private static int FindLeftBorder(long[] arr, long value)
        {
            return BinSearchLeftBorder(arr, value, -1, arr.Length);
        }
        public static int BinSearchLeftBorder(long[] array, long desiredNumber, int left, int right)
        {
            if (right - left == 1) return left;//поиск левой границы максимального элемента меньшего чем desiredNumber
            var m = (left + right) / 2;
            if (array[m] < desiredNumber)
                return BinSearchLeftBorder(array, desiredNumber, m, right );
            return BinSearchLeftBorder(array, desiredNumber, left, m);
        }
    }
}
