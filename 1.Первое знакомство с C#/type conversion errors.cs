using System;

namespace Ошибки_преобразования_типов
{
    class Program
    {
        public static void Main()
        {
            float pi = (float) Math.PI;
            double tenThousand = 10000L;
            double tenThousandPi = (double) pi * tenThousand;
            int roundedTenThousandPi = (int) Math.Round(tenThousandPi);
            int integerPartOfTenThousandPi = (int) tenThousandPi;
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);
        }
    }
}   