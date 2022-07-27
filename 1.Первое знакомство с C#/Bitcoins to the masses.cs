using System;

namespace Bitcoins_to_the_masses
{
    class Program
    {
        public static void Main()
        {
            double amount = 1.11; //количество биткоинов от одного человека
            int peopleCount = 60; // количество человек
            double totalMoney = (int)Math.Round(amount*peopleCount); // ← исправьте ошибку в этой строке
            Console.WriteLine(totalMoney);
        }
    }
}