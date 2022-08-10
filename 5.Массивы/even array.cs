using System;

namespace even_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = string.Join(",", GetFirstEvenNumbers(5));
            Console.WriteLine(result);
        }
        
        public static int[] GetFirstEvenNumbers(int amount)
        {
            int[] array = new int[amount];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i+1) * 2;
            }
            return array;
        }   

    }
}
