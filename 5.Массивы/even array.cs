using System;

namespace even_array
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFirstEvenNumbers(5);
        }
        
        public static int[] GetFirstEvenNumbers(int amount)
        {
            int[] array = new int[amount];
            for (int i = 0; i < array.Length+1; i++)
            {
                array[i] = (i+1) * 2;
            }
            return array;
        }   

    }
}
