using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static bool Sring_Palindrom(string str_a, string str_b)
        {
            return str_a.Select(Char.ToLower).OrderBy(ch => ch).SequenceEqual(str_b.Select(Char.ToLower).OrderBy(ch => ch));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Это приложение проверяет, явлеется ли строка 1 престановкой строки 2\n");

            Console.Write("Введите первую строку: ");
            string str_a = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string str_b = Console.ReadLine();
            Console.WriteLine();

            if (Sring_Palindrom(str_a, str_b) == true)
            {
                Console.WriteLine($"Строка {str_a} явлеяется перестановкой строки {str_b}");
            }
            else
            {
                Console.WriteLine($"Строка {str_a} не явлеяется перестановкой строки {str_b}");
            }

            Console.ReadLine();
        }
    }
}
