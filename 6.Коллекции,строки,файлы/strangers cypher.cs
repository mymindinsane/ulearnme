using System;
using System.Collections.Generic;

namespace strangers_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] message =
            {
                "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ",
                "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой",
                "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть",
                "если особенно упорно подойдешь к делу",
                "",
                "будет Трудно конечнО",
                "Код ведЬ не из простых",
                "очень ХОРОШИЙ код",
                "то у тебя все получится",
                "и я буДу Писать тЕбЕ еще",
                "",
                "чао"
            };
            string result = DecodeMessage(message);
            Console.WriteLine(result);
        }

        private static string DecodeMessage(string[] lines)
        {
            var list = new List<string>();
            for (int i = lines.Length - 1; i >= 0; i--)
            {
                for (int j = lines[i].Split(' ').Length - 1; j >= 0; j--)
                {
                    var word = lines[i].Split(" ")[j];
                    if (word.Length > 0 && char.IsUpper(word[0]))
                    {
                        list.Add(word);
                    }
                }
            }


            string message = "";
            foreach (var word in list)
            {
                message += word + " ";
            }

            return message;


        }

    }
}