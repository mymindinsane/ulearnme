using System;

namespace array_duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 4, 5, 2, 4 };
            Console.WriteLine(GetElementCount(arr,2));
        }
        
        public static int GetElementCount(int[] items, int itemToFind)
        {
            int count = 0;
            foreach (var e in items) 
                if (e == itemToFind) count++;
            return count;	
        }
    }
}
    
    

