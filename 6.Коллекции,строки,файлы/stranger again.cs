using System;
using System.Net.Mime;
using System.Text;

namespace stranger_again
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = new string[] { "push Привет! Это снова я! Пока!",
                "pop 5",
                "push Как твои успехи? Плохо?",
                "push qwertyuiop",
                "push 1234567890",
                "pop 26" };

            Console.WriteLine(ApplyCommands(commands));
        }

        public static string ApplyCommands(string[] commands)
        {
           var builder = new StringBuilder();
           for (int i; i < commands.Length; i++)
           {
               if (commands[i].Contains("push"))
                   builder.Append(commands[i].Substring(5));
               else if (commands[i].Contains("pop"))
               {
                   int pop =Convert.ToInt32(commands[i].Substring(4));
                   builder.Remove(builder.Length - pop);
               }
                   
           }

           return builder.ToString();
        } 
    }
}
