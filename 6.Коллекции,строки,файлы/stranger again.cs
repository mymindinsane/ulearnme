using System;
using System.Text;

namespace stranger_again
{
    class Program
    {
        static void Main()
        {
            var commands = new[] { "push Привет! Это снова я! Пока!",
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
           for (int i = 0; i < commands.Length; i++)
           {
               if (commands[i].StartsWith("push"))
               {
                   builder.Append(commands[i].Substring(5));
               }
               else if (commands[i].StartsWith("pop"))
               {
                   int pop = Convert.ToInt32(commands[i].Substring(4));
                   builder.Remove(builder.Length - pop, pop);
               }
           }
           return builder.ToString();
        } 
    }
}
