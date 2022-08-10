//Находим индекс максимального элемента

using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       double[] arr = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
		Console.WriteLine(Convert.ToString(MaxIndex(arr)));
    }
    public static int MaxIndex(double[] array)
        {	
            if (array.Length==0)
                return -1;
            return Array.IndexOf(array,array.Max());
        }
}
