using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program185
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Система счисления (2/8/10/16): ");
            if (!int.TryParse(Console.ReadLine(), out int baseNum) || !new[] { 2, 8, 10, 16 }.Contains(baseNum))
            {
                Console.WriteLine("Недопустимая система.");
                return;
            }

            Console.Write("Число в десятичной системе: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Ошибка числа.");
                return;
            }

            string result = Convert.ToString(number, baseNum);
            Console.WriteLine($"Число в системе {baseNum}: {result}");
        }
    }
}
