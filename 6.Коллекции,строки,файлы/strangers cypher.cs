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
            for (int i = 0; i < lines.Length; i++)
            {
                foreach (string word in lines[i].Split(" "))
                {
                    if (lines[i] != "" && char.IsUpper(word[0])&&word.Length>=1)
                    {
                        list.Add(word);
                    }
                }
            }
            list.Reverse();
            var output = string.Join(" ", list);
            return output;
        }
    }
}    
