using System;

namespace Expand_the_array
{
    class Program
    {
        public static void Main()
        {
            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    
            // Метод PrintArray уже написан за вас
            PrintArray(GetPoweredArray(arrayToPower, 1));
    
            // если вы будете менять исходный массив, то следующие два теста сработают неверно:
            PrintArray(GetPoweredArray(arrayToPower, 2));
            PrintArray(GetPoweredArray(arrayToPower, 3));
    
            // не забывайте про частные случаи:
            PrintArray(GetPoweredArray(new int[0], 1));
            PrintArray(GetPoweredArray(new[] { 42 }, 0));
        }
        
        public static int[] GetPoweredArray(int[] arr, int power)
        {
            int [] result = new int [arr.Length];
            for (int i=0;i<arr.Length;i++)
            {
                result [i] = (int)Math.Pow(arr[i],power);
            }							  
            return result;
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(",", arr));
        }
    } 
    
    
    
}