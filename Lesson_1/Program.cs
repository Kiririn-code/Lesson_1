using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitWord;

            while (true)
            {
                Console.Write("Введите слово: ");
                exitWord = Console.ReadLine();
                if (exitWord=="exit")
                {
                    Console.WriteLine("Вы вышли из программы,поздравляем");
                    break;
                }
            }
        }
    }
}
