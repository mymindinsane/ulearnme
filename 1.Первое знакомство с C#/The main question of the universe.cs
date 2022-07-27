using System;

namespace The_main_question_of_the_universe
{
    class Program
    {
        public static void Main()
        {
            Print(GetSquare(42));
        }
        
        private static string GetSquare(int a)
        {
            return (a*=a).ToString();
        }
        private static void Print(string b)
        {
            Console.WriteLine(b);
        }
    }
}