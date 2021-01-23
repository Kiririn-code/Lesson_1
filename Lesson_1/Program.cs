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
            string userInput = "";
            while (userInput != "exit")
            {
                Console.Write("Введите коловое слово: ");
                userInput = Console.ReadLine();
            }
        }
    }
}
