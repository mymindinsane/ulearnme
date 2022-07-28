using System;

namespace border
{
    class Program
    {
        public static void Main()
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
        }
        
        private static void WriteTextWithBorder(string text)
        {
            string plus = "+";
            string minus = "-";
            string side = "|";
            string borderline = "";

            for (int i = 0; i <= text.Length + 1; i++)
            {
                borderline += minus;
            }
            
            Console.WriteLine(plus+borderline+plus);
            Console.WriteLine(side+" "+text+" "+side);
            Console.WriteLine(plus+borderline+plus);
            
        }  
        
        

    }
}