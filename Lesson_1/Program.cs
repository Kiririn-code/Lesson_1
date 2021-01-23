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
            string exitWord = "";
            while (exitWord != "exit")
            {
                Console.Write("Введите коловое слово: ");
                exitWord = Console.ReadLine();
            }
        }
    }
}
