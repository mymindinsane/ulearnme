using System;

namespace Benford
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PrintNumbers(GetBenfordStatistics("1"));
            PrintNumbers(GetBenfordStatistics("abc"));
            PrintNumbers(GetBenfordStatistics("123 456 789"));
            PrintNumbers(GetBenfordStatistics("abc 123 def 456 gf 789 i"));
        }
        public static void PrintNumbers(int[] a)
        {
            Console.WriteLine(string.Join(",", a));
            
        }
        public static int[] GetBenfordStatistics(string text)
        {
            var statistics = new int[10];
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) && (i==0 || !char.IsDigit(text[i-1])))
                {
                    statistics[text[i]-'0']++;
                }
            }
            return statistics;
        }
    }
}