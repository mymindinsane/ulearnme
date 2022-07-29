using System;
using System.Linq;

namespace High_Index
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        
        public static int MaxIndex(double[] array)
        {	
            if (array.Length==0)
                return -1;
            return Array.IndexOf(array,array.Max());
        }
    }
}