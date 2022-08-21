using System;

namespace Recursive_binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = { 2, 4, 4, 6 };
            int result;
            long value;
            for (value = 1; value < 8; value++)
            { 
                result = FindLeftBorder(arr, value);
                Console.WriteLine("{0} {1}",(int)value, result);
            }
            long[] array = new long[] { };
            value = 1;
            result = FindLeftBorder(array, 1);
            Console.WriteLine("{0} {1}", (int)value, result);
            Console.ReadKey();
        }
        private static int FindLeftBorder(long[] arr, long value)
        {
            return BinSearchLeftBorder(arr, value, -1, arr.Length);
        }
        //public static int BinSearchLeftBorder(long[] array, long value, int left, int right)
        {
            if (...) return left;
            var m = (left + right) / 2;
            if (array[m] < value)
                return BinSearchLeftBorder(array, value, ...);
            return BinSearchLeftBorder(array, value, ...);
        }
    }
}