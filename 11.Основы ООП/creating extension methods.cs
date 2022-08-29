using System;

namespace Creating_Extension_Methods
{
    class Program
    {
        public static void Main()
        {
            var arg1 = "100500";
            Console.Write(arg1.ToInt() + "42".ToInt()); // 100542
        }

    }
    
    public static  class StringExtension
    {
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }
    }
}