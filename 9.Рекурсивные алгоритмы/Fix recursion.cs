using System;

namespace Fix_recursion
{
    class Program
    {
        public static void Main()
        {
            var arr = new[] {'1', '1', '2', '2', '3', '3' };
            WriteReversed(arr,0);
        }
        public static void WriteReversed(char[] items, int startIndex = 0)
        {
              if (startIndex<items.Length-1 && items.Length!=0)
                WriteReversed(items, startIndex + 1);
              Console.Write(items[startIndex]); 
        }
    }
}