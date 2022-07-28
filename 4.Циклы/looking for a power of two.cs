using System;

namespace looking_for_a_power_of_two
{
    class Program
    {
       public static void Main()
       {
       	Console.WriteLine(GetMinPowerOfTwoLargerThan(2)); // => 4
       	Console.WriteLine(GetMinPowerOfTwoLargerThan(15)); // => 16
       	Console.WriteLine(GetMinPowerOfTwoLargerThan(-2)); // => 1
       	Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
       	Console.WriteLine(GetMinPowerOfTwoLargerThan(100));
       
       }
       
       private static int GetMinPowerOfTwoLargerThan(int number)
       {
	       int result = 1;
	       while (number>=result)
		       result *=2;
	       return result;
       }
    }
}
